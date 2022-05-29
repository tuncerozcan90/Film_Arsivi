using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivi
{
    public partial class Form1 : Form
    {
        DatabaseOperation operation;
        public Form1()
        {
            InitializeComponent();
            DatabaseOperation.dg1 = dataGridView1;

        }
        //Data Source=DESKTOP-PBUC8F9\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PBUC8F9\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            operation=new DatabaseOperation();
            operation.filmleriListele();
        }

   

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[2].Value.ToString();   
            webBrowser1.Navigate(link);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            operation.filmiKaydet(new Film { FilmName=txtName.Text, Category=txtCategory.Text,Link=txtLink.Text });
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            var selected = dataGridView1.Rows[rowindex].Cells[columnindex].Value;

            operation.deleteFromTable(selected);

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
           
            Form2 form = new Form2();
            Form2.dg1 = dataGridView1;
            form.ShowDialog();
            this.Hide();

        }
    }
}
