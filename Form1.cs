namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		
		public showMessage(){
			Console.WriteLine("Hello!!!!");
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label.Text = "Win form";
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            this.label.Text = "Hello world!";
        }
    }
}