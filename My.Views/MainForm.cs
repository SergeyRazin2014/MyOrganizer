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
		//List<Note> _noteList;
		//BindingSource _noteBindingSource;

		public MainForm()
		{
			InitializeComponent();

			_noteDao = new NoteDao();
			var noteList = _noteDao.GetAllNotes();
			Init(noteList);
		}

		private void Init(List<Note> _noteList)
		{
			_noteList = _noteDao.GetAllNotes();

			ClearBindingSources();

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

		/// <summary>
		/// открыть форму добавления заметки
		/// </summary>
		private void btnAddNote_Click(object sender, EventArgs e)
		{
			var addForm = new AddNoteForm(_noteDao);
			addForm.ShowDialog(); //открываем форму добавления и ждем ее закрытия
			this.WindowState = FormWindowState.Normal;

			RefreshForm();

		}

		private void ClearForm()
		{
			richTextBoxNote.Text = "";
			tbNoteName.Text = "";
			dateTimePickerDeadLine.Value = DateTime.Now;
		}

		private void RefreshForm()
		{
			var noteList = _noteDao.GetAllNotes();

			Init(noteList);

			if (!noteList.Any())
				ClearForm();
		}

		private void btnDeleteNote_Click(object sender, EventArgs e)
		{
			var selectedNote = (Note)listBoxNotes.SelectedItem;

			if (selectedNote == null)
				return;

			_noteDao.DeleteNote(selectedNote.Id);
			RefreshForm();
		}

		private void btnSaveNote_click(object sender, EventArgs e)
		{
			//получить текущу заметку
			var selectedNote = (Note)listBoxNotes.SelectedItem;

			var allNotes = _noteDao.GetAllNotes();
			var findedNote = allNotes.FirstOrDefault(x => x.Id == selectedNote.Id);

			if (findedNote == null)
				throw new Exception("Заметка не найдена");


			_noteDao.UpdateNote(findedNote.Id, selectedNote.Name, selectedNote.DeadLine, selectedNote.Text);
		}
	}
}
