using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace WebApplication1
{
    public partial class Questions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();

            xmldoc.Load(Server.MapPath("XmlQuestions.xml"));


          
            XmlNodeList nodeList = xmldoc.SelectNodes("/categories/ethicandrules/question[@id='1']/answer");

            lblQuestion.Text = xmldoc.SelectSingleNode("/categories/ethicandrules/question[@id='1']").FirstChild.InnerText;

            RadioButton1.Text = nodeList.ToString();
            //RadioButton2.Text = nodeList[1].FirstChild.InnerText;
            //RadioButton3.Text = nodeList[2].InnerTex
            //RadioButton4.Text = nodeList[3].FirstChild.InnerText;
            //RadioButton5.Text = nodeList[4].FirstChild.InnerText;


        }


    }

}