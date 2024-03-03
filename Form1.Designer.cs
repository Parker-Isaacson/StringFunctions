namespace StringFunctions
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.cmdSubstring = new System.Windows.Forms.Button();
            this.cmdStartsWith = new System.Windows.Forms.Button();
            this.cmdSplit = new System.Windows.Forms.Button();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdPadRight = new System.Windows.Forms.Button();
            this.cmdPadLeft = new System.Windows.Forms.Button();
            this.cmdLastIndexOfAny = new System.Windows.Forms.Button();
            this.cmdLastIndexOf = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdIndexOfAny = new System.Windows.Forms.Button();
            this.cmdIndexOf = new System.Windows.Forms.Button();
            this.cmdEndsWith = new System.Windows.Forms.Button();
            this.cmdContains = new System.Windows.Forms.Button();
            this.grbCutsomMethods = new System.Windows.Forms.GroupBox();
            this.cmdToHex = new System.Windows.Forms.Button();
            this.cmdFind = new System.Windows.Forms.Button();
            this.grbButtons.SuspendLayout();
            this.grbCutsomMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(20, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(368, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Input";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 361);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(776, 77);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "Output";
            // 
            // txtParams
            // 
            this.txtParams.Location = new System.Drawing.Point(420, 12);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(368, 26);
            this.txtParams.TabIndex = 2;
            this.txtParams.Text = "Parameters";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.cmdSubstring);
            this.grbButtons.Controls.Add(this.cmdStartsWith);
            this.grbButtons.Controls.Add(this.cmdSplit);
            this.grbButtons.Controls.Add(this.cmdReplace);
            this.grbButtons.Controls.Add(this.cmdRemove);
            this.grbButtons.Controls.Add(this.cmdPadRight);
            this.grbButtons.Controls.Add(this.cmdPadLeft);
            this.grbButtons.Controls.Add(this.cmdLastIndexOfAny);
            this.grbButtons.Controls.Add(this.cmdLastIndexOf);
            this.grbButtons.Controls.Add(this.cmdInsert);
            this.grbButtons.Controls.Add(this.cmdIndexOfAny);
            this.grbButtons.Controls.Add(this.cmdIndexOf);
            this.grbButtons.Controls.Add(this.cmdEndsWith);
            this.grbButtons.Controls.Add(this.cmdContains);
            this.grbButtons.Location = new System.Drawing.Point(13, 46);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(775, 127);
            this.grbButtons.TabIndex = 5;
            this.grbButtons.TabStop = false;
            this.grbButtons.Text = "String Method";
            // 
            // cmdSubstring
            // 
            this.cmdSubstring.Location = new System.Drawing.Point(562, 72);
            this.cmdSubstring.Name = "cmdSubstring";
            this.cmdSubstring.Size = new System.Drawing.Size(90, 40);
            this.cmdSubstring.TabIndex = 13;
            this.cmdSubstring.Text = "Substring";
            this.cmdSubstring.UseVisualStyleBackColor = true;
            this.cmdSubstring.Click += new System.EventHandler(this.cmdSubstring_Click);
            // 
            // cmdStartsWith
            // 
            this.cmdStartsWith.Location = new System.Drawing.Point(446, 72);
            this.cmdStartsWith.Name = "cmdStartsWith";
            this.cmdStartsWith.Size = new System.Drawing.Size(110, 40);
            this.cmdStartsWith.TabIndex = 12;
            this.cmdStartsWith.Text = "StartsWith";
            this.cmdStartsWith.UseVisualStyleBackColor = true;
            this.cmdStartsWith.Click += new System.EventHandler(this.cmdStartsWith_Click);
            // 
            // cmdSplit
            // 
            this.cmdSplit.Location = new System.Drawing.Point(380, 72);
            this.cmdSplit.Name = "cmdSplit";
            this.cmdSplit.Size = new System.Drawing.Size(60, 40);
            this.cmdSplit.TabIndex = 11;
            this.cmdSplit.Text = "Split";
            this.cmdSplit.UseVisualStyleBackColor = true;
            this.cmdSplit.Click += new System.EventHandler(this.cmdSplit_Click);
            // 
            // cmdReplace
            // 
            this.cmdReplace.Location = new System.Drawing.Point(284, 72);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(90, 40);
            this.cmdReplace.TabIndex = 10;
            this.cmdReplace.Text = "Replace";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(188, 72);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(90, 40);
            this.cmdRemove.TabIndex = 9;
            this.cmdRemove.Text = "Remove";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdPadRight
            // 
            this.cmdPadRight.Location = new System.Drawing.Point(92, 72);
            this.cmdPadRight.Name = "cmdPadRight";
            this.cmdPadRight.Size = new System.Drawing.Size(90, 40);
            this.cmdPadRight.TabIndex = 8;
            this.cmdPadRight.Text = "PadRight";
            this.cmdPadRight.UseVisualStyleBackColor = true;
            this.cmdPadRight.Click += new System.EventHandler(this.cmdPadRight_Click);
            // 
            // cmdPadLeft
            // 
            this.cmdPadLeft.Location = new System.Drawing.Point(6, 72);
            this.cmdPadLeft.Name = "cmdPadLeft";
            this.cmdPadLeft.Size = new System.Drawing.Size(80, 40);
            this.cmdPadLeft.TabIndex = 7;
            this.cmdPadLeft.Text = "PadLeft";
            this.cmdPadLeft.UseVisualStyleBackColor = true;
            this.cmdPadLeft.Click += new System.EventHandler(this.cmdPadLeft_Click);
            // 
            // cmdLastIndexOfAny
            // 
            this.cmdLastIndexOfAny.Location = new System.Drawing.Point(633, 26);
            this.cmdLastIndexOfAny.Name = "cmdLastIndexOfAny";
            this.cmdLastIndexOfAny.Size = new System.Drawing.Size(136, 40);
            this.cmdLastIndexOfAny.TabIndex = 6;
            this.cmdLastIndexOfAny.Text = "LastIndexOfAny";
            this.cmdLastIndexOfAny.UseVisualStyleBackColor = true;
            this.cmdLastIndexOfAny.Click += new System.EventHandler(this.cmdLastIndexOfAny_Click);
            // 
            // cmdLastIndexOf
            // 
            this.cmdLastIndexOf.Location = new System.Drawing.Point(517, 26);
            this.cmdLastIndexOf.Name = "cmdLastIndexOf";
            this.cmdLastIndexOf.Size = new System.Drawing.Size(110, 40);
            this.cmdLastIndexOf.TabIndex = 5;
            this.cmdLastIndexOf.Text = "LastIndexOf";
            this.cmdLastIndexOf.UseVisualStyleBackColor = true;
            this.cmdLastIndexOf.Click += new System.EventHandler(this.cmdLastIndexOf_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(421, 26);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(90, 40);
            this.cmdInsert.TabIndex = 4;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdIndexOfAny
            // 
            this.cmdIndexOfAny.Location = new System.Drawing.Point(305, 25);
            this.cmdIndexOfAny.Name = "cmdIndexOfAny";
            this.cmdIndexOfAny.Size = new System.Drawing.Size(110, 40);
            this.cmdIndexOfAny.TabIndex = 3;
            this.cmdIndexOfAny.Text = "IndexOfAny";
            this.cmdIndexOfAny.UseVisualStyleBackColor = true;
            this.cmdIndexOfAny.Click += new System.EventHandler(this.cmdIndexOfAny_Click);
            // 
            // cmdIndexOf
            // 
            this.cmdIndexOf.Location = new System.Drawing.Point(209, 26);
            this.cmdIndexOf.Name = "cmdIndexOf";
            this.cmdIndexOf.Size = new System.Drawing.Size(90, 40);
            this.cmdIndexOf.TabIndex = 2;
            this.cmdIndexOf.Text = "IndexOf";
            this.cmdIndexOf.UseVisualStyleBackColor = true;
            this.cmdIndexOf.Click += new System.EventHandler(this.cmdIndexOf_Click);
            // 
            // cmdEndsWith
            // 
            this.cmdEndsWith.Location = new System.Drawing.Point(103, 25);
            this.cmdEndsWith.Name = "cmdEndsWith";
            this.cmdEndsWith.Size = new System.Drawing.Size(100, 40);
            this.cmdEndsWith.TabIndex = 1;
            this.cmdEndsWith.Text = "EndsWith";
            this.cmdEndsWith.UseVisualStyleBackColor = true;
            this.cmdEndsWith.Click += new System.EventHandler(this.cmdEndsWith_Click);
            // 
            // cmdContains
            // 
            this.cmdContains.Location = new System.Drawing.Point(7, 26);
            this.cmdContains.Name = "cmdContains";
            this.cmdContains.Size = new System.Drawing.Size(90, 40);
            this.cmdContains.TabIndex = 0;
            this.cmdContains.Text = "Contains";
            this.cmdContains.UseVisualStyleBackColor = true;
            this.cmdContains.Click += new System.EventHandler(this.cmdContains_Click);
            // 
            // grbCutsomMethods
            // 
            this.grbCutsomMethods.Controls.Add(this.cmdToHex);
            this.grbCutsomMethods.Controls.Add(this.cmdFind);
            this.grbCutsomMethods.Location = new System.Drawing.Point(13, 180);
            this.grbCutsomMethods.Name = "grbCutsomMethods";
            this.grbCutsomMethods.Size = new System.Drawing.Size(200, 72);
            this.grbCutsomMethods.TabIndex = 6;
            this.grbCutsomMethods.TabStop = false;
            this.grbCutsomMethods.Text = "Custom String Methods";
            // 
            // cmdToHex
            // 
            this.cmdToHex.Location = new System.Drawing.Point(72, 25);
            this.cmdToHex.Name = "cmdToHex";
            this.cmdToHex.Size = new System.Drawing.Size(70, 40);
            this.cmdToHex.TabIndex = 15;
            this.cmdToHex.Text = "ToHex";
            this.cmdToHex.UseVisualStyleBackColor = true;
            this.cmdToHex.Click += new System.EventHandler(this.cmdToHex_Click);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(6, 25);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(60, 40);
            this.cmdFind.TabIndex = 14;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCutsomMethods);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbButtons.ResumeLayout(false);
            this.grbCutsomMethods.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button cmdContains;
        private System.Windows.Forms.Button cmdEndsWith;
        private System.Windows.Forms.Button cmdIndexOf;
        private System.Windows.Forms.Button cmdIndexOfAny;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdLastIndexOfAny;
        private System.Windows.Forms.Button cmdLastIndexOf;
        private System.Windows.Forms.Button cmdPadRight;
        private System.Windows.Forms.Button cmdPadLeft;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdReplace;
        private System.Windows.Forms.Button cmdSplit;
        private System.Windows.Forms.Button cmdStartsWith;
        private System.Windows.Forms.Button cmdSubstring;
        private System.Windows.Forms.GroupBox grbCutsomMethods;
        private System.Windows.Forms.Button cmdToHex;
        private System.Windows.Forms.Button cmdFind;
    }
}

