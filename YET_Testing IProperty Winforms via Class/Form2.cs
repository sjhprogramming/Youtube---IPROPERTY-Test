using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YET_Testing_IProperty_Winforms_via_Class
{
    public partial class Form2 : Form
    {
        Class1 _myclass = new Class1();

        public Form2()
        {
            InitializeComponent();
            LblText.DataBindings.Add("Text", _myclass, "TextToChange", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_myclass.TextToChange);
        }
    }
}
