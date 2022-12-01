using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerAdmin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dishesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bsDishes.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dinnerDataSet);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dinnerDataSet.Dishes' table. You can move, or remove it, as needed.
			this.dishesTableAdapter.Fill(this.dinnerDataSet.Dishes);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= bsDishes.Count; i++)
			{
				bsDishes.Position = i;
				countTextBox.Text = "0";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bsDishes.EndEdit();
			this.dishesTableAdapter.Update(this.dinnerDataSet.Dishes);

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bsDishes.Filter = "name like '%" + textBox1.Text.ToUpper() + "%'";
			
		}
	}
}
