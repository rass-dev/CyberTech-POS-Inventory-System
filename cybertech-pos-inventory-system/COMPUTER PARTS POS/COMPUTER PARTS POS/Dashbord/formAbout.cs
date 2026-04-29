using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void formAbout_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            label2.Text = "Welcome to our Computer Parts System! This is a simple tool that helps you sell computer parts and keep track of your stock. It’s easy to use and has everything you need for your computer parts business. Our system helps you sell items quickly and keeps track of your stock. It is always to keep track of the quantity of each item you have, it’s perfect for any size of business, big or small. With our system, running your computer parts business is easy and efficient."; 
            label2.AutoSize = false;
            label2.Width = panel1.Width;             
            label2.MaximumSize = new System.Drawing.Size(panel1.Width, 0);             
            label2.Height = (int)label2.CreateGraphics().MeasureString(label2.Text, label2.Font, label2.Width).Height;             
            panel1.Height = label2.Height + 20;             
            panel1.Width = (int)label2.CreateGraphics().MeasureString(label2.Text, label2.Font, label2.Width).Width;             
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;             
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;         
        }

    }
}



