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

namespace SwapperTemplate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            fnnews.ImageLocation = Convert.ToString(new JavaScriptSerializer().Deserialize<dynamic>(new WebClient().DownloadString("https://fortnite-api.com/v2/news/br"))["data"]["image"]);
            patchnotes.Text = Convert.ToString(new WebClient().DownloadString("https://raw.githubusercontent.com/DRQSuperior/SwapperTemplateApi/main/Main/PatchNotes"));
            this.SwapperIcon.ImageLocation = ("https://raw.githubusercontent.com/DRQSuperior/SwapperTemplateApi/main/img/Icon.png");
            //Made By DRQSuperior#1337.
        }

        private void SkinsBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Skins");
        }

        private void DashbordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Dashbord");
        }

        private void BackblingsBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Backblings");
        }

        private void EmotesBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Emotes");
        }

        private void PickaxesBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Pickaxes");
        }

        private void MiscBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon", "Settings");
        }
    }
}
