using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Abdylbaev", "Ruslan", 12);
            dataGridView1.Rows.Add("Ruslanova", "Zarina", 12);
            dataGridView1.Rows.Add("Igorov", "Peter", 12);
            dataGridView1.Rows.Add("Ivanov", "Sergey", 12);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            int viNomRow = 0;
            dataGridView1.Rows[viNomRow].DefaultCellStyle.BackColor = Color.White; 
            for (int i = 0; i < dataGridView1.RowCount; i++)

                if (dataGridView1[1, i].FormattedValue.ToString().Trim().ToLower().
                    Contains(toolStripTextBox1.Text.Trim().ToLower())) 
                {

                    dataGridView1.CurrentCell = dataGridView1[1, i];
                    int enteredviNomRow = i;
                    dataGridView1.Rows[viNomRow].DefaultCellStyle.BackColor = Color.Aqua; 
                    return;
                }

        }

        DataTable table = new DataTable();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataColumn c = table.Columns.Add("Ключ", typeof(String));
            c.AutoIncrement = true;
            c.AutoIncrementSeed = 10;
            c.AutoIncrementStep = 5;
            table.Columns.Add("Товар", typeof(String));
            table.Columns.Add("Количество", typeof(Int32));
            table.Columns.Add("Цена", typeof(Int32));
            table.Columns.Add("Сумма", typeof(String), "Количество * Цена");
            table.Columns.Add("Налоги", typeof(String), "Количество * Цена * 0.18");

            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            bindingSource.DataSource = table;
            dataGridView2.DataSource = bindingSource;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row[1] = "Молоко"; row["Количество"] = 10;
            row["Цена"] = 16;
            table.Rows.Add(row);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0) return;
            table.Rows[0].Delete();
        }
    }
}
