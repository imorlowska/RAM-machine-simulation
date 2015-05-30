using System;
using System.Linq;
using System.Windows.Forms;
using RMS.Framework;

namespace RMS
{
    public partial class Display : Form
    {
        private Machine _currentMachine;

        public Display()
        {
            InitializeComponent();
            for (var i = 0; i < 8; i++)
                cbCommand.Items.Add(new Command {Type = (CommandType) i});
            cbCommand.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
        }

        private void cbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableArgumentFields(((Command)cbCommand.SelectedItem).NumberOfArguments());
        }

        private void EnableArgumentFields(int fields)
        {
            txtArg3.Enabled = txtArg2.Enabled = txtArg1.Enabled = true;
            var t = 3 - fields;
            if (t == 0) return;
            txtArg3.Enabled = false;
            t--;
            if (t == 0) return;
            txtArg2.Enabled = false;
            t--;
            if (t == 0) return;
            txtArg1.Enabled = false;
        }

        private int ParseValue(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text.Trim())) return 0;
            int result;
            int.TryParse(text, out result);
            return result;
        }

        private Command CreateCommad()
        {
            var command = new Command()
            {
                Type = ((Command) cbCommand.SelectedItem).Type,
                Position = lbCommands.Items.Count == 0 ? 0 : ((Command)lbCommands.Items[lbCommands.Items.Count-1]).Position+1,
                
            };
            var arguments = command.NumberOfArguments();
            if (arguments-- == 0)
                return command;
            command.Arg1 = ParseValue(txtArg1.Text);
            if (arguments-- == 0)
                return command;
            command.Arg2 = ParseValue(txtArg2.Text);
            if (arguments-- == 0)
                return command;
            command.Arg3 = ParseValue(txtArg3.Text);
            return command;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbCommands.Items.Add(CreateCommad());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbCommands.SelectedIndex != -1)
                lbCommands.Items.RemoveAt(lbCommands.SelectedIndex);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var items = lbCommands.Items.Cast<Command>().ToList();
            var selectedItem = lbCommands.SelectedIndex;
            var itemAbove = selectedItem - 1;
            if (selectedItem == -1 || itemAbove == -1)
                return;

            var swap = items[selectedItem].Position;
            items[selectedItem].Position = items[itemAbove].Position;
            items[itemAbove].Position = swap;

            lbCommands.Items.Clear();
            var sortedItems = items.OrderBy(i => i.Position).Cast<object>().ToArray();
            lbCommands.Items.AddRange(sortedItems);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var items = lbCommands.Items.Cast<Command>().ToList();
            var selectedItem = lbCommands.SelectedIndex;
            var itemBelow = selectedItem + 1;
            if (selectedItem == -1 || selectedItem == lbCommands.Items.Count - 1)
                return;

            var swap = items[selectedItem].Position;
            items[selectedItem].Position = items[itemBelow].Position;
            items[itemBelow].Position = swap;

            lbCommands.Items.Clear();
            var sortedItems = items.OrderBy(i => i.Position).Cast<object>().ToArray();
            lbCommands.Items.AddRange(sortedItems);
        }

        private void btnInstallMachine_Click(object sender, EventArgs e)
        {
            try
            {
                _currentMachine = CreateMachine(Int32.Parse(txtSize.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj prawidłowy rozmiar taśmy.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private Machine CreateMachine(int size)
        {
            var machine = new Machine(size);
            lbCommands.Items.Cast<Command>().ToList().ForEach( c => machine.AddInstruction(c.Translate()));
            return machine;
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            while (MakeOneStep()) { }
        }

        private void btnRunStep_Click(object sender, EventArgs e)
        {
            MakeOneStep();
        }

        private bool MakeOneStep()
        {
            var result = false;
            if (_currentMachine != null)
            {
                result = _currentMachine.RunOneInstruction();
                if (result)
                {
                    lbOutput.Items.Add(_currentMachine.LastInstruction);
                    lbOutput.Items.AddRange(_currentMachine.GetTape().Select(e => e.ToString()).Cast<object>().ToArray());
                }
            }
            return result;
        }
    }
}
