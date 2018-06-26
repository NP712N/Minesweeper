using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    /*
* HO TEN: NGUYEN PHAT NGHI
* LOP: TH1602
* MA SO SV: 16DH110117
* CA: 2
* THU: Tu
* PM: 08
*/
    public partial class Form2 : Form
    {
        
        public int SoCot { get; set; }
        public int SoDong { get; set; }
        public int SoBom { get; set; }
        public Form2()
        {
            InitializeComponent();
            SoBom = SoCot = SoDong=10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtCot_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SoCot = Convert.ToInt32(txtCot.Text);
            SoDong = Convert.ToInt32(txtDong.Text);
            SoBom = Convert.ToInt32(txtBom.Text);
            
            this.Close();
            
        }
       
    }
}
