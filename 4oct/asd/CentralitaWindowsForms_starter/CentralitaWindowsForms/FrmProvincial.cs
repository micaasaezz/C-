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
    public partial class FrmProvincial : FrmLlamada
    {
        private Provincial provincial;
        private string numeroOrigen;
        private string numeroDestino;
        private DateTime duracion;
        private Franja franja;
        

        public override Llamada Llamadas { get { return this.provincial;} }

        public FrmProvincial()
        {
            InitializeComponent();
            foreach (Franja i in Enum.GetValues(typeof(Franja)))
            {
                this.comboBox1.Items.Add(i);       
            }

            this.comboBox1.SelectedItem = Franja.Franja_1;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            
            this.numeroOrigen = this.textBox1.Text;
            this.numeroDestino = this.textBox2.Text;
            this.duracion = Convert.ToDateTime(this.txtDuracion.Text);
            this.franja = (Franja) this.comboBox1.SelectedItem;

            this.provincial = new Provincial(this.numeroOrigen, this.franja, this.duracion, this.numeroDestino);
            
            base.btnAceptar_Click(sender, e);
        }


    }
}
