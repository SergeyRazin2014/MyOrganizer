namespace My.Views
{
	partial class SubjectForm
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDeleteSubject = new System.Windows.Forms.Button();
			this.btnAddSubject = new System.Windows.Forms.Button();
			this.checkBoxIsJuridic = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbHous = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbStreat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSettlement = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSubjectName = new System.Windows.Forms.TextBox();
			this.listBoxSubjects = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(204, 153);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 32;
			this.btnUpdate.Text = "Сохранить";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDeleteSubject
			// 
			this.btnDeleteSubject.Location = new System.Drawing.Point(93, 269);
			this.btnDeleteSubject.Name = "btnDeleteSubject";
			this.btnDeleteSubject.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteSubject.TabIndex = 31;
			this.btnDeleteSubject.Text = "Удалить";
			this.btnDeleteSubject.UseVisualStyleBackColor = true;
			this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
			// 
			// btnAddSubject
			// 
			this.btnAddSubject.Location = new System.Drawing.Point(12, 269);
			this.btnAddSubject.Name = "btnAddSubject";
			this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
			this.btnAddSubject.TabIndex = 30;
			this.btnAddSubject.Text = "Добавить";
			this.btnAddSubject.UseVisualStyleBackColor = true;
			this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
			// 
			// checkBoxIsJuridic
			// 
			this.checkBoxIsJuridic.AutoSize = true;
			this.checkBoxIsJuridic.Location = new System.Drawing.Point(206, 130);
			this.checkBoxIsJuridic.Name = "checkBoxIsJuridic";
			this.checkBoxIsJuridic.Size = new System.Drawing.Size(127, 17);
			this.checkBoxIsJuridic.TabIndex = 29;
			this.checkBoxIsJuridic.Text = "Является юр лицом";
			this.checkBoxIsJuridic.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(203, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Дом";
			// 
			// tbHous
			// 
			this.tbHous.Location = new System.Drawing.Point(284, 90);
			this.tbHous.Name = "tbHous";
			this.tbHous.Size = new System.Drawing.Size(379, 20);
			this.tbHous.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(203, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Улица";
			// 
			// tbStreat
			// 
			this.tbStreat.Location = new System.Drawing.Point(284, 64);
			this.tbStreat.Name = "tbStreat";
			this.tbStreat.Size = new System.Drawing.Size(379, 20);
			this.tbStreat.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(203, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Нас. пункт";
			// 
			// tbSettlement
			// 
			this.tbSettlement.Location = new System.Drawing.Point(284, 38);
			this.tbSettlement.Name = "tbSettlement";
			this.tbSettlement.Size = new System.Drawing.Size(379, 20);
			this.tbSettlement.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Субъект";
			// 
			// tbSubjectName
			// 
			this.tbSubjectName.Location = new System.Drawing.Point(284, 12);
			this.tbSubjectName.Name = "tbSubjectName";
			this.tbSubjectName.Size = new System.Drawing.Size(379, 20);
			this.tbSubjectName.TabIndex = 21;
			// 
			// listBoxSubjects
			// 
			this.listBoxSubjects.FormattingEnabled = true;
			this.listBoxSubjects.Location = new System.Drawing.Point(12, 12);
			this.listBoxSubjects.Name = "listBoxSubjects";
			this.listBoxSubjects.Size = new System.Drawing.Size(185, 251);
			this.listBoxSubjects.TabIndex = 20;
			// 
			// SubjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDeleteSubject);
			this.Controls.Add(this.btnAddSubject);
			this.Controls.Add(this.checkBoxIsJuridic);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbHous);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbStreat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSettlement);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSubjectName);
			this.Controls.Add(this.listBoxSubjects);
			this.Name = "SubjectForm";
			this.Text = "Справочник адресов";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDeleteSubject;
		private System.Windows.Forms.Button btnAddSubject;
		private System.Windows.Forms.CheckBox checkBoxIsJuridic;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbHous;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbStreat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbSettlement;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSubjectName;
		private System.Windows.Forms.ListBox listBoxSubjects;
	}
}