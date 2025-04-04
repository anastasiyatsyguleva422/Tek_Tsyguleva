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

namespace WpfApp2

{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Calculate(int db, int dev, int support)
        {
            if (db > 22 || dev > 38 || support > 20)
            {
                return "Ошибка: превышены допустимые значения!";
            }

            int total = db + dev + support;

            if (total >= 56) return "5 (отлично)";
            else if (total >= 32) return "4 (хорошо)";
            else if (total >= 16) return "3 (удовл.)";
            else return "2 (неуд.)";
        }

        public void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int db = int.Parse(dbScore.Text);
                int dev = int.Parse(devScore.Text);
                int support = int.Parse(supportScore.Text);

                if (db > 22 || dev > 38 || support > 20)
                {
                    MessageBox.Show("Слишком много баллов!");
                    return;
                }

                string grade = Calculate(db, dev, support);
                int total = db + dev + support;

                resultText.Text = $"Всего: {total}";
                gradeText.Text = $"Оценка: {grade}";
            }
            catch
            {
                MessageBox.Show("Заполните все поля и вводите только числа!");
            }
        }
    }
}
