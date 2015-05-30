using System.ComponentModel;
using System.Windows.Forms;

namespace RMS
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInstallMachine = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtArg3 = new System.Windows.Forms.TextBox();
            this.txtArg2 = new System.Windows.Forms.TextBox();
            this.txtArg1 = new System.Windows.Forms.TextBox();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.btnRunStep = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnLoadSample = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSize);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnInstallMachine);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnDown);
            this.splitContainer1.Panel1.Controls.Add(this.btnUp);
            this.splitContainer1.Panel1.Controls.Add(this.txtArg3);
            this.splitContainer1.Panel1.Controls.Add(this.txtArg2);
            this.splitContainer1.Panel1.Controls.Add(this.txtArg1);
            this.splitContainer1.Panel1.Controls.Add(this.cbCommand);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.lbCommands);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadSample);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnRunToEnd);
            this.splitContainer1.Panel2.Controls.Add(this.btnRunStep);
            this.splitContainer1.Panel2.Controls.Add(this.lbOutput);
            this.splitContainer1.Size = new System.Drawing.Size(967, 522);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(457, 461);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(56, 20);
            this.txtSize.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rozmiar taśmy:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Argument 3:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Argument 2:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Argument 1:";
            // 
            // btnInstallMachine
            // 
            this.btnInstallMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstallMachine.Location = new System.Drawing.Point(346, 487);
            this.btnInstallMachine.Name = "btnInstallMachine";
            this.btnInstallMachine.Size = new System.Drawing.Size(168, 23);
            this.btnInstallMachine.TabIndex = 10;
            this.btnInstallMachine.Text = "Stwórz maszynę";
            this.btnInstallMachine.UseVisualStyleBackColor = true;
            this.btnInstallMachine.Click += new System.EventHandler(this.btnInstallMachine_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(179, 487);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(376, 421);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(138, 32);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "Przesuń w dół";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(376, 384);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(138, 33);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Przesuń w górę";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtArg3
            // 
            this.txtArg3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArg3.Location = new System.Drawing.Point(82, 461);
            this.txtArg3.Name = "txtArg3";
            this.txtArg3.Size = new System.Drawing.Size(288, 20);
            this.txtArg3.TabIndex = 6;
            // 
            // txtArg2
            // 
            this.txtArg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArg2.Location = new System.Drawing.Point(82, 437);
            this.txtArg2.Name = "txtArg2";
            this.txtArg2.Size = new System.Drawing.Size(288, 20);
            this.txtArg2.TabIndex = 5;
            // 
            // txtArg1
            // 
            this.txtArg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArg1.Location = new System.Drawing.Point(82, 411);
            this.txtArg1.Name = "txtArg1";
            this.txtArg1.Size = new System.Drawing.Size(288, 20);
            this.txtArg1.TabIndex = 4;
            // 
            // cbCommand
            // 
            this.cbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Location = new System.Drawing.Point(12, 384);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(358, 21);
            this.cbCommand.TabIndex = 3;
            this.cbCommand.SelectedIndexChanged += new System.EventHandler(this.cbCommand_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(12, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbCommands
            // 
            this.lbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(12, 12);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(502, 368);
            this.lbCommands.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(314, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunToEnd.Location = new System.Drawing.Point(196, 490);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(112, 23);
            this.btnRunToEnd.TabIndex = 2;
            this.btnRunToEnd.Text = "Uruchom pozostałe";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnRunStep
            // 
            this.btnRunStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunStep.Location = new System.Drawing.Point(78, 490);
            this.btnRunStep.Name = "btnRunStep";
            this.btnRunStep.Size = new System.Drawing.Size(112, 23);
            this.btnRunStep.TabIndex = 1;
            this.btnRunStep.Text = "Następny krok";
            this.btnRunStep.UseVisualStyleBackColor = true;
            this.btnRunStep.Click += new System.EventHandler(this.btnRunStep_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(9, 12);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(417, 472);
            this.lbOutput.TabIndex = 0;
            // 
            // btnLoadSample
            // 
            this.btnLoadSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSample.Location = new System.Drawing.Point(9, 490);
            this.btnLoadSample.Name = "btnLoadSample";
            this.btnLoadSample.Size = new System.Drawing.Size(63, 23);
            this.btnLoadSample.TabIndex = 4;
            this.btnLoadSample.Text = "Domyślna";
            this.btnLoadSample.UseVisualStyleBackColor = true;
            this.btnLoadSample.Click += new System.EventHandler(this.btnLoadSample_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 522);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Display";
            this.Text = "Symulator Maszyny RAM";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lbCommands;
        private Button btnClear;
        private Button btnRunToEnd;
        private Button btnRunStep;
        private ListBox lbOutput;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInstallMachine;
        private Button btnRemove;
        private Button btnDown;
        private Button btnUp;
        private TextBox txtArg3;
        private TextBox txtArg2;
        private TextBox txtArg1;
        private ComboBox cbCommand;
        private TextBox txtSize;
        private Label label4;
        private Button btnLoadSample;

    }
}

