using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsITCTest
{
    public partial class ImageThumbControl : UserControl
    {
        public ImageThumbControl(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }
    }
}
