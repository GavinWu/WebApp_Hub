using System;
using System.Globalization;

namespace WebApp
{
    public partial class Home : System.Web.UI.Page
    {
        private const string SearchBoxErrorMessage = "Please provide a hashtag for searching";
        private const string ApiErrorMessage = "A problem occurred when searching on Instagram for that hashtag";

        protected void Page_Load(object sender, EventArgs e)
        {
            Label.Text = "Enter the hashtag you would like to search";
            Result.ForeColor = OriginalColor();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var tagname = HashTagSearchInput.Text;

            if (string.IsNullOrWhiteSpace(tagname) ||
                string.IsNullOrEmpty(tagname))
            {
                Result.ForeColor = WarningColor();
                Result.Text = SearchBoxErrorMessage;
                return;
            }

            try
            {
                var mediaCount = HttpRequestClient.GetHashtagCount(tagname);
                Result.Text = "Hashtag count: " + mediaCount.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                Result.ForeColor = WarningColor();
                Result.Text = ApiErrorMessage;
            }
        }

        private static System.Drawing.Color WarningColor()
        {
            return System.Drawing.Color.Red;
        }

        private static System.Drawing.Color OriginalColor()
        {
            return System.Drawing.Color.Black;
        }
    }
}