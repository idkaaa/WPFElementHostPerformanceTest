using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormsITCTest
{
    /// <summary>
    /// Interaction logic for ITCWrapPanel.xaml
    /// </summary>
    public partial class ITCWrapPanel : UserControl
    {
        public ObservableCollection<ImageThumbControlWPF> p_ITCList = new ObservableCollection<ImageThumbControlWPF>();

        public ITCWrapPanel()
        {
            DataContext = this;
            InitializeComponent();
            c_ImageThumbControlItemsList.ItemsSource = p_ITCList;
        }
    }
}
