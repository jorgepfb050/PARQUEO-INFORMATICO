using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTSede
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Sede> listar()
        {
            List<Sede> list = db.Sedes.OrderBy(x=>x.nombre_sede).ToList();
           
            return list;
        }

        public Sede obtener(int key)
        {
            Sede objeto = db.Sedes.Single(r => r.c_sede == key);
            return objeto;
        }

        public void registrar(Sede objprueba)
        {
            db.Sedes.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Sede objprueba)
        {
            Sede objactualiza = db.Sedes.Single(r => r.c_sede == objprueba.c_sede);
            objactualiza.nombre_sede = objprueba.nombre_sede;
            objactualiza.direccion = objprueba.direccion;
            objactualiza.observacion = objprueba.observacion;
            objactualiza.activo = objprueba.activo;
            objactualiza.c_distrito = objprueba.c_distrito;
            objactualiza.c_provincia = objprueba.c_provincia;
          
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Sede objeliminar = db.Sedes.Single(r => r.c_sede == key);
            db.Sedes.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
