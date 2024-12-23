using System;
using System.Collections.Generic;
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

namespace SideBarWpf
{
    /// <summary>
    /// Interaction logic for ucMenueButton.xaml
    /// </summary>
    public partial class ucMenueButton : UserControl
    {
        public ucMenueButton()
        {
            InitializeComponent();
        }

        private string _Title { get; set; }

        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                lblTitle.Content = _Title;

            }
        }

      


        public static readonly DependencyProperty OImageProperty =
           DependencyProperty.Register(
               "OImage",
               typeof(ImageSource),
               typeof(ucMenueButton),
               new PropertyMetadata(null));

        public ImageSource OImage
        {
            get { return (ImageSource)GetValue(OImageProperty); }
            set { SetValue(OImageProperty, value); }
        }
    }
}

