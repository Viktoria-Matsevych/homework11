namespace homework10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string path = txtMyInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Введіть шлях до файлу");
                return;
            }
            if (!File.Exists(path))
            {
                MessageBox.Show("Файл не знайдено або шлях неправильний :(");
                return;
            }

            try
            {
                txtFileContent.Text = File.ReadAllText(path);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Немає дозволу на читання файлу");
            }
            catch (IOException)
            {
                MessageBox.Show("Не вдалося прочитати файл");
            }
        }

        private void txtFileContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
