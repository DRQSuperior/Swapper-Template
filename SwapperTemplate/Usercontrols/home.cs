using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SwapperTemplate.Usercontrols
{
    public partial class home : UserControl
    {
        public home(string tab)
        {
            InitializeComponent();
            fnnews.ImageLocation = Convert.ToString(new JavaScriptSerializer().Deserialize<dynamic>(new WebClient().DownloadString("https://fortnite-api.com/v2/news/br"))["data"]["image"]);
            patchnotes.Text = Convert.ToString(new WebClient().DownloadString("https://raw.githubusercontent.com/DRQSuperior/SwapperTemplateApi/main/Main/PatchNotes"));
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
