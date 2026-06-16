using System.Text;

namespace Base64_Encoder_and_Decoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Encode"))
                {
                    try
                    {
                        if (comboBox2.Text.Equals("UTF-8"))
                        {
                            var a = Encoding.UTF8.GetBytes(textBox1.Text);
                            var b = Convert.ToBase64String(a);
                            textBox2.Text = b;
                        }
                        else if (comboBox2.Text.Equals("UTF-32"))
                        {
                            var a = Encoding.UTF32.GetBytes(textBox1.Text);
                            var b = Convert.ToBase64String(a);
                            textBox2.Text = b;
                        }
                    }
                    catch
                    {
                        textBox2.Text = "Something went wrong while encoding the text.";
                    }
                }
                else if (comboBox1.Text.Equals("Decode"))
                {
                    try
                    {
                        if (comboBox2.Text.Equals("UTF-8"))
                        {
                            var a = Convert.FromBase64String(textBox1.Text);
                            var b = Encoding.UTF8.GetString(a);
                            textBox2.Text = b;
                        }
                        else if (comboBox2.Text.Equals("UTF-32"))
                        {
                            var a = Convert.FromBase64String(textBox1.Text);
                            var b = Encoding.UTF32.GetString(a);
                            textBox2.Text = b;
                        }
                    }
                    catch
                    {
                        textBox2.Text = "Something went wrong while decoding the text.";
                    }
                }
            }
            catch
            {
                textBox2.Text = "Please select a format.";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
