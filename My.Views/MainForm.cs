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
	public partial class MainForm : Form
	{
		NoteDao _noteDao;
		List<Note> _noteList;
		//BindingSource _noteBindingSource;

		public MainForm()
		{
			InitializeComponent();

			_noteDao = new NoteDao();
			_noteList = _noteDao.GetAllNotes();

			Init(_noteList);
		}

		private void Init(List<Note> _noteList)
		{
			//связь с заметками
			var _noteBindingSource = new BindingSource();
			_noteBindingSource.DataSource = _noteList;

			//настраиваем список заметок
			listBoxNotes.DataSource = _noteBindingSource;
			listBoxNotes.DisplayMember = "Name";

			//указываем связи контролов с данными
			richTextBoxNote.DataBindings.Add("Text", _noteBindingSource, "Text");
			tbNoteName.DataBindings.Add("Text", _noteBindingSource, "Name");
			dateTimePickerDeadLine.DataBindings.Add("Value", _noteBindingSource, "DeadLine");
		}

		private void ClearBindingSources()
		{
			richTextBoxNote.DataBindings.Clear();
			tbNoteName.DataBindings.Clear();
			dateTimePickerDeadLine.DataBindings.Clear();
		}

		private void btnAddNote_Click(object sender, EventArgs e)
		{
			MessageBox.Show("ТУТ БУДЕТ ДОБАВЛЕНИЕ НОВОЙ ЗАМЕТКИ");
		}

		private void ClearForm()
		{
			richTextBoxNote.Text = "";
			tbNoteName.Text = "";
			dateTimePickerDeadLine.Value = DateTime.Now;
		}

		private void btnDeleteNote_Click(object sender, EventArgs e)
		{
			var selectedNode = (Note)listBoxNotes.SelectedItem;

			_noteDao.DeleteNote(selectedNode.Id);
			_noteList = _noteDao.GetAllNotes();
			ClearBindingSources();
			Init(_noteList);

			if (!_noteList.Any())
				ClearForm();
		}
	}
}
