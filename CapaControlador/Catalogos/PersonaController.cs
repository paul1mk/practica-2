using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CatPersona;

namespace CapaControlador.Catalogos
{
    public class PersonaController
    {
        //Método Save que guarda/edita
        public static bool Save(Persona Obj)
        {
            return Obj.Save(Obj);
        }

        //Método Show que muestra todos los resultados
        public static DataTable Show(Persona Obj)
        {
            return new Persona().Show(Obj);
        }

        //Método SearchName busca por strings
        public static DataTable SearchName(string texto)
        {
            return new Persona().SearchName(texto);
        }

    }
}
