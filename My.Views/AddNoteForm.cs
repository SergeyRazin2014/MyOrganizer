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
	public partial class AddNoteForm : Form
	{
		private NoteDao _noteDao;

		public AddNoteForm(NoteDao noteDao)
		{
			InitializeComponent();

			_noteDao = noteDao;
		}

		private void Cancel_click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnAddNoteOk_Click(object sender, EventArgs e)
		{
			var noteName = this.tbNoteName.Text;
			var noteDeadLine = this.dateTimePickerDeadLine.Value;
			var noteText = this.richTextBoxNoteText.Text;
			var id = CalculateNewId();

			if (string.IsNullOrWhiteSpace(noteName))
			{
				MessageBox.Show("Необходимо заполнить Имя заметки");
				return;
			}

			var note = new Note(id, noteName, noteDeadLine, noteText);

			_noteDao.AddNote(note);
			this.Close();
		}

		private int CalculateNewId()
		{
			var allNotes = _noteDao.GetAllNotes();

			if (allNotes == null || !allNotes.Any())
				return 1;

			var res = allNotes.Select(x => x.Id).Max() + 1;
			return res;
		}
	}
}
