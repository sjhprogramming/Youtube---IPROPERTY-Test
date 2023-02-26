namespace YET_Testing_IProperty_Winforms_via_Class
{
    public partial class Form1 : Form
    {
        private Class1 _class1 = new();                     // Create a new object of our class!
        Form2 newform = new Form2();                        // Create a new object of Form 2!

        public Form1()
        {
            InitializeComponent();

            #region Form Size
            //Stop the user from playing with the form sizing......
            this.MaximumSize = new System.Drawing.Size(661, 333);
            this.MinimumSize = new System.Drawing.Size(661, 333);

            // Set Max String length

            TextBoxText.MaxLength = 20;

            #endregion


            TextBoxText.DataBindings.Add("Text", _class1, "TextToChange", true, DataSourceUpdateMode.OnPropertyChanged);
            LblTextChange.DataBindings.Add("Text", TextBoxText, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
            this.DataBindings.Add("Text", _class1, "TextToChange", true, DataSourceUpdateMode.OnPropertyChanged);


        }

        /// <summary>
        /// Simple enough, lets exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Form load is not used in this app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// This Sets the TextToChange to "hello as a test"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            _class1.TextToChange = "Hello";
            this.Text = _class1.TextToChange;
            TextBoxText.Text = _class1.TextToChange;



        }

        /// <summary>
        /// Shows a message box upon a successful changeover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(_class1.TextToChange);
    }
}