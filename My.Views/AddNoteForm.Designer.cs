namespace My.Views
{
	partial class AddNoteForm
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
			this.btnAddNoteOk = new System.Windows.Forms.Button();
			this.dateTimePickerDeadLine = new System.Windows.Forms.DateTimePicker();
			this.tbNoteName = new System.Windows.Forms.TextBox();
			this.richTextBoxNoteText = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddNoteCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddNoteOk
			// 
			this.btnAddNoteOk.Location = new System.Drawing.Point(12, 239);
			this.btnAddNoteOk.Name = "btnAddNoteOk";
			this.btnAddNoteOk.Size = new System.Drawing.Size(75, 23);
			this.btnAddNoteOk.TabIndex = 0;
			this.btnAddNoteOk.Text = "Ок";
			this.btnAddNoteOk.UseVisualStyleBackColor = true;
			this.btnAddNoteOk.Click += new System.EventHandler(this.BtnAddNoteOk_Click);
			// 
			// dateTimePickerDeadLine
			// 
			this.dateTimePickerDeadLine.Location = new System.Drawing.Point(110, 39);
			this.dateTimePickerDeadLine.Name = "dateTimePickerDeadLine";
			this.dateTimePickerDeadLine.Size = new System.Drawing.Size(397, 20);
			this.dateTimePickerDeadLine.TabIndex = 1;
			// 
			// tbNoteName
			// 
			this.tbNoteName.Location = new System.Drawing.Point(110, 13);
			this.tbNoteName.Name = "tbNoteName";
			this.tbNoteName.Size = new System.Drawing.Size(397, 20);
			this.tbNoteName.TabIndex = 2;
			// 
			// richTextBoxNoteText
			// 
			this.richTextBoxNoteText.Location = new System.Drawing.Point(6, 19);
			this.richTextBoxNoteText.Name = "richTextBoxNoteText";
			this.richTextBoxNoteText.Size = new System.Drawing.Size(485, 124);
			this.richTextBoxNoteText.TabIndex = 3;
			this.richTextBoxNoteText.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Имя заметки";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Выполнить до";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBoxNoteText);
			this.groupBox1.Location = new System.Drawing.Point(16, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(501, 168);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Текст заметки";
			// 
			// btnAddNoteCancel
			// 
			this.btnAddNoteCancel.Location = new System.Drawing.Point(93, 239);
			this.btnAddNoteCancel.Name = "btnAddNoteCancel";
			this.btnAddNoteCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAddNoteCancel.TabIndex = 7;
			this.btnAddNoteCancel.Text = "Отмена";
			this.btnAddNoteCancel.UseVisualStyleBackColor = true;
			this.btnAddNoteCancel.Click += new System.EventHandler(this.Cancel_click);
			// 
			// AddNoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 278);
			this.Controls.Add(this.btnAddNoteCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNoteName);
			this.Controls.Add(this.dateTimePickerDeadLine);
			this.Controls.Add(this.btnAddNoteOk);
			this.Name = "AddNoteForm";
			this.Text = "Создать заметку";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddNoteOk;
		private System.Windows.Forms.DateTimePicker dateTimePickerDeadLine;
		private System.Windows.Forms.TextBox tbNoteName;
		private System.Windows.Forms.RichTextBox richTextBoxNoteText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddNoteCancel;
	}
}