using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivi
{
    public partial class Form2 : Form
    {

        public static DataGridView dg1;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int secilen = dg1.SelectedCells[0].RowIndex;
            string link = dg1.Rows[secilen].Cells[2].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
