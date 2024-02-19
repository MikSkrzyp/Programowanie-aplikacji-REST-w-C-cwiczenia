using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            var klient = new Calculator.CalculatorSoapClient();
            Label.Text = klient.Multiply(int.Parse(TextBox1.Text), 5).ToString();
        }
    }
}