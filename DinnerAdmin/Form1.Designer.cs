
namespace DinnerAdmin
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label countLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dinnerDataSet = new DinnerAdmin.DinnerDataSet();
			this.bsDishes = new System.Windows.Forms.BindingSource(this.components);
			this.dishesTableAdapter = new DinnerAdmin.DinnerDataSetTableAdapters.DishesTableAdapter();
			this.tableAdapterManager = new DinnerAdmin.DinnerDataSetTableAdapters.TableAdapterManager();
			this.dishesDataGridView = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			countLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dinnerDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDishes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dinnerDataSet
			// 
			this.dinnerDataSet.DataSetName = "DinnerDataSet";
			this.dinnerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsDishes
			// 
			this.bsDishes.DataMember = "Dishes";
			this.bsDishes.DataSource = this.dinnerDataSet;
			// 
			// dishesTableAdapter
			// 
			this.dishesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DishesTableAdapter = this.dishesTableAdapter;
			this.tableAdapterManager.OrderTableAdapter = null;
			this.tableAdapterManager.PeopleTableAdapter = null;
			this.tableAdapterManager.TypeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DinnerAdmin.DinnerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// dishesDataGridView
			// 
			this.dishesDataGridView.AllowUserToAddRows = false;
			this.dishesDataGridView.AllowUserToDeleteRows = false;
			this.dishesDataGridView.AutoGenerateColumns = false;
			this.dishesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dishesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dishesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
			this.dishesDataGridView.DataSource = this.bsDishes;
			this.dishesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dishesDataGridView.Location = new System.Drawing.Point(0, 0);
			this.dishesDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dishesDataGridView.Name = "dishesDataGridView";
			this.dishesDataGridView.RowHeadersWidth = 51;
			this.dishesDataGridView.RowTemplate.Height = 24;
			this.dishesDataGridView.Size = new System.Drawing.Size(982, 653);
			this.dishesDataGridView.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 587);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(982, 66);
			this.panel2.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(482, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(500, 66);
			this.button1.TabIndex = 0;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(482, 66);
			this.button2.TabIndex = 1;
			this.button2.Text = "Задать 0-е кол-во всем позициям";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 157;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "consist";
			this.dataGridViewTextBoxColumn3.HeaderText = "Состав";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 124;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 105;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "count";
			this.dataGridViewTextBoxColumn6.HeaderText = "Кол-во";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 128;
			// 
			// countLabel
			// 
			countLabel.AutoSize = true;
			countLabel.Location = new System.Drawing.Point(568, 153);
			countLabel.Name = "countLabel";
			countLabel.Size = new System.Drawing.Size(0, 32);
			countLabel.TabIndex = 31;
			// 
			// countTextBox
			// 
			this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDishes, "count", true));
			this.countTextBox.Location = new System.Drawing.Point(662, 150);
			this.countTextBox.Name = "countTextBox";
			this.countTextBox.Size = new System.Drawing.Size(100, 39);
			this.countTextBox.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(982, 39);
			this.panel1.TabIndex = 33;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(982, 39);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 653);
			this.Controls.Add(this.panel1);
			this.Controls.Add(countLabel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dishesDataGridView);
			this.Controls.Add(this.countTextBox);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Терминал";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dinnerDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDishes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DinnerDataSet dinnerDataSet;
		private System.Windows.Forms.BindingSource bsDishes;
		private DinnerDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
		private DinnerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dishesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox countTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

