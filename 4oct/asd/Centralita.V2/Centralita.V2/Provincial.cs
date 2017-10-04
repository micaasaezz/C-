using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja _franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, miFranja, unaLlamada.fechaInicio, unaLlamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, DateTime duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99F;
                    break;
                case Franja.Franja_2:
                    costo = 1.25F;
                    break;
                case Franja.Franja_3:
                    costo = 0.66F;
                    break;
            }

            return base.Duracion * costo;
        }

        protected override string Mostrar()
        {
            StringBuilder ret = new StringBuilder();

            ret.AppendLine(base.Mostrar());
            ret.Append(" Franja horaria: ");
            ret.AppendLine(this._franjaHoraria.ToString());
            ret.Append(" Costo llamada: ");
            ret.AppendLine(this.CostoLlamada.ToString());

            return ret.ToString();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        #endregion
    }
}
