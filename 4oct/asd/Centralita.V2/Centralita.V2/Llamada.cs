using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public abstract class Llamada
    {
        #region Atributos
        //protected float _duracion;
        public DateTime fechaInicio;

        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        public int Duracion
        {
            get 
            {
                TimeSpan dif = DateTime.Now - this.fechaInicio;
                return dif.Milliseconds;                
            }
        }
        public string NroDestino
        {
            get { return this._nroDestino; }
        }
        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }
        public abstract float CostoLlamada { get; }
        #endregion

        #region Constructor
        public Llamada(string origen, string destino, DateTime duracion)
        {
            this._nroOrigen = origen;
            this.fechaInicio = duracion;
            this._nroDestino = destino;
        }
        #endregion

        #region Métodos

        //el virtual permite que se modifique el contenido en las clases derivadas
        //permite sobreescribir el método
        protected virtual string Mostrar()
        {
            StringBuilder ret = new StringBuilder();

            ret.Append(" Duracion: ");
            ret.AppendLine(this.Duracion.ToString());
            ret.Append(" Nro. Origen: ");
            ret.AppendLine(this.NroOrigen);
            ret.Append(" Nro. Destino: ");
            ret.AppendLine(this.NroDestino);

            return ret.ToString();
        }



        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int ret = 0;
            if (uno.Duracion > dos.Duracion)
            {
                ret = 1;
            }
            else if (uno.Duracion < dos.Duracion)
            {
                ret = 1;
            }

            return ret;
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            return uno._nroOrigen == dos.NroOrigen
                && uno._nroDestino == dos._nroDestino
                   && uno.Equals(dos);
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }



        public override string ToString()
        {
            return this.Mostrar();
        }


        #endregion
    }
}
