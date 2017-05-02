using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace xml
{
    public partial class Form1 : Form
    {
        private XmlDocument xml;
        private List<string> id;
        private List<string> name;
        private List<string> tel;
        private List<string> mail;
        private int count;
        private XmlNodeList list;
        private XmlNodeList info;
        private XmlNode student;
        private string path;
        public Form1()
        {
            InitializeComponent();
            id = new List<string>();
            name = new List<string>();
            tel = new List<string>();
            mail = new List<string>();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath;
            file.Filter = "所有XML文件|*.XML";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if(file.ShowDialog()==DialogResult.OK)
            {
                count = 0;
                path = file.FileName.ToString();
                //new xmlprocess(path);
                xml = new XmlDocument();
                xml.Load(path);
                student = xml.SelectSingleNode("person");
                info = student.ChildNodes;
                //textBox1.Text += student.ChildNodes.Item(0).InnerText.ToString();
                
                //textBox2.Text = xml.InnerText;
                
                foreach(XmlNode item in info)
                {
                    XmlElement element = (XmlElement)item;
                    //id.Add(element.GetAttribute("id_no").ToString());
                    list = element.ChildNodes;
                    //test = list.Item(0).InnerText;
                    id.Add(list.Item(0).InnerText);
                    name.Add(list.Item(1).InnerText);
                    tel.Add(list.Item(2).InnerText);
                    mail.Add(list.Item(3).InnerText);
                }
                textBox1.Text = id.ElementAt(count);
                textBox2.Text = name.ElementAt(count);
                textBox3.Text = tel.ElementAt(count);
                textBox4.Text = mail.ElementAt(count);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (null == xml)
            {
                MessageBox.Show("No opened file.", "Warning");
            }
            else if(id.Count>count)
            {
                ++count;
                textBox1.Text = id.ElementAt(count);
                textBox2.Text = name.ElementAt(count);
                textBox3.Text = tel.ElementAt(count);
                textBox4.Text = mail.ElementAt(count);
            }
            else
            {
                MessageBox.Show("Last infomaintion.", "Warning");
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test","warning");
            if (null == xml)
            {
                MessageBox.Show("No opened file.", "Warning");
            }
            else if (count>0)
            {
                --count;
                textBox1.Text = id.ElementAt(count);
                textBox2.Text = name.ElementAt(count);
                textBox3.Text = tel.ElementAt(count);
                textBox4.Text = mail.ElementAt(count);
            }
            else
            {
                MessageBox.Show("First infomaintion.", "Warning");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (null == xml)
            {
                MessageBox.Show("No opened file.","Warning");
            }

            else if (MessageBox.Show("Are you sure to modify?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int i = 0;
                foreach (XmlNode item in info)
                {
                    if (i == count)
                    {
                        XmlElement element = (XmlElement)item;

                        list = element.ChildNodes;
                        list.Item(0).InnerText = textBox1.Text;
                        list.Item(1).InnerText = textBox2.Text;
                        list.Item(2).InnerText = textBox3.Text;
                        list.Item(3).InnerText = textBox4.Text;
                        xml.Save(path);
                        MessageBox.Show("Succeeded.", "Warning");
                        break;
                    }
                    i++;
            }
                
                
            }
            else
            {
                MessageBox.Show("Canceled.", "Warning");
            }
        }
    }
}
