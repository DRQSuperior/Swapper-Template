
namespace SwapperTemplate.Usercontrols
{
    partial class home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patchnotes = new System.Windows.Forms.RichTextBox();
            this.fnnews = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fnnews)).BeginInit();
            this.SuspendLayout();
            // 
            // patchnotes
            // 
            this.patchnotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patchnotes.Location = new System.Drawing.Point(0, 0);
            this.patchnotes.Name = "patchnotes";
            this.patchnotes.ReadOnly = true;
            this.patchnotes.Size = new System.Drawing.Size(463, 619);
            this.patchnotes.TabIndex = 4;
            this.patchnotes.Text = "";
            // 
            // fnnews
            // 
            this.fnnews.ImageRotate = 0F;
            this.fnnews.Location = new System.Drawing.Point(557, 3);
            this.fnnews.Name = "fnnews";
            this.fnnews.ShadowDecoration.Parent = this.fnnews;
            this.fnnews.Size = new System.Drawing.Size(372, 200);
            this.fnnews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fnnews.TabIndex = 3;
            this.fnnews.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patchnotes);
            this.Controls.Add(this.fnnews);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1012, 619);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fnnews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox patchnotes;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox fnnews;
    }
}
