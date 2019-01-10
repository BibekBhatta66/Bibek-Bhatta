using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_ID
{
    public partial class Student_Bio : Form
    {

        string urlpic;
        public Student_Bio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      private void button1_Click(object sender, EventArgs e)
        {
            Student DataEntry = new Student();

            if (DataEntry.Login(textBox1.Text, textBox2.Text) == true)
            {


                MessageBox.Show("This Data is Already Exist !! in Student", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else

                 {
                    DataEntry.Add_ID(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(),urlpic.ToString());
                  }
 }

        private void Student_Bio_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Student Photo";
            urlpic = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(urlpic);
         }
    }
}
