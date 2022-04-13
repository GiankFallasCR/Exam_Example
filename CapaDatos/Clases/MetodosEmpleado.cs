using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;

namespace CapaDatos.Clases
{
    public class MetodosEmpleado
    {
            //MetodosEmpleado ME = new MetodosEmpleado();

        EXAMEN1Entities bd = new EXAMEN1Entities();
        public void Guardar(int codigo,string nombre,decimal horasL,decimal salarioH,decimal salarioB)
        {
            bd.sp_insertaEmpleado(codigo,nombre,horasL,salarioH, salarioB);
            bd.SaveChanges();
        }
    }
}
