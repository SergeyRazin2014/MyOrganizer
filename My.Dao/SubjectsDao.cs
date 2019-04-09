using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace My.Dao
{
	public class SubjectsDao
	{
		private JavaScriptSerializer _serializer = new JavaScriptSerializer();

		private List<Subject> _subjectList;


		public SubjectsDao()
		{
			_subjectList = GetAllSubjects();
		}

		public List<Subject> GetAllSubjects()
		{
			var path = GetPathToJson();

			if (!File.Exists(path))
				File.WriteAllText(path, "[]");

			var jsonStr = File.ReadAllText(path);

			var res = _serializer.Deserialize<List<Subject>>(jsonStr);

			return res;
		}

		/// <summary>
		/// сериализовать в файл
		/// </summary>
		public void Save()
		{
			var res = _serializer.Serialize(_subjectList);

			var filePath = GetPathToJson();

			File.WriteAllText(filePath, res);
		}

		private string GetPathToJson()
		{
			var directoryPath = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + @"\УНИВЕР\";

			if (!Directory.Exists(directoryPath))
				Directory.CreateDirectory(directoryPath);

			var filePath = Path.Combine(directoryPath, "Subjects.json");

			return filePath;
		}

		/// <summary>
		/// добавить субъект с адресом
		/// </summary>
		/// <param name="subject"></param>
		public void AddSubject(Subject subject)
		{
			subject.Id = CalculateId();

			_subjectList.Add(subject);
			Save();
		}

		public int CalculateId()
		{
			if (!_subjectList.Any())
				return 1;

			return _subjectList.Select(x => x.Id).Max() + 1;
		}

		public void DeleteSubject(int id)
		{
			_subjectList = _subjectList.Where(x => x.Id != id).ToList();
			Save();
		}

		public void UpdateSubject(int id, string name, bool isJurydic, string settlement, string street, string house)
		{
			var findedSubject = _subjectList.FirstOrDefault(x => x.Id == id);

			findedSubject.Name = name;
			findedSubject.IsJuridic = isJurydic;
			findedSubject.Settlement = settlement;
			findedSubject.Street = street;
			findedSubject.House = house;
			Save();
		}




	}
}
