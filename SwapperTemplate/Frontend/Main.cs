using SwapperTemplate.Usercontrols;
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
            this.SwapperIcon.ImageLocation = ("https://raw.githubusercontent.com/DRQSuperior/SwapperTemplateApi/main/img/Icon.png");
            //Made By DRQSuperior#1337.
        }

        private void home(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new home(tab));
        }

        private void NewEmotes(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new emotes(tab));
        }

        private void NewSkins(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new skins(tab));
        }

        private void Newbackblings(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new backblings(tab));
        }

        private void NewPickaxes(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new pickaxes(tab));
        }

        private void NewMisc(string tab)
        {
            Controls.Clear();
            MainPannel.Controls.Add(new misc(tab));
        }

        private void SkinsBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void DashbordBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void BackblingsBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void EmotesBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void PickaxesBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void MiscBTN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
