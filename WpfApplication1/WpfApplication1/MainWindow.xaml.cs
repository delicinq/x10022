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
using System.IO;

namespace x100
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Console.WriteLine("Start MainWindow");
        }
        // Console.WriteLine(location);
        //File.SetAttributes(name, FileAttributes.Normal);
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] filesList = Directory.GetFiles(@"C:\Program Files\Google\Chrome", "*.exe",
                                         SearchOption.AllDirectories);

            #region
            foreach (string location in filesList)
            {
              
                try
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Chrome.exe");
                    txtBox1.AppendText("\n" + location);
                  
                }

                catch (Exception)
                {
                    System.Console.WriteLine("Caught Exception!");
                }
            }
            #endregion

            System.Console.WriteLine("Done");    
        }
    }
}
