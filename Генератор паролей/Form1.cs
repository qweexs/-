using System.Text;

namespace Генератор_паролей
{
    public partial class Form1 : Form
    {
        private const string AllChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+[]{}|;:,.<>?";

        private readonly Random random = new Random();
        private int passwordLength = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            textBox1.Text = password;
            Clipboard.SetText(password); // Копирование в буфер обмена
            checkBox4_CheckedChanged(null, EventArgs.Empty);
        }

        private string GeneratePassword()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(AllChars[random.Next(AllChars.Length)]);
            }
            return password.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            int score = 0;

            if (password.Any(char.IsDigit))
            {
                score++;
            }

            if (password.Any(char.IsLower) && password.Any(char.IsUpper))
            {
                score++;
            }

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                score++;
            }

            if (password.Length >= 12)
            {
                score++;
            }

            if (score == 5)
            {
                label1.Text = "Пароль сильный!";
            }
            else if (score >= 3)
            {
                label1.Text = "Пароль достаточно надежный.";
            }
            else
            {
                label1.Text = "Пароль слабый. Рекомендуется увеличить длину и использовать различные типы символов.";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            passwordLength = trackBar1.Value;
            label4.Text = $"Длина пароля: {passwordLength}";
        }
    }
}