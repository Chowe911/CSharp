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

namespace SQL
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void InsertExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“pubsDataSet.info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.pubsDataSet.info);

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string select_str = "insert into info values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";


            //SqlCommand cmd = SQL.Use_SQL.execute(select_str);
            
            if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0 && textBox3.Text.Trim().Length > 0)
            {
                SQL.Use_SQL.execute(select_str);
            }
            
            this.infoTableAdapter.Fill(this.pubsDataSet.info);
        }
    }
}
