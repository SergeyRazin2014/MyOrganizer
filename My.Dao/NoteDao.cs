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
			_noteList = GetAllNotes();
		}

		/// <summary>
		/// получить все заметки
		/// </summary>
		public List<Note> GetAllNotes()
		{
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
