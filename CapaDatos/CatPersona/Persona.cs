using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CatPersona
{
    public class Persona : NotificationEnabledObject
    {

        #region ID
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged("ID"); }
        }
        #endregion

        #region Nombre
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged("Nombre"); }
        }
        #endregion

        #region Paterno
        private string _Paterno;
        public string Paterno
        {
            get { return _Paterno; }
            set { _Paterno = value; OnPropertyChanged("Paterno"); }
        }
        #endregion

        #region Materno
        private string _Materno;
        public string Materno
        {
            get { return _Materno; }
            set { _Materno = value; OnPropertyChanged("Materno"); }
        }
        #endregion

        #region Calle
        private string _Calle;
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; OnPropertyChanged("Calle"); }
        }
        #endregion

        #region Numero
        private string _Numero;
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; OnPropertyChanged("Numero"); }
        }
        #endregion

        #region Colonia
        private string _Colonia;
        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; OnPropertyChanged("Colonia"); }
        }
        #endregion

        #region Textobuscar
        private string _Textobuscar;
        public string Textobuscar
        {
            get { return _Textobuscar; }
            set { _Textobuscar = value; OnPropertyChanged("Textobuscar"); }
        }
        #endregion

        #region Error
        private string _Error;
        public string Error
        {
            get { return _Error; }
            set { _Error = value; OnPropertyChanged("Error"); }
        }
        #endregion

        #region Metodos
        public Persona()
        {
            Clear();
        }

        public bool isValid()
        {
            bool result = false;
            Error = "";

            if (Nombre == "")
                Error += Environment.NewLine + "Nombre";
            if (Paterno == "")
                Error += Environment.NewLine + "Apellido Paterno";
            if (Materno == "")
                Error += Environment.NewLine + "Apellido Materno";
            if (Calle == "")
                Error += Environment.NewLine + "Calle";
            if (Numero == "")
                Error += Environment.NewLine + "Numero de casa";
            if(Numero.Length > 8)
                Error += Environment.NewLine + "Numero de casa no debe ser mayor a 8";
            if (Colonia == "")
                Error += Environment.NewLine + "Colonia";

            if (Error.Length > 0)
                result = true;

            return result;
        }

        public void Clear()
        {
            ID = "";
            Nombre = "";
            Paterno = "";
            Materno = "";
            Calle = "";
            Numero = "";
            Colonia = "";
            Textobuscar = "";
        }

        public bool Save(Persona oPersona)
        {
            bool result = false;

            SqlConnection sqlconn = new SqlConnection(Conexion.Cn);
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "[PROC_AGREGARDISTRIBUIDOR]";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlconn;

            sqlcmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 36, ParameterDirection.ReturnValue, false, 0, 0, "", DataRowVersion.Current, null));
            if (oPersona.ID == "")
                sqlcmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar, 36, ParameterDirection.InputOutput, false, 0, 0, "ID", DataRowVersion.Current, null));
            else
                sqlcmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar, 36, "ID"));

            sqlcmd.Parameters["@ID"].Value = oPersona.ID;
            sqlcmd.Parameters.Add(new SqlParameter("@nombre", oPersona.Nombre));
            sqlcmd.Parameters.Add(new SqlParameter("@appaterno", oPersona.Paterno));
            sqlcmd.Parameters.Add(new SqlParameter("@apmaterno", oPersona.Materno));
            sqlcmd.Parameters.Add(new SqlParameter("@calle", oPersona.Calle));
            sqlcmd.Parameters.Add(new SqlParameter("@numero", oPersona.Numero));
            sqlcmd.Parameters.Add(new SqlParameter("@colonia", oPersona.Colonia));

            try
            {
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();

                if (oPersona.ID == "")
                    oPersona.ID = Convert.ToString(sqlcmd.Parameters["@ID"].Value);

                sqlcmd.Connection.Close();
                result = true;
            }
            catch (Exception ex)
            {

                if (sqlcmd.Connection.State == ConnectionState.Open)
                {
                    sqlcmd.Connection.Close();
                    Error = ex.ToString();
                }

                result = false;
            }
            sqlcmd.Dispose();
            sqlcmd = null;

            return result;

        }

        public DataTable Show(Persona oPersona)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection sqlconn = new SqlConnection(Conexion.Cn);
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "[SEL_AGREGARDISTRIBUIDOR]";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlconn;

            sqlcmd.Parameters.Add(new SqlParameter("@id", oPersona.ID));

            try
            {
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlcmd);
                SqlDat.Fill(DtResultado);

                sqlcmd.Connection.Close();
            }
            catch (Exception ex)
            {

                if (sqlcmd.Connection.State == ConnectionState.Open)
                {
                    sqlcmd.Connection.Close();
                    DtResultado = null;
                    Error = ex.ToString();
                }
            }
            sqlcmd.Dispose();
            sqlcmd = null;
            return DtResultado;

        }


        //Método BuscarNombre
        public DataTable SearchName(string texto)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection sqlconn = new SqlConnection(Conexion.Cn);
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "[SHOW_AGREGARDISTRIBUIDOR]";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlconn;

            sqlcmd.Parameters.Add(new SqlParameter("@textobuscar", texto));

            try
            {
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlcmd);
                SqlDat.Fill(DtResultado);

                sqlcmd.Connection.Close();
            }
            catch (Exception ex)
            {

                if (sqlcmd.Connection.State == ConnectionState.Open)
                {
                    sqlcmd.Connection.Close();
                    DtResultado = null;
                    Error = ex.ToString();
                }
            }
            sqlcmd.Dispose();
            sqlcmd = null;
            return DtResultado;

        }

        #endregion

    }
}
