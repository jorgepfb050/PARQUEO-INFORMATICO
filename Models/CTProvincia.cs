using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTProvincia
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Provincia> listar()
        {
            List<Provincia> list = db.Provincias.ToList();
            return list;
        }

        public Provincia obtener(int key)
        {
            Provincia objeto = db.Provincias.Single(r => r.c_provincia == key);
            return objeto;
        }

        public void registrar(Provincia objprueba)
        {
            db.Provincias.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Provincia objprueba)
        {
            Provincia objactualiza = db.Provincias.Single(r => r.c_provincia == objprueba.c_provincia);
            objactualiza.x_nom_provincia = objprueba.x_nom_provincia;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Provincia objeliminar = db.Provincias.Single(r => r.c_provincia == key);
            db.Provincias.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
