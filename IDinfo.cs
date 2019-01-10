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
    public partial class IDinfo : Form
    {
       public string S_name ;
       public  string S_collegename ;
       public  string S_fatername ;
       public  string S_mothername;
        public string Purl;
        public IDinfo()
        {
            InitializeComponent();
        }

        private void IDinfo_Load(object sender, EventArgs e)
        {

            txtFather.Text = S_fatername;
            txtName.Text = S_name;
            txtMother.Text = S_mothername;
            txtCollege.Text = S_collegename;
            pictureBox1.Image = Image.FromFile(Purl);

        }
    }
}
