using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FormsITCTest
{
    public partial class Form1 : Form
    {

        private FlowLayoutPanel p_FlowPanel { get; set; }

        private ElementHost p_WrapPanel { get; set; }

        private bool p_IsWPF = false;

        public Form1()
        {
            InitializeComponent();
            f_Initialize();
        }


        ///// 10/20/2015 - CLH
        ///// <summary>
        ///// Prevents tearing artifacts from scrolling.
        ///// </summary>
        ///// <remarks>
        ///// http://stackoverflow.com/questions/3718380/winforms-double-buffering/3718648#3718648
        ///// </remarks>
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}

        private void f_Initialize()
        {
            int numthumbs = 300;
            f_LoadFlowControl(numthumbs);
            f_LoadWrapPanel(numthumbs);
        }

        private void f_LoadWrapPanel(int numThumbs)
        {
            if (p_IsWPF == false)
            {
                return;
            }
            this.Text = "WPF";
            ITCWrapPanel wp = new ITCWrapPanel();

            p_WrapPanel = new ElementHost();
            p_WrapPanel.Child = wp;
            p_WrapPanel.Dock = DockStyle.Fill;
            this.Controls.Add(p_WrapPanel);

            for (int i = 0; i < numThumbs; ++i)
            {
                f_AddSingleWPFThumbControl(wp.p_ITCList);
            }
        }

        private void f_LoadFlowControl(int numThumbs)
        {
            if(p_IsWPF == true)
            {
                return;
            }
            this.Text = "Winforms";
            p_FlowPanel = new FlowLayoutPanel();
            p_FlowPanel.AutoScroll = true;
            p_FlowPanel.AutoSize = true;
            p_FlowPanel.Dock = DockStyle.Fill;
            this.Controls.Add(p_FlowPanel);
            for (int i = 0; i < numThumbs; ++i)
            {
                f_AddSingleThumbControl(p_FlowPanel);
            }
        }


        private void f_AddSingleWPFThumbControl(ObservableCollection<ImageThumbControlWPF> wpfControlList)
        {
            ImageThumbControlWPF itc = new ImageThumbControlWPF();
            ImageSource imageSource = new BitmapImage(new Uri(@"Resources/Image1.jpg", UriKind.Relative));
            itc.c_Image.Source = imageSource;
            wpfControlList.Add(itc);
        }

        private void f_AddSingleThumbControl(FlowLayoutPanel flp)
        {
            ImageThumbControl itc = new ImageThumbControl(Properties.Resources.Image1);
            flp.Controls.Add(itc);
        }

        private void Handle_ButtonSwitchMode_Click(object sender, EventArgs e)
        {
            c_ButtonSwitchMode.Enabled = false;
            if(p_IsWPF == true)
            {
                p_IsWPF = false;
                c_ButtonSwitchMode.Text = "Switch to WPF";
                this.Controls.Remove(p_WrapPanel);
            }
            else
            {
                p_IsWPF = true;
                c_ButtonSwitchMode.Text = "Switch to WinForms";
                this.Controls.Remove(p_FlowPanel);
            }
            f_Initialize();
            c_ButtonSwitchMode.Enabled = true;
        }
    }
}
