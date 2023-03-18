using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Enumerations
{
    public class Mensajes
    {
        #region Ok
        private string _Ok;
        public string Ok
        {
            get { return _Ok; }
            set { _Ok = value; }
        }
        #endregion

        #region Error
        private string _Error;
        public string Error
        {
            get { return _Error; }
            set { _Error = value; }
        }
        #endregion

        #region Formulario
        private string _Formulario;
        public string Formulario
        {
            get { return _Formulario; }
            set { _Formulario = value; }
        }
        #endregion

        #region Dp
        private string _Dp;
        public string Dp
        {
            get { return _Dp; }
            set { _Dp = value; }
        }
        #endregion

        #region Metodos
        public Mensajes()
        {
            this.Ok = "Se guardó la información correctamente";
            this.Error = "Favor de intentarlo más tarde";
            this.Formulario = "Formulario incompleto";
            this.Dp = "Dportenis";
        }
        #endregion

    }
}
