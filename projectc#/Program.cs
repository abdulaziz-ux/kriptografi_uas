using System;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public class MyForm : Form
    {
        private Label lblNumber1, lblNumber2, lblResult;
        private TextBox txtNumber1, txtNumber2;
        private Button btnCalculate;

        public MyForm()
        {
            // Set title
            Text = "Algoritma Euclidean - FPB";
            Text = "Abdul Aziz - C3";

            // Inisialisasi kontrol
            lblNumber1 = new Label() { Text = "Angka 1:", Left = 20, Top = 20, Width = 100 };
            txtNumber1 = new TextBox() { Left = 120, Top = 20, Width = 150 };

            lblNumber2 = new Label() { Text = "Angka 2:", Left = 20, Top = 60, Width = 100 };
            txtNumber2 = new TextBox() { Left = 120, Top = 60, Width = 150 };

            btnCalculate = new Button() { Text = "Hitung FPB", Left = 20, Top = 100, Width = 250 };
            btnCalculate.Click += BtnCalculate_Click;

            lblResult = new Label() { Text = "Hasil: ", Left = 20, Top = 140, Width = 250 };

            // Tambahkan kontrol ke form
            Controls.Add(lblNumber1);
            Controls.Add(txtNumber1);
            Controls.Add(lblNumber2);
            Controls.Add(txtNumber2);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);

            // Set ukuran form
            Width = 320;
            Height = 250;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil input dari pengguna
                int number1 = int.Parse(txtNumber1.Text);
                int number2 = int.Parse(txtNumber2.Text);

                // Hitung FPB menggunakan Algoritma Euclidean
                int gcd = EuclideanGCD(number1, number2);

                // Tampilkan hasil
                lblResult.Text = $"Hasil: FPB dari {number1} dan {number2} adalah {gcd}.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka bulat yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int EuclideanGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}
