using System;
using System.Globalization;

namespace WebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label.Text = "Enter the hashtag you would like to search";
            Result.ForeColor = System.Drawing.Color.Black;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var tagname = HashTagSearchInput.Text;

            if (string.IsNullOrWhiteSpace(tagname) ||
                string.IsNullOrEmpty(tagname))
            {
                Result.ForeColor = System.Drawing.Color.Red;
                Result.Text = "Please provide a hashtag for searching";
                return;
            }

            try
            {
                var mediaCount = HttpRequestClient.GetHashtagCount(tagname);
                Result.Text = "Hashtag count: " + mediaCount.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                Result.ForeColor = System.Drawing.Color.Red;
                Result.Text = "A problem occurred when searching on Instagram for that hashtag";
            }
        }
    }
}