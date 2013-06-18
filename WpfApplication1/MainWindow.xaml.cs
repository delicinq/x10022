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
using System.Management;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;

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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("Start");
            try
            {
                string[] filesList = Directory.GetFiles(@"C:\Program Files (x86)\", "*.exe",
                                             SearchOption.AllDirectories);

                string[] filesList2 = Directory.GetFiles(@"C:\Program Files\", "*.exe",
                                             SearchOption.AllDirectories);
                #region
                foreach (string location in filesList)
                {
                    //File.SetAttributes(name, FileAttributes.Normal);
                    System.Diagnostics.Process.Start(@location);
                    System.Console.WriteLine(location);
                    txtBoxShow.AppendText(location);
                }
                #endregion

                #region
                foreach (string location in filesList2)
                {
                    //File.SetAttributes(name, FileAttributes.Normal);
                    System.Diagnostics.Process.Start(@location);
                    System.Console.WriteLine(location);
                    txtBoxShow.AppendText(location);
                }
                #endregion
            }
            catch (Exception)
            {
                System.Console.WriteLine("Exception caught");
            }
            System.Console.WriteLine("Done");    
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int exeFound = 0;

            string[] filesList = Directory.GetFiles(@"C:\Program Files (x86)\", "*.exe",
                                         SearchOption.AllDirectories);

            string[] filesList2 = Directory.GetFiles(@"C:\Program Files\", "*.exe",
                                         SearchOption.AllDirectories);
            #region
            foreach (string location in filesList)
            {
                exeFound = exeFound + 1;
                System.Console.WriteLine(location);
                txtBoxShow.AppendText("\n" + exeFound + " " + location);
            }
            #endregion

            #region
            foreach (string location in filesList2)
            {
                exeFound = exeFound + 1;
                System.Console.WriteLine(location);
                txtBoxShow.AppendText("\n" + exeFound + " " + location);
            }
            #endregion
        }


        /*
         static extern uint32 SetSpeed(in namespace UInt32){


[DllImport("Cimwin32.dll", SetLastError=true)]
       


 
private void button1_Click(object sender, EventArgs e)
{

           SetSpeed(300);
}
    }
         * */
}
}
