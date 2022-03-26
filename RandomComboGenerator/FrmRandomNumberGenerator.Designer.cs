namespace RandomComboGenerator
{
    partial class frmRandomNumberGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandomNumberGenerator));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearCustom1 = new System.Windows.Forms.Button();
			this.rbDoNotUse1 = new System.Windows.Forms.RadioButton();
			this.numMax1 = new System.Windows.Forms.NumericUpDown();
			this.txtCustom1 = new System.Windows.Forms.TextBox();
			this.numMin1 = new System.Windows.Forms.NumericUpDown();
			this.chkAllowDups1 = new System.Windows.Forms.CheckBox();
			this.rbRange1 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.rbCustom1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbDoNotUse2 = new System.Windows.Forms.RadioButton();
			this.numMax2 = new System.Windows.Forms.NumericUpDown();
			this.btnClearCustom2 = new System.Windows.Forms.Button();
			this.numMin2 = new System.Windows.Forms.NumericUpDown();
			this.txtCustom2 = new System.Windows.Forms.TextBox();
			this.chkAllowDups2 = new System.Windows.Forms.CheckBox();
			this.rbRange2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.rbCustom2 = new System.Windows.Forms.RadioButton();
			this.btnCopy1To2 = new System.Windows.Forms.Button();
			this.btnCopy2To1 = new System.Windows.Forms.Button();
			this.btnSingleResult = new System.Windows.Forms.Button();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClearResults = new System.Windows.Forms.Button();
			this.chkAllowDupMatch = new System.Windows.Forms.CheckBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnAllResults = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblCount2 = new System.Windows.Forms.Label();
			this.lblCount1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnResetInput = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMax1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMax2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClearCustom1);
			this.groupBox1.Controls.Add(this.rbDoNotUse1);
			this.groupBox1.Controls.Add(this.numMax1);
			this.groupBox1.Controls.Add(this.txtCustom1);
			this.groupBox1.Controls.Add(this.numMin1);
			this.groupBox1.Controls.Add(this.chkAllowDups1);
			this.groupBox1.Controls.Add(this.rbRange1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rbCustom1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 333);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Group 1";
			// 
			// btnClearCustom1
			// 
			this.btnClearCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClearCustom1.Location = new System.Drawing.Point(6, 290);
			this.btnClearCustom1.Name = "btnClearCustom1";
			this.btnClearCustom1.Size = new System.Drawing.Size(109, 36);
			this.btnClearCustom1.TabIndex = 9;
			this.btnClearCustom1.Text = "Clear";
			this.btnClearCustom1.UseVisualStyleBackColor = true;
			this.btnClearCustom1.Click += new System.EventHandler(this.btnClearCustom1_Click);
			// 
			// rbDoNotUse1
			// 
			this.rbDoNotUse1.AutoSize = true;
			this.rbDoNotUse1.Location = new System.Drawing.Point(6, 56);
			this.rbDoNotUse1.Name = "rbDoNotUse1";
			this.rbDoNotUse1.Size = new System.Drawing.Size(107, 24);
			this.rbDoNotUse1.TabIndex = 3;
			this.rbDoNotUse1.TabStop = true;
			this.rbDoNotUse1.Text = "Do Not Use";
			this.rbDoNotUse1.UseVisualStyleBackColor = true;
			// 
			// numMax1
			// 
			this.numMax1.Location = new System.Drawing.Point(186, 85);
			this.numMax1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMax1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numMax1.Name = "numMax1";
			this.numMax1.Size = new System.Drawing.Size(64, 27);
			this.numMax1.TabIndex = 6;
			// 
			// txtCustom1
			// 
			this.txtCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustom1.Location = new System.Drawing.Point(6, 149);
			this.txtCustom1.Multiline = true;
			this.txtCustom1.Name = "txtCustom1";
			this.txtCustom1.ReadOnly = true;
			this.txtCustom1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCustom1.Size = new System.Drawing.Size(285, 135);
			this.txtCustom1.TabIndex = 8;
			// 
			// numMin1
			// 
			this.numMin1.Location = new System.Drawing.Point(70, 85);
			this.numMin1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMin1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numMin1.Name = "numMin1";
			this.numMin1.Size = new System.Drawing.Size(64, 27);
			this.numMin1.TabIndex = 5;
			// 
			// chkAllowDups1
			// 
			this.chkAllowDups1.AutoSize = true;
			this.chkAllowDups1.Location = new System.Drawing.Point(6, 26);
			this.chkAllowDups1.Name = "chkAllowDups1";
			this.chkAllowDups1.Size = new System.Drawing.Size(173, 24);
			this.chkAllowDups1.TabIndex = 1;
			this.chkAllowDups1.Text = "Allow Duplicate Picks";
			this.chkAllowDups1.UseVisualStyleBackColor = true;
			// 
			// rbRange1
			// 
			this.rbRange1.AutoSize = true;
			this.rbRange1.Checked = true;
			this.rbRange1.Location = new System.Drawing.Point(6, 86);
			this.rbRange1.Name = "rbRange1";
			this.rbRange1.Size = new System.Drawing.Size(58, 24);
			this.rbRange1.TabIndex = 4;
			this.rbRange1.TabStop = true;
			this.rbRange1.Text = "Min:";
			this.rbRange1.UseVisualStyleBackColor = true;
			this.rbRange1.CheckedChanged += new System.EventHandler(this.rbRange1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Max:";
			// 
			// rbCustom1
			// 
			this.rbCustom1.AutoSize = true;
			this.rbCustom1.Location = new System.Drawing.Point(6, 119);
			this.rbCustom1.Name = "rbCustom1";
			this.rbCustom1.Size = new System.Drawing.Size(231, 24);
			this.rbCustom1.TabIndex = 7;
			this.rbCustom1.TabStop = true;
			this.rbCustom1.Text = "Enter each entry on a new line:";
			this.rbCustom1.UseVisualStyleBackColor = true;
			this.rbCustom1.CheckedChanged += new System.EventHandler(this.rbCustom1_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rbDoNotUse2);
			this.groupBox2.Controls.Add(this.numMax2);
			this.groupBox2.Controls.Add(this.btnClearCustom2);
			this.groupBox2.Controls.Add(this.numMin2);
			this.groupBox2.Controls.Add(this.txtCustom2);
			this.groupBox2.Controls.Add(this.chkAllowDups2);
			this.groupBox2.Controls.Add(this.rbRange2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.rbCustom2);
			this.groupBox2.Location = new System.Drawing.Point(458, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(297, 333);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Group 2";
			// 
			// rbDoNotUse2
			// 
			this.rbDoNotUse2.AutoSize = true;
			this.rbDoNotUse2.Location = new System.Drawing.Point(6, 56);
			this.rbDoNotUse2.Name = "rbDoNotUse2";
			this.rbDoNotUse2.Size = new System.Drawing.Size(107, 24);
			this.rbDoNotUse2.TabIndex = 12;
			this.rbDoNotUse2.TabStop = true;
			this.rbDoNotUse2.Text = "Do Not Use";
			this.rbDoNotUse2.UseVisualStyleBackColor = true;
			// 
			// numMax2
			// 
			this.numMax2.Location = new System.Drawing.Point(186, 85);
			this.numMax2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMax2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numMax2.Name = "numMax2";
			this.numMax2.Size = new System.Drawing.Size(64, 27);
			this.numMax2.TabIndex = 15;
			// 
			// btnClearCustom2
			// 
			this.btnClearCustom2.Location = new System.Drawing.Point(6, 290);
			this.btnClearCustom2.Name = "btnClearCustom2";
			this.btnClearCustom2.Size = new System.Drawing.Size(109, 36);
			this.btnClearCustom2.TabIndex = 18;
			this.btnClearCustom2.Text = "Clear";
			this.btnClearCustom2.UseVisualStyleBackColor = true;
			this.btnClearCustom2.Click += new System.EventHandler(this.btnClearCustom2_Click);
			// 
			// numMin2
			// 
			this.numMin2.Location = new System.Drawing.Point(70, 85);
			this.numMin2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMin2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numMin2.Name = "numMin2";
			this.numMin2.Size = new System.Drawing.Size(64, 27);
			this.numMin2.TabIndex = 14;
			// 
			// txtCustom2
			// 
			this.txtCustom2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustom2.Location = new System.Drawing.Point(6, 149);
			this.txtCustom2.Multiline = true;
			this.txtCustom2.Name = "txtCustom2";
			this.txtCustom2.ReadOnly = true;
			this.txtCustom2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCustom2.Size = new System.Drawing.Size(285, 135);
			this.txtCustom2.TabIndex = 17;
			// 
			// chkAllowDups2
			// 
			this.chkAllowDups2.AutoSize = true;
			this.chkAllowDups2.Location = new System.Drawing.Point(6, 26);
			this.chkAllowDups2.Name = "chkAllowDups2";
			this.chkAllowDups2.Size = new System.Drawing.Size(173, 24);
			this.chkAllowDups2.TabIndex = 10;
			this.chkAllowDups2.Text = "Allow Duplicate Picks";
			this.chkAllowDups2.UseVisualStyleBackColor = true;
			// 
			// rbRange2
			// 
			this.rbRange2.AutoSize = true;
			this.rbRange2.Checked = true;
			this.rbRange2.Location = new System.Drawing.Point(6, 86);
			this.rbRange2.Name = "rbRange2";
			this.rbRange2.Size = new System.Drawing.Size(58, 24);
			this.rbRange2.TabIndex = 13;
			this.rbRange2.TabStop = true;
			this.rbRange2.Text = "Min:";
			this.rbRange2.UseVisualStyleBackColor = true;
			this.rbRange2.CheckedChanged += new System.EventHandler(this.rbRange2_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(140, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Max:";
			// 
			// rbCustom2
			// 
			this.rbCustom2.AutoSize = true;
			this.rbCustom2.Location = new System.Drawing.Point(6, 119);
			this.rbCustom2.Name = "rbCustom2";
			this.rbCustom2.Size = new System.Drawing.Size(231, 24);
			this.rbCustom2.TabIndex = 16;
			this.rbCustom2.TabStop = true;
			this.rbCustom2.Text = "Enter each entry on a new line:";
			this.rbCustom2.UseVisualStyleBackColor = true;
			this.rbCustom2.CheckedChanged += new System.EventHandler(this.rbCustom2_CheckedChanged);
			// 
			// btnCopy1To2
			// 
			this.btnCopy1To2.Location = new System.Drawing.Point(315, 131);
			this.btnCopy1To2.Name = "btnCopy1To2";
			this.btnCopy1To2.Size = new System.Drawing.Size(137, 39);
			this.btnCopy1To2.TabIndex = 20;
			this.btnCopy1To2.Text = "Copy =>";
			this.btnCopy1To2.UseVisualStyleBackColor = true;
			this.btnCopy1To2.Click += new System.EventHandler(this.btnCopy1To2_Click);
			// 
			// btnCopy2To1
			// 
			this.btnCopy2To1.Location = new System.Drawing.Point(315, 176);
			this.btnCopy2To1.Name = "btnCopy2To1";
			this.btnCopy2To1.Size = new System.Drawing.Size(137, 39);
			this.btnCopy2To1.TabIndex = 21;
			this.btnCopy2To1.Text = "<= Copy";
			this.btnCopy2To1.UseVisualStyleBackColor = true;
			this.btnCopy2To1.Click += new System.EventHandler(this.btnCopy2To1_Click);
			// 
			// btnSingleResult
			// 
			this.btnSingleResult.Location = new System.Drawing.Point(12, 373);
			this.btnSingleResult.Name = "btnSingleResult";
			this.btnSingleResult.Size = new System.Drawing.Size(109, 36);
			this.btnSingleResult.TabIndex = 22;
			this.btnSingleResult.Text = "Single Result";
			this.btnSingleResult.UseVisualStyleBackColor = true;
			this.btnSingleResult.Click += new System.EventHandler(this.btnSingleResult_Click);
			// 
			// txtResults
			// 
			this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtResults.Location = new System.Drawing.Point(12, 435);
			this.txtResults.Multiline = true;
			this.txtResults.Name = "txtResults";
			this.txtResults.ReadOnly = true;
			this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResults.Size = new System.Drawing.Size(744, 166);
			this.txtResults.TabIndex = 7;
			this.txtResults.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Results:";
			// 
			// btnClearResults
			// 
			this.btnClearResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearResults.Location = new System.Drawing.Point(646, 373);
			this.btnClearResults.Name = "btnClearResults";
			this.btnClearResults.Size = new System.Drawing.Size(109, 36);
			this.btnClearResults.TabIndex = 25;
			this.btnClearResults.Text = "Clear Results";
			this.btnClearResults.UseVisualStyleBackColor = true;
			this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
			// 
			// chkAllowDupMatch
			// 
			this.chkAllowDupMatch.Location = new System.Drawing.Point(315, 38);
			this.chkAllowDupMatch.Name = "chkAllowDupMatch";
			this.chkAllowDupMatch.Size = new System.Drawing.Size(137, 44);
			this.chkAllowDupMatch.TabIndex = 19;
			this.chkAllowDupMatch.Text = "Allow Duplicate Matches";
			this.chkAllowDupMatch.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(531, 373);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(109, 36);
			this.btnReset.TabIndex = 24;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnAllResults
			// 
			this.btnAllResults.Location = new System.Drawing.Point(127, 373);
			this.btnAllResults.Name = "btnAllResults";
			this.btnAllResults.Size = new System.Drawing.Size(109, 36);
			this.btnAllResults.TabIndex = 23;
			this.btnAllResults.Text = "All Results";
			this.btnAllResults.UseVisualStyleBackColor = true;
			this.btnAllResults.Click += new System.EventHandler(this.btnAllResults_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblCount2);
			this.groupBox3.Controls.Add(this.lblCount1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(279, 357);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(210, 56);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Remaining";
			// 
			// lblCount2
			// 
			this.lblCount2.AutoSize = true;
			this.lblCount2.Location = new System.Drawing.Point(173, 31);
			this.lblCount2.Name = "lblCount2";
			this.lblCount2.Size = new System.Drawing.Size(17, 20);
			this.lblCount2.TabIndex = 3;
			this.lblCount2.Text = "0";
			// 
			// lblCount1
			// 
			this.lblCount1.AutoSize = true;
			this.lblCount1.Location = new System.Drawing.Point(70, 31);
			this.lblCount1.Name = "lblCount1";
			this.lblCount1.Size = new System.Drawing.Size(17, 20);
			this.lblCount1.TabIndex = 2;
			this.lblCount1.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(109, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Group 2:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Group 1:";
			// 
			// btnResetInput
			// 
			this.btnResetInput.Location = new System.Drawing.Point(315, 221);
			this.btnResetInput.Name = "btnResetInput";
			this.btnResetInput.Size = new System.Drawing.Size(137, 39);
			this.btnResetInput.TabIndex = 22;
			this.btnResetInput.Text = "Reset Input";
			this.btnResetInput.UseVisualStyleBackColor = true;
			this.btnResetInput.Click += new System.EventHandler(this.btnResetInput_Click);
			// 
			// frmRandomNumberGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 613);
			this.Controls.Add(this.btnResetInput);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnAllResults);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnClearResults);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtResults);
			this.Controls.Add(this.btnSingleResult);
			this.Controls.Add(this.btnCopy2To1);
			this.Controls.Add(this.btnCopy1To2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.chkAllowDupMatch);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(786, 530);
			this.Name = "frmRandomNumberGenerator";
			this.Text = "Random Combo Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMax1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMax2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMin2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCustom1;
        private RadioButton rbRange1;
        private Label label2;
        private RadioButton rbCustom1;
        private TextBox txtCustom2;
        private RadioButton rbRange2;
        private Label label1;
        private RadioButton rbCustom2;
        private Button btnCopy1To2;
        private Button btnCopy2To1;
        private Button btnSingleResult;
        private TextBox txtResults;
        private Label label3;
        private Button btnClearCustom1;
        private CheckBox chkAllowDups1;
        private Button btnClearCustom2;
        private CheckBox chkAllowDups2;
        private Button btnClearResults;
        private CheckBox chkAllowDupMatch;
        private NumericUpDown numMin1;
        private NumericUpDown numMax1;
        private NumericUpDown numMax2;
        private NumericUpDown numMin2;
        private Button btnReset;
        private RadioButton rbDoNotUse1;
        private RadioButton rbDoNotUse2;
        private Button btnAllResults;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label lblCount1;
        private Label lblCount2;
		private Button btnResetInput;
	}
}