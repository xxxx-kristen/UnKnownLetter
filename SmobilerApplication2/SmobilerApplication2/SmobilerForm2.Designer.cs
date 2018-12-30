using System;
using Smobiler.Core;
namespace SmobilerApplication2
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.image1 = new Smobiler.Core.Controls.Image();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(835, 1686);
            this.image1.Name = "image1";
            this.image1.ResourceID = "button_1";
            this.image1.Size = new System.Drawing.Size(174, 123);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.image1.ZIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(835, 1686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 123);
            this.button1.Text = "button1";
            this.button1.ZIndex = 5;
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // SmobilerForm2
            // 
            this.BackgroundImage = "introduction1";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Zoom;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.button1});
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Load += new System.EventHandler(this.SmobilerForm2_Load);
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Button button1;
    }
}