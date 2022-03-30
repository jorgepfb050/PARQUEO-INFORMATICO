
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTPerfil
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Perfil> listar()
        {
            List<Perfil> list = db.Perfils.OrderBy(x=>x.perfil).ToList();
            return list;
        }

        public Perfil obtener(string key)
        {
            Perfil objeto = db.Perfils.Single(r => r.c_perfil == key);
            return objeto;
        }

        public void registrar(Perfil objprueba)
        {
            db.Perfils.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Perfil objprueba)
        {
            Perfil objactualiza = db.Perfils.Single(r => r.c_perfil == objprueba.c_perfil);
            objactualiza.perfil= objprueba.perfil;
            objactualiza.activo = objprueba.activo;
            objactualiza.observacion = objprueba.observacion;
           
            db.SubmitChanges();
        }

        public void eliminar(string key)
        {
            Perfil objeliminar = db.Perfils.Single(r => r.c_perfil == key);
            db.Perfils.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
