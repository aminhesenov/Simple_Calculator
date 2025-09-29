namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (num1.Text == "" || num2.Text == "" || operation.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Information");
            }
            else
            {
                int n1 = int.Parse(num1.Text);
                int n2 = int.Parse(num2.Text);
                char p = Convert.ToChar(operation.Text);

                if (p == '+')
                {
                    result = n1 + n2;
                }
                else if (p == '-')
                {
                    result = n1 - n2;
                }
                else if (p == '*')
                {
                    result = n1 * n2;
                }
                else if (p == '/')
                {
                   if(n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Operation", "Information");
                }
                if(n2 == 0 && p == '/')
                {
                     history.Items.Add("ERROR");
                }
                else
                {
                    history.Items.Add(n1 + " " + p + " " + n2 + " = " + result);
                }
            }
        }
    }
}
