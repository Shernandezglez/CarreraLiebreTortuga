using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraDeAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzarCarrera_Click(object sender, EventArgs e)
        {
            Liebre l = new Liebre("Liebre");
            Tortuga t = new Tortuga("Tortuga");

            while (l.pos == 80 || t.pos == 80)
            {
                l.avanzar();
                t.avanzar();
            }
            

            if (l.pos == 80)
                MessageBox.Show("La liebre ha ganado");
            else
                MessageBox.Show("la tortuga ha ganado");
        }
    }
}
