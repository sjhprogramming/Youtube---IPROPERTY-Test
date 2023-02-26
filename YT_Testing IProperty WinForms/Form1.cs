namespace YT_Testing_IProperty_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Binding binding = new Binding("text", TextBoxText, "text", true, DataSourceUpdateMode.OnPropertyChanged);

            LblTextChange.DataBindings.Add(binding);
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}