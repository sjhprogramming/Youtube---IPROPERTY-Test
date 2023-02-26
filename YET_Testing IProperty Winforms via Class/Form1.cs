namespace YET_Testing_IProperty_Winforms_via_Class
{
    public partial class Form1 : Form
    {
        private Class1 _class1 = new();

        public Form1()
        {
            InitializeComponent();

            TextBoxText.DataBindings.Add("Text", _class1, "TextToChange", true, DataSourceUpdateMode.OnPropertyChanged);
            LblTextChange.DataBindings.Add("Text", _class1, "TextToChange", true, DataSourceUpdateMode.OnPropertyChanged);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _class1.TextToChange = "Hello";
            


        }
    }
}