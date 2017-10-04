using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public class Local : Llamada
    {
        #region Atributos
        protected float _costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return this._costo; }
        }

        #endregion

        #region Constructores
        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.fechaInicio, unaLlamada.NroDestino, costo)
        {

        }
        public Local(string origen, DateTime duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }

        //porque la clase hija esta sobreescribiendo un método
        //de la clase padre
        protected override string Mostrar()
        {
            StringBuilder ret = new StringBuilder();

            ret.AppendLine(base.Mostrar());
            ret.Append(" Costo: ");
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
            return obj is Local;
        }
        #endregion
    }
}
