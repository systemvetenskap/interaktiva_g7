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


          
            XmlNodeList nodeListAnswer = xmldoc.SelectNodes("/categories/ethicandrules/question[@id='2']/answer/answer");
            XmlNodeList nodeListCorrectAnswer = xmldoc.SelectNodes("/categories/ethicandrules/question[@id='1']/correctanswer");

            lblQuestion.Text = xmldoc.SelectSingleNode("/categories/ethicandrules/question[@id='1']").FirstChild.InnerText;

            RadioButton1.Text = nodeListAnswer[0].FirstChild.InnerText;
             //RadioButton1.Text = xmldoc.SelectSingleNode("/categories/ethicandrules/question/answer/answer[@id='1']").FirstChild.InnerText;
            RadioButton2.Text = nodeListAnswer[1].FirstChild.InnerText;
            RadioButton3.Text = nodeListAnswer[2].InnerText;
            RadioButton4.Text = nodeListAnswer[3].FirstChild.InnerText;
            RadioButton5.Text = nodeListCorrectAnswer[0].FirstChild.InnerText;


        }


    }

}