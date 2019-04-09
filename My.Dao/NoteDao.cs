using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Dao
{
	public class NoteDao
	{
		private List<Note> _noteList;

		public NoteDao()
		{
			//тестовые заметки
			var note = new Note(1, "note1", DateTime.Now, "asdfasdfasdf1");
			var note1 = new Note(2, "note2", DateTime.Now, "asdfasdfasdf2");
			var note2 = new Note(3, "note3", new DateTime(2010, 01, 01), "asdfasdfasdf3");
			_noteList = new List<Note> { note, note1, note2 };
		}

		/// <summary>
		/// получить все заметки
		/// </summary>
		/// <returns></returns>
		public List<Note> GetAllNotes()
		{
			return _noteList;
		}

		/// <summary>
		/// удалить заметку
		/// </summary>
		/// <param name="noteId"></param>
		public void DeleteNote(int noteId)
		{
			_noteList = _noteList.Where(x => x.Id != noteId).ToList();
		}

		public void UpdateNote(int id, string name, DateTime deadLine, string text)
		{
			var findedNote = _noteList.FirstOrDefault(x => x.Id == id);

			findedNote.Name = name;
			findedNote.DeadLine = deadLine;
			findedNote.Text = text;
		}

	}
}
