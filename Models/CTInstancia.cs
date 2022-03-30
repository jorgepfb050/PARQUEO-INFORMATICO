
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTInstancia
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Instancia> listar()
        {
            List<Instancia> list = db.Instancias.ToList();
            return list;
        }

        public Instancia obtener(int keySede,string keyInstancia)
        {
            Instancia objeto = db.Instancias.Single(r => r.c_sede == keySede && r.c_instancia == keyInstancia);
            return objeto;
        }

        public void registrar(Instancia objprueba)
        {
            db.Instancias.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Instancia objprueba)
        {
            Instancia objactualiza = db.Instancias.Single(r => r.c_sede == objprueba.c_sede && r.c_instancia == objprueba.c_instancia);
            objactualiza.nombre_instancia = objprueba.nombre_instancia;
            objactualiza.nro_instancia = objprueba.nro_instancia;
            objactualiza.activo = objprueba.activo;
            objactualiza.c_sede = objprueba.c_sede;        
            objactualiza.x_ubicacion_fisica = objprueba.x_ubicacion_fisica;
            
            db.SubmitChanges();
        }

        public void eliminar(int keySede, string keyInstancia)
        {
            Instancia objeliminar = db.Instancias.Single(r => r.c_sede == keySede && r.c_instancia == keyInstancia);
            db.Instancias.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
