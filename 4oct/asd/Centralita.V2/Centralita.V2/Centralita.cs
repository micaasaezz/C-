using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public class Centralita
    {
        #region Atributos

        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #endregion

        #region Propiedades
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float gananciaTotal = 0;
            float ret = 0;

            foreach (Llamada i in this._listaDeLlamadas)
            {
                if (i is Local)
                {
                    gananciaLocal += ((Local)i).CostoLlamada;
                }
                else if (i is Provincial)
                {
                    gananciaProvincial += ((Provincial)i).CostoLlamada;
                }

            }
            gananciaTotal = gananciaLocal + gananciaProvincial;

            switch (tipo)
            {
                case TipoLlamada.Local:
                    ret = gananciaLocal;
                    break;
                case TipoLlamada.Provincial:
                    ret = gananciaProvincial;
                    break;
                case TipoLlamada.Todas:
                    ret = gananciaTotal;
                    break;
            }

            return ret;

        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.Append(" Razon social: ");
            ret.AppendLine(this._razonSocial);
            ret.Append(" Ganancia total: ");
            ret.AppendLine(this.GananciaTotal.ToString());
            ret.Append(" Ganancia provincial: ");
            ret.AppendLine(this.GananciaPorProvincial.ToString());
            ret.Append(" Ganancia local: ");
            ret.AppendLine(this.GananciaPorLocal.ToString());
            ret.AppendLine("Llamadas: ");
            foreach (Llamada i in this._listaDeLlamadas)
            {
                ret.AppendLine(i.ToString());
                ret.AppendLine("******************");
            }

            return ret.ToString();
        }


        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Local.OrdenarPorDuracion);
        }


        public void AgregarLlamadas(Llamada llamada)
        {
            this._listaDeLlamadas.Add(llamada);
        }


        #endregion

        #region Sobrecargas

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            bool esta = false;
            foreach (Llamada i in central._listaDeLlamadas)
            {
                if (i == llamada)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public static bool operator !=(Centralita central, Llamada llamadas)
        {
            return !(central == llamadas);
        }

        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            Centralita centralAux = central;
            if (centralAux != llamada)
            {
                centralAux.AgregarLlamadas(llamada);
            }
            
            return centralAux;
        }





        #endregion

    }
}
