namespace myfirstWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*int x = 2;
            //MessageBox.Show(x.ToString());
            int y = 3;
            string fuck = "tx wo cao ni ma";
            MessageBox.Show(fuck);*/
            int x = 5;
            int y = ++x;
            MessageBox.Show(y.ToString());
            MessageBox.Show(x.ToString());
            y = x++;
            MessageBox.Show(y.ToString());
            MessageBox.Show(x.ToString());
            int[] idnt = new int[6];

        }
    }
}
