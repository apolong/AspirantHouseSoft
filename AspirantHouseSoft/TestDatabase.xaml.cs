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
using System.Windows.Shapes;

namespace AspirantHouseSoft
{
    /// <summary>
    /// Interaction logic for TestDatabase.xaml
    /// </summary>
    public partial class TestDatabase : Window
    {
        public TestDatabase()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AspirantHouseSoft.BOL.TestData obj = new BOL.TestData();
            obj.Email = textBox.Text;
            obj.Password = textBox1.Text;
            obj.MaQuyenHan = int.Parse(textBox2.Text);
            AspirantHouseSoft.BOL.TestData.ThemTaiKhoan(obj);
            MessageBox.Show("Them thanh cong");
        }
    }
}
