using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Notes
            // 
            ClientSize = new Size(2154, 1038);
            Name = "Notes";
            ResumeLayout(false);
        }


    }
}
