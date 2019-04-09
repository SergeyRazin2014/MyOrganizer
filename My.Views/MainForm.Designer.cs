namespace My.Views
{
	partial class MainForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnSaveNote = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNoteName = new System.Windows.Forms.TextBox();
			this.btnDeleteNote = new System.Windows.Forms.Button();
			this.dateTimePickerDeadLine = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
			this.listBoxNotes = new System.Windows.Forms.ListBox();
			this.btnAddNote = new System.Windows.Forms.Button();
			this.btnOpenSubjects = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(671, 367);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnSaveNote);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.tbNoteName);
			this.tabPage1.Controls.Add(this.btnDeleteNote);
			this.tabPage1.Controls.Add(this.dateTimePickerDeadLine);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.listBoxNotes);
			this.tabPage1.Controls.Add(this.btnAddNote);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(663, 341);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Заметки";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnSaveNote
			// 
			this.btnSaveNote.Location = new System.Drawing.Point(202, 265);
			this.btnSaveNote.Name = "btnSaveNote";
			this.btnSaveNote.Size = new System.Drawing.Size(75, 23);
			this.btnSaveNote.TabIndex = 8;
			this.btnSaveNote.Text = "Сохранить";
			this.btnSaveNote.UseVisualStyleBackColor = true;
			this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(199, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Имя заметки";
			// 
			// tbNoteName
			// 
			this.tbNoteName.Location = new System.Drawing.Point(282, 47);
			this.tbNoteName.Name = "tbNoteName";
			this.tbNoteName.Size = new System.Drawing.Size(379, 20);
			this.tbNoteName.TabIndex = 6;
			// 
			// btnDeleteNote
			// 
			this.btnDeleteNote.Location = new System.Drawing.Point(87, 312);
			this.btnDeleteNote.Name = "btnDeleteNote";
			this.btnDeleteNote.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteNote.TabIndex = 5;
			this.btnDeleteNote.Text = "Удалить";
			this.btnDeleteNote.UseVisualStyleBackColor = true;
			this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
			// 
			// dateTimePickerDeadLine
			// 
			this.dateTimePickerDeadLine.Location = new System.Drawing.Point(282, 81);
			this.dateTimePickerDeadLine.Name = "dateTimePickerDeadLine";
			this.dateTimePickerDeadLine.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerDeadLine.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выполнить до";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBoxNote);
			this.groupBox1.Location = new System.Drawing.Point(195, 110);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 149);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Текст заметки";
			// 
			// richTextBoxNote
			// 
			this.richTextBoxNote.Location = new System.Drawing.Point(7, 20);
			this.richTextBoxNote.Name = "richTextBoxNote";
			this.richTextBoxNote.Size = new System.Drawing.Size(459, 123);
			this.richTextBoxNote.TabIndex = 0;
			this.richTextBoxNote.Text = "";
			// 
			// listBoxNotes
			// 
			this.listBoxNotes.FormattingEnabled = true;
			this.listBoxNotes.Location = new System.Drawing.Point(7, 47);
			this.listBoxNotes.Name = "listBoxNotes";
			this.listBoxNotes.Size = new System.Drawing.Size(185, 251);
			this.listBoxNotes.TabIndex = 1;
			// 
			// btnAddNote
			// 
			this.btnAddNote.Location = new System.Drawing.Point(6, 312);
			this.btnAddNote.Name = "btnAddNote";
			this.btnAddNote.Size = new System.Drawing.Size(75, 23);
			this.btnAddNote.TabIndex = 0;
			this.btnAddNote.Text = "Добавить";
			this.btnAddNote.UseVisualStyleBackColor = true;
			this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
			// 
			// btnOpenSubjects
			// 
			this.btnOpenSubjects.Location = new System.Drawing.Point(526, 415);
			this.btnOpenSubjects.Name = "btnOpenSubjects";
			this.btnOpenSubjects.Size = new System.Drawing.Size(147, 23);
			this.btnOpenSubjects.TabIndex = 20;
			this.btnOpenSubjects.Text = "Справочник адресов";
			this.btnOpenSubjects.UseVisualStyleBackColor = true;
			this.btnOpenSubjects.Click += new System.EventHandler(this.btnOpenSubjects_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 450);
			this.Controls.Add(this.btnOpenSubjects);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Органайзер";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnAddNote;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePickerDeadLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxNotes;
		private System.Windows.Forms.RichTextBox richTextBoxNote;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNoteName;
		private System.Windows.Forms.Button btnDeleteNote;
		private System.Windows.Forms.Button btnSaveNote;
		private System.Windows.Forms.Button btnOpenSubjects;
	}
}

