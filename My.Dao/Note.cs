using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Dao
{
	public class Note
	{
		public Note(int id, string name,  DateTime deadLine, string text)
		{
			Id = id;
			Text = text;
			DeadLine = deadLine;
			Name = name;
		}

		public int Id { get; set; }
		public string Text { get; set; }
		public DateTime DeadLine { get; set; }
		public string Name { get; set; }
	}
}
