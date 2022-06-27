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

namespace WPF_MVVM_TASK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {


        controls o = new controls() { one = "", two = "", itemsgender1 = "male", itemsgender2 = "female", mobile_number = "" };

        public MainWindow()
        {


            InitializeComponent();

            DataContext = o;
            combobox1.Items.Add(o.itemsgender1);
            combobox1.Items.Add(o.itemsgender2);


            hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textboxone.Text = o.one;
            textboxtwo.Text = o.two;
            textbox5.Text = o.two;
            textbox6.Text = o.itemsgender1;
            textbox6_Copy.Text = o.mobile_number;

            show();



        }
        public void hide()
        {
            textbox4.Opacity = 0;
            textbox5.Opacity = 0;
            textbox6.Opacity = 0;
            lbl1.Opacity = 0;
            lbl2.Opacity = 0;
            lbl3.Opacity = 0;
            grid2.Opacity = 0;
            textbox6_Copy.Opacity = 0;
            lbl4.Opacity = 0;
        }
        public void show()
        {
            textbox4.Opacity = 100;
            textbox5.Opacity = 100;
            textbox6.Opacity = 100;
            lbl1.Opacity = 100;
            lbl2.Opacity = 100;
            lbl3.Opacity = 100;
            grid2.Opacity = 100;
            textbox6_Copy.Opacity = 100;
            lbl4.Opacity = 100;
        }
    }

    class controls
    {
        public string one { get; set; }
        public string two { get; set; }
        public string itemsgender1 { get; set; }
        public string itemsgender2 { get; set; }
        public string mobile_number { get; set; }

    }
}
