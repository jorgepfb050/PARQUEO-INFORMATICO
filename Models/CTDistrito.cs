using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTDistrito
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Distrito> listar()
        {
            List<Distrito> list = db.Distritos.ToList();
            return list;
        }

        public Distrito obtener(int key)
        {
            Distrito objeto = db.Distritos.Single(r => r.c_distrito == key);
            return objeto;
        }

        public void registrar(Distrito objprueba)
        {
            db.Distritos.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Distrito objprueba)
        {
            Distrito objactualiza = db.Distritos.Single(r => r.c_distrito == objprueba.c_distrito);
            objactualiza.x_nom_distrito = objprueba.x_nom_distrito;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Distrito objeliminar = db.Distritos.Single(r => r.c_distrito == key);
            db.Distritos.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
