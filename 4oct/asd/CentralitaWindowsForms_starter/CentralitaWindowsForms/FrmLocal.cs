using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita.V2;

namespace CentralitaWindowsForms
{
    public partial class FrmLocal : FrmLlamada
    {
        private Local Llamada;
        private string numeroOrigen;
        private string numeroDestino;
        private DateTime duracion;
        private float costo;

        

        public override Llamada Llamadas
        {
            get { return this.Llamada; }
        }

        public FrmLocal()
        {
            InitializeComponent();
        }

        private void Local_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
            this.numeroOrigen = base.textBox1.Text;
            this.numeroDestino = base.textBox2.Text;
            this.duracion = Convert.ToDateTime(base.txtDuracion.Text); 
            float.TryParse(this.textBox3.Text, out this.costo);

            this.Llamada = new Local(this.numeroOrigen, this.duracion, this.numeroDestino, this.costo);

            

            base.btnAceptar_Click(sender, e);
        }
        
    }
}
