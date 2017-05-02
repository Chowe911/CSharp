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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“pubsDataSet.info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.pubsDataSet.info);

        }

        private void InsertExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string select_str = "select * from info where id='" + textBox1.Text + "' or name='" + textBox2.Text + "' or tel='" + textBox3.Text + "'";
            if (textBox1.Text.Trim().Length==0&&textBox2.Text.Trim().Length==0&&textBox3.Text.Trim().Length==0) 
            {
                select_str = "select * from info";
            }
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(select_str, conn);
            cmd.ExecuteNonQuery();
            //SqlCommand cmd = SQL.Use_SQL.execute(select_str);
            //this.infoTableAdapter.Fill(this.pubsDataSet.info);
           SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
           // this.infoTableAdapter.Fill()
             
        }
    }
}
