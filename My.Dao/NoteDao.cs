using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace My.Dao
{
	public class NoteDao
	{
		private List<Note> _noteList = new List<Note>();
		private JavaScriptSerializer _serializer = new JavaScriptSerializer();

		public NoteDao()
		{
			////тестовые заметки
			//var note = new Note(1, "note1", DateTime.Now, "asdfasdfasdf1");
			//var note1 = new Note(2, "note2", DateTime.Now, "asdfasdfasdf2");
			//var note2 = new Note(3, "note3", new DateTime(2010, 01, 01), "asdfasdfasdf3");
			//_noteList = new List<Note> { note, note1, note2 };

			_noteList = GetAllNotes();


		}

		/// <summary>
		/// получить все заметки
		/// </summary>
		public List<Note> GetAllNotes()
		{
			//return _noteList;

			var path = GetPathToJson();

			if (!File.Exists(path))
				File.WriteAllText(path, "[]");

			var jsonStr = File.ReadAllText(path);

			var res = _serializer.Deserialize<List<Note>>(jsonStr);

			return res;
		}

		/// <summary>
		/// удалить заметку
		/// </summary>
		public void DeleteNote(int noteId)
		{
			_noteList = _noteList.Where(x => x.Id != noteId).ToList();
			Save();
		}

		public void UpdateNote(int id, string name, DateTime deadLine, string text)
		{
			var findedNote = _noteList.FirstOrDefault(x => x.Id == id);

			findedNote.Name = name;
			findedNote.DeadLine = deadLine;
			findedNote.Text = text;
			Save();
		}

		/// <summary>
		/// сериализовать в файл
		/// </summary>
		public void Save()
		{
			var res = _serializer.Serialize(_noteList);

			var filePath = GetPathToJson();

			File.WriteAllText(filePath, res);
		}

		private string GetPathToJson()
		{
			var directoryPath = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + @"\УНИВЕР\";

			if (!Directory.Exists(directoryPath))
				Directory.CreateDirectory(directoryPath);

			var filePath = Path.Combine(directoryPath, "Notes.json");

			return filePath;
		}

		public void AddNote(Note note)
		{
			_noteList.Add(note);
			Save();
		}

	}
}
