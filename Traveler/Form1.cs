using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traveler
{

    public partial class Form1 : Form
    {
        public static List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static char comma = ',';
        public static string planeErrorText = "Gireceğiniz Değer(rakam-virgül-rakam) formatında 3 karekterden oluşmalıdır. Örn; 1,3";

        public Form1()
        {
            InitializeComponent();
        }

        private void planeTxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;

            if (text.Length > 3)
                MessageBox.Show(planeErrorText);

            foreach (var ch in text)
            {
                if (!numbers.Contains(Convert.ToInt32(ch)))
                    MessageBox.Show(planeErrorText);
            }
        }
    }
}
