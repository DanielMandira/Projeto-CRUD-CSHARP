using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCrudCSharp
{
    public partial class FormAbertura : Form
    {
        public FormAbertura()
        {
            InitializeComponent();
        }
        int cont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont < 1500)
            {
                timer1.Enabled= false;
                this.Hide();
                PrimeiroCrud abr= new PrimeiroCrud();
                abr.Show();
            }
        }
    }
}
