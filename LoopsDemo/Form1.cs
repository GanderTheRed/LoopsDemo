namespace LoopsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnForLoop_Click(object sender, EventArgs e)
        {
            //Run a loop starting at the number 0
            //Runs until the number 10
            //Each time the loop iterates, will increment value by one.
            for(int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btnForLoop2_Click(object sender, EventArgs e)
        {
            //Run a loop starting at 100
            //Run until the variable becomes less than 10

            for(int j = 100; j > 10; j = j - 10)
            {
                listBox1.Items.Add(j.ToString());
            }
        }

        private void btnForLoop3_Click(object sender, EventArgs e)
        {
            int start = int.Parse(txtStart.Text);
            int end = int.Parse(txtEnd.Text);

            for(int i = start; i <= end; i += int.Parse(txtIncrement.Text))
            {
                listBox1.Items.Add(i);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}