using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mamalia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //string text = "Mamalia atau lebih dikenal sebagai hewan menyusui, " +
            //    "merupakan makhluk hidup yang ciri utamanya memiliki kelenjar susu dari sang betina sebagai sumber makanan bayinya. Ciri lainnya, " +
            //    "memiliki tubuh yang ditutupi rambut, vertebrata (memiliki tulang belakang) dan berdarah panas.";

            //label2.Text = text;
        }

   

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
