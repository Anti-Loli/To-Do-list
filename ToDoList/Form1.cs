namespace TimCoreyWinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text;
            if (!string.IsNullOrEmpty(task))
            {
                listBox1.Items.Add(task);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedTask = listBox1.SelectedIndex;

            if (selectedTask != -1)
            {
                listBox1.Items.RemoveAt(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button5.PerformClick();
                e.Handled = true;
            }

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button6.PerformClick();
                e.Handled = true;
            }
        }
    }
}
