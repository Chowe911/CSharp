using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ID3;
using ID3.ID3v2Frames;
using System.Data;
using System.Xml;

namespace music2
{
    public partial class index : System.Web.UI.Page
    {
        public string song="dgfkjhsgdfj;sgfdskjdf";
        //public static bool flag = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            init_id3_info();
            refresh();
        }

        public void init_id3_info()
        {
            //if(flag)
            {
                //flag = false;    
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml/id3.xml"));
            XmlNode root = doc.SelectSingleNode("id3");
            root.RemoveAll();
            string info_data = "";

            XmlElement xe2 = doc.CreateElement("title");
            xe2.SetAttribute("id", "标题：");
            xe2.SetAttribute("name", info_data);
            xe2.InnerText = info_data;
            root.AppendChild(xe2);

            XmlElement xe = doc.CreateElement("singer");
            xe.SetAttribute("id", "演唱：");
            xe.SetAttribute("name", info_data);
            xe.InnerText = info_data;
            root.AppendChild(xe);

            XmlElement xe3 = doc.CreateElement("album");
            xe3.SetAttribute("id", "专辑：");
            xe3.SetAttribute("name", info_data);
            xe3.InnerText = info_data;
            root.AppendChild(xe3);

            doc.Save(Server.MapPath("id3.xml"));

            refresh();
            
            }
        }

        public void refresh()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml/id3.xml"));
            XmlNodeList nodes = doc.SelectNodes("id3");
            DataList2.DataSource = nodes;
            DataList2.DataBind();
            //DataList2.DataBind();
        }

        public string fix_data(string s)
        {
            return s.Substring(0, s.Length - 1);
        }

        public void getID3()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml/id3.xml"));
            XmlNode root = doc.SelectSingleNode("id3");
            root.RemoveAll();
            string info_data = "";
            string path = Server.MapPath("play\\"+song+".mp3");
            ID3Info info = new ID3Info(path, true);
            bool b = info.ID3v2Info.HaveTag;
            if(b)
            {
                XmlElement xe2 = doc.CreateElement("title");
                xe2.SetAttribute("id", "标题");
                info_data = fix_data(info.ID3v2Info.GetTextFrame("TIT2"));
                xe2.SetAttribute("name", info_data);
                xe2.InnerText = info_data;
                root.AppendChild(xe2);

                XmlElement xe = doc.CreateElement("singer");
                xe.SetAttribute("id", "演唱");
                info_data = fix_data(info.ID3v2Info.GetTextFrame("TPE1"));
                xe.SetAttribute("name", info_data);
                xe.InnerText = info_data;
                root.AppendChild(xe);

                XmlElement xe3 = doc.CreateElement("album");
                xe3.SetAttribute("id", "专辑");
                info_data = fix_data(info.ID3v2Info.GetTextFrame("TALB"));
                xe3.SetAttribute("name", info_data);
                xe3.InnerText = info_data;
                root.AppendChild(xe3);

                doc.Save(Server.MapPath("xml/id3.xml")); 
            }
            
        }

        public void load_js()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "js", "load()", true);
        }

        protected void Label1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton sb = (LinkButton)sender;          
            song = sb.Text;     
            getID3();
            refresh();
            load_js();   
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
 
        }

    }
}