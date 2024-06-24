namespace FileSplitter
{
	partial class MainForm
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
			openFilebtn = new Button();
			label1 = new Label();
			filePathTextBox = new TextBox();
			LogTextBox = new TextBox();
			label3 = new Label();
			numericSizeOrParts = new NumericUpDown();
			labelSizeorParts = new Label();
			fileSufixComboBox = new ComboBox();
			oFD = new OpenFileDialog();
			splitBtn = new Button();
			checkBox1 = new CheckBox();
			((System.ComponentModel.ISupportInitialize)numericSizeOrParts).BeginInit();
			SuspendLayout();
			// 
			// openFilebtn
			// 
			openFilebtn.Location = new Point(12, 12);
			openFilebtn.Name = "openFilebtn";
			openFilebtn.Size = new Size(140, 54);
			openFilebtn.TabIndex = 0;
			openFilebtn.Text = "Open File...";
			openFilebtn.UseVisualStyleBackColor = true;
			openFilebtn.Click += openFilebtn_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(12, 106);
			label1.Name = "label1";
			label1.Size = new Size(87, 19);
			label1.TabIndex = 9;
			label1.Text = "Selected file: ";
			// 
			// filePathTextBox
			// 
			filePathTextBox.BorderStyle = BorderStyle.FixedSingle;
			filePathTextBox.Location = new Point(26, 128);
			filePathTextBox.Name = "filePathTextBox";
			filePathTextBox.ReadOnly = true;
			filePathTextBox.Size = new Size(471, 26);
			filePathTextBox.TabIndex = 4;
			filePathTextBox.TextChanged += filePathTextBox_TextChanged;
			// 
			// LogTextBox
			// 
			LogTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			LogTextBox.BorderStyle = BorderStyle.FixedSingle;
			LogTextBox.Location = new Point(12, 191);
			LogTextBox.Multiline = true;
			LogTextBox.Name = "LogTextBox";
			LogTextBox.ReadOnly = true;
			LogTextBox.Size = new Size(640, 263);
			LogTextBox.TabIndex = 8;
			LogTextBox.TabStop = false;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Location = new Point(26, 169);
			label3.Name = "label3";
			label3.Size = new Size(85, 19);
			label3.TabIndex = 7;
			label3.Text = "Program log";
			// 
			// numericSizeOrParts
			// 
			numericSizeOrParts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			numericSizeOrParts.Location = new Point(420, 12);
			numericSizeOrParts.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
			numericSizeOrParts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericSizeOrParts.Name = "numericSizeOrParts";
			numericSizeOrParts.Size = new Size(130, 26);
			numericSizeOrParts.TabIndex = 1;
			numericSizeOrParts.TextAlign = HorizontalAlignment.Right;
			numericSizeOrParts.ThousandsSeparator = true;
			numericSizeOrParts.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// labelSizeorParts
			// 
			labelSizeorParts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			labelSizeorParts.AutoSize = true;
			labelSizeorParts.Location = new Point(301, 15);
			labelSizeorParts.Name = "labelSizeorParts";
			labelSizeorParts.Size = new Size(96, 19);
			labelSizeorParts.TabIndex = 9;
			labelSizeorParts.Text = "Target file size:";
			// 
			// fileSufixComboBox
			// 
			fileSufixComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			fileSufixComboBox.FormattingEnabled = true;
			fileSufixComboBox.Location = new Point(556, 12);
			fileSufixComboBox.Name = "fileSufixComboBox";
			fileSufixComboBox.Size = new Size(96, 27);
			fileSufixComboBox.TabIndex = 2;
			// 
			// splitBtn
			// 
			splitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			splitBtn.Enabled = false;
			splitBtn.Location = new Point(512, 128);
			splitBtn.Name = "splitBtn";
			splitBtn.Size = new Size(140, 26);
			splitBtn.TabIndex = 3;
			splitBtn.Text = "Split";
			splitBtn.UseVisualStyleBackColor = true;
			splitBtn.Click += splitBtn_Click;
			// 
			// checkBox1
			// 
			checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			checkBox1.AutoSize = true;
			checkBox1.CheckAlign = ContentAlignment.MiddleRight;
			checkBox1.Location = new Point(471, 45);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(181, 23);
			checkBox1.TabIndex = 3;
			checkBox1.Text = "Parts instead of fixed size";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(664, 466);
			Controls.Add(checkBox1);
			Controls.Add(splitBtn);
			Controls.Add(fileSufixComboBox);
			Controls.Add(labelSizeorParts);
			Controls.Add(numericSizeOrParts);
			Controls.Add(label3);
			Controls.Add(LogTextBox);
			Controls.Add(filePathTextBox);
			Controls.Add(label1);
			Controls.Add(openFilebtn);
			MinimumSize = new Size(680, 490);
			Name = "MainForm";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)numericSizeOrParts).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button openFilebtn;
		private Label label1;
		private TextBox filePathTextBox;
		private TextBox LogTextBox;
		private Label label3;
		private NumericUpDown numericSizeOrParts;
		private Label labelSizeorParts;
		private ComboBox fileSufixComboBox;
		private OpenFileDialog oFD;
		private Button splitBtn;
		private CheckBox checkBox1;
	}
}
