using My.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.Views
{
	public partial class SubjectForm : Form
	{
		private SubjectsDao _subjectDao;

		public SubjectForm()
		{
			InitializeComponent();

			_subjectDao = new SubjectsDao();

			Init();
		}

		private void Init()
		{
			var subjectList = _subjectDao.GetAllSubjects();

			ClearBindingSources();

			//связь 
			var _subjectsBindingSource = new BindingSource();
			_subjectsBindingSource.DataSource = subjectList;

			//настраиваем список 
			listBoxSubjects.DataSource = _subjectsBindingSource;
			listBoxSubjects.DisplayMember = "Name";

			//указываем связи контролов с данными
			tbSubjectName.DataBindings.Add("Text", _subjectsBindingSource, "Name");
			tbSettlement.DataBindings.Add("Text", _subjectsBindingSource, "Settlement");
			tbStreat.DataBindings.Add("Text", _subjectsBindingSource, "Street");
			tbHous.DataBindings.Add("Text", _subjectsBindingSource, "House");
			checkBoxIsJuridic.DataBindings.Add("Checked", _subjectsBindingSource, "IsJuridic");

			if (!subjectList.Any())
				DisableForm();
			else
				EnableForm();

		}

		private void ClearBindingSources()
		{
			tbSubjectName.DataBindings.Clear();
			tbSettlement.DataBindings.Clear();
			tbStreat.DataBindings.Clear();
			tbHous.DataBindings.Clear();
			checkBoxIsJuridic.DataBindings.Clear();
		}

		private void btnAddSubject_Click(object sender, EventArgs e)
		{
			var addForm = new AddSubjectForm(_subjectDao);
			addForm.ShowDialog(); //открываем форму добавления и ждем ее закрытия
			this.WindowState = FormWindowState.Normal;

			RefreshForm();
		}


		private void RefreshForm()
		{
			var noteList = _subjectDao.GetAllSubjects();

			Init();

			if (!noteList.Any())
				ClearForm();
		}

		private void ClearForm()
		{
			tbSubjectName.Text = "";
			tbSettlement.Text = "";
			tbStreat.Text = "";
			tbHous.Text = "";
			checkBoxIsJuridic.Checked = false;
		}

		private void btnDeleteSubject_Click(object sender, EventArgs e)
		{
			var selectedSubject = (Subject)listBoxSubjects.SelectedItem;

			if (selectedSubject == null)
			{
				DisableForm();
				return;
			}

			_subjectDao.DeleteSubject(selectedSubject.Id);
			RefreshForm();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//получить текущу заметку
			var selectedNote = (Subject)listBoxSubjects.SelectedItem;

			var allNotes = _subjectDao.GetAllSubjects();
			var findedNote = allNotes.FirstOrDefault(x => x.Id == selectedNote.Id);

			if (findedNote == null)
				throw new Exception("Субъект не найден");


			_subjectDao.UpdateSubject(findedNote.Id, selectedNote.Name, selectedNote.IsJuridic, selectedNote.Settlement, selectedNote.Street, selectedNote.House);

		}

		private void DisableForm()
		{
			tbSubjectName.Enabled = false;
			tbSettlement.Enabled = false;
			tbStreat.Enabled = false;
			tbHous.Enabled = false;
			checkBoxIsJuridic.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void EnableForm()
		{
			tbSubjectName.Enabled = true;
			tbSettlement.Enabled = true;
			tbStreat.Enabled = true;
			tbHous.Enabled = true;
			checkBoxIsJuridic.Enabled = true;
			btnUpdate.Enabled = true;
		}
	}
}
