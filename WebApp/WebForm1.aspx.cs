using System;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string _urlToGetTo;

        protected void Page_Load(object sender, EventArgs e)
        {
            //default
            _urlToGetTo = "http://www.google.ca";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(_urlToGetTo);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = DropDownList1.SelectedValue;
            ChangeAddress(selectedValue);
        }

        private void ChangeAddress(string dropdownChoice)
        {
            switch (dropdownChoice)
            {
                case "AppNeta":
                    _urlToGetTo = "http://www.appneta.com";
                    break;
                case "Google":
                    _urlToGetTo = "http://www.google.ca";
                    break;
                case "Weather":
                    _urlToGetTo = "http://www.theweathernetwork.com/weather/canada/british-columbia/vancouver";
                    break;
                case "News":
                    _urlToGetTo = "http://www.cbc.ca/news";
                    break;
            }
        }
    }
}