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
	public partial class AddSubjectForm : Form
	{
		private readonly SubjectsDao _subjectDao;

		public AddSubjectForm(SubjectsDao subjectDao)
		{
			InitializeComponent();
			_subjectDao = subjectDao;
		}

		private void AddSubjectFormOk_click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(tbSubjectName.Text))
			{
				MessageBox.Show("Необходимо заполнить имя субъекта");
				return;
			}

			var name = this.tbSubjectName.Text;
			var isJuridyc = this.checkBoxIsJuridic.Checked;
			var settlement = this.tbSettlement.Text;
			var street = this.tbStreat.Text;
			var house = this.tbHous.Text;

			var subject = new Subject();
			subject.Name = name;
			subject.IsJuridic = isJuridyc;
			subject.Settlement = settlement;
			subject.Street = street;
			subject.House = house;

			_subjectDao.AddSubject(subject);
			this.Close();
		}

		private void btnAddSubjectCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
