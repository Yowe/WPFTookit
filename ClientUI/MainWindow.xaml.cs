using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        Other frm;
        public MainWindow()
        {
            InitializeComponent();

            List<Student> list = new List<Student>() {
                new Student{ Name="123"},
                new Student{ Name="Tom"}
            };
            this.list1.DataContext = list;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"E:\其他\需求问题\需求问题\20180725-20180731-佛山市南海中美玩具厂.xlsx";
            ExcelReaderLib.ExcelReader reader = new ExcelReaderLib.ExcelReader(path);
            reader.Reader();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }

    public class Student
    {
        public string Name { get; set; }
    }
}
