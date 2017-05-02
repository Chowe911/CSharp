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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
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
            string select_str = "update info set name='" + textBox2.Text + "' , tel='" + textBox3.Text + "' where id='" + textBox1.Text + "'";

            //UPDATE 表名称 SET 列名称 = 新值 WHERE 列名称 = 某值
            SQL.Use_SQL.execute(select_str);


            this.infoTableAdapter.Fill(this.pubsDataSet.info);
        }
    }
}
