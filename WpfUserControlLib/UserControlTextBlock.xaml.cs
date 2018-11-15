using System.Windows;
using System.Windows.Controls;

namespace WpfUserControlLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControlTextBlock : UserControl
    {
        public UserControlTextBlock()
        {
            InitializeComponent();
        }

        public string DependentText
        {
            get { return (string)GetValue(DependentTextProperty); }
            set { SetValue(DependentTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DependentText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DependentTextProperty =
            DependencyProperty.Register("DependentText", typeof(string), typeof(UserControlTextBlock), new PropertyMetadata("TestValue"));
        
    }
}
