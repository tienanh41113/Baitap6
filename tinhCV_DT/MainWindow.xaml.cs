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

namespace tinhCV_DT
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            HinhCN hcn = new HinhCN(4, 3);
            hcn.Cv();
            hcn.Dt();
            MessageBox.Show("Chu vi hình chữ nhật: " + hcn.chuvi.ToString() + "\nDiện tích hình chữ nhật: " + hcn.dientich.ToString());

            HinhTron ht = new HinhTron(3);
            ht.Cv();
            ht.Dt();
            MessageBox.Show("Chu vi hình tròn: " + ht.chuvi.ToString() + "\nDiện tích hình tròn: " + ht.dientich.ToString());

            HinhVuong hv = new HinhVuong(3);
            hv.Cv();
            hv.Dt();
            MessageBox.Show("Chu vi hình vuông: " + hv.chuvi.ToString() + "\nDiện tích hình vuông: " + hv.dientich.ToString());
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
