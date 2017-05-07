<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="music2.index" %>
<%@ Import Namespace="System.Xml"%>  
<%@ Import namespace="System.Data" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>欢迎加入守望先锋</title>
    <link rel="stylesheet" href="style/css.css" />
    <script type="text/javascript" >
        function load() {
            document.getElementById("id3_info").innerHTML = "已选择的曲目";
            s = "<%=song%>";
            
            var a = document.getElementById("music");
            a.src = "play\\" + s + ".mp3";
            a.play();

        }
        function a()
        {
            
        }
    </script>
</head>
<body  onload="javascript:a();">
    <form id="form1" runat="server">
    <div class="container">
    
        <div class="upper" >
            <img src="images/ow.jpg" height="300px" width="1050px" />
        </div>
    
        <div class="side">
            <div class="play">
                
                <div class="button">
                    <audio id="music" src="" controls="controls" style="width:400px;background-color:pink;"></audio>
                </div>
            </div>
            <div class="element">
                <br />
                <h3 id="id3_info" style="text-align:center">未选择曲目</h3>
                <br />
                <div class="info">

                    

                    <asp:XmlDataSource ID="id3" runat="server" DataFile="~/id3.xml"></asp:XmlDataSource>

                    

                    <asp:DataList ID="DataList2" runat="server"  >
                        <ItemTemplate>

                            标题：<asp:Label ID="idLabel" runat="server" Text='<%# ((XmlNode)Container.DataItem)["title"].InnerText %>' /><br /><br />
                            演唱：<asp:Label ID="nameLabel" runat="server" Text='<%# ((XmlNode)Container.DataItem)["singer"].InnerText %>' /><br /><br />
                            专辑：<asp:Label ID="Label1" runat="server" Text='<%# ((XmlNode)Container.DataItem)["album"].InnerText %>' /><br /><br />
                            
                            <br />
                            <br />

                            </ItemTemplate>
                    </asp:DataList>

                    

                </div>
            </div>
        </div>

        <div class="main">
            <br /><br />
            <h1>Overwatch Collector's Edition Soundtrack</h1>
                <h3>守望先锋原声带专辑</h3>
            <div class="list">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="data">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("name") %>'   OnClick="LinkButton1_Click"></asp:LinkButton>
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:XmlDataSource ID="data" runat="server" DataFile="~/xml/data.xml"></asp:XmlDataSource>
                <br />

            </div>
        </div>
        <div class="footer" >&copy;14031214 卢秋成制作 专辑版权归暴雪娱乐所有</div>
    </div>
    </form>
    
</body>
</html>
