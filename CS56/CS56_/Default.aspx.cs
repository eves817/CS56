using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;



namespace CS56_

{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement Order = doc.CreateElement("訂單");
            doc.AppendChild(Order);

            XmlElement Company = doc.CreateElement("公司");
            Company.SetAttribute("名稱", "鴻海");
            Company.SetAttribute("電話", "0288096543");
            Order.AppendChild(Company);

            XmlElement Shell = doc.CreateElement("手機外殼");
            Company.AppendChild(Shell);

            XmlElement Buy1 = doc.CreateElement("第一批");
            Buy1.SetAttribute("數量", "20000");
            Buy1.SetAttribute("日期", "2015.07.01");
            Shell.AppendChild(Buy1);

            XmlElement Buy2 = doc.CreateElement("第二批");
            Buy2.SetAttribute("數量", "30000");
            Buy2.SetAttribute("日期", "2015.07.14");
            Shell.AppendChild(Buy2);
 
            doc.Save("C:\\Users\\Liu\\Desktop\\B.xml‪");
        }

     /*   public void Button2_Click(object sender, EventArgs e)
        {
           XmlDocument doc = new XmlDocument();
           doc.Load("C:\\Users\\Liu\\Desktop\\B.xml‪");

            XmlNode node = doc.SelectSingleNode("訂單/公司");
            if (node == null)
                return;

            XmlElement power = doc.CreateElement("電源供應器");
            power.SetAttribute("電壓","5V");
            power.SetAttribute("規格", "美式");
            node.AppendChild(power);

            doc.Save("‪C:\\Users\\Liu\\Desktop\\B.xml‪");

        }
    }  */

}