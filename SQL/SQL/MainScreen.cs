using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void sqlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sqlInsert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            
            insert.Show();
            //this.Visible = false;
        }

        private void sqlDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void sqlUpdate_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void sqlSelect_Click(object sender, EventArgs e)
        {
            Select select = new Select();
            select.Show();
        }
    }
}
