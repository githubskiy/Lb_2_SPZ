﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_Lab7
{
	public partial class AddStudentForm : Form
	{
		public string StudentName { get; set; }

		public AddStudentForm()
		{
			InitializeComponent();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			StudentName = textBoxName.Text;
			DialogResult = DialogResult.OK;
			Hide();
		}
	}
}
