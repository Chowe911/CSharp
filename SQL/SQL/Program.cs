using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL
{
    static class Use_SQL
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
        
        public static void execute(string select_str)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=True");
            conn.Open();
            
            SqlCommand cmd = new SqlCommand(select_str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
           // return cmd;
        }
        
    }
}
