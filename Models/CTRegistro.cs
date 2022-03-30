using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTRegistro
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Registro> listar()
        {
            List<Registro> list = db.Registros.ToList();
            return list;
        }

        public Registro obtener(int key)
        {
            Registro objeto = db.Registros.Single(r => r.cod_registro == key);
            return objeto;
        }

        public void registrar(Registro objprueba)
        {
            db.Registros.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Registro objprueba)
        {
            Registro objactualiza = db.Registros.Single(r => r.cod_registro == objprueba.cod_registro);
            objactualiza.doc_entry_personal = objprueba.doc_entry_personal;
            objactualiza.cod_equipo = objprueba.cod_equipo;
            objactualiza.fecha_registro = objprueba.fecha_registro;
            objactualiza.fecha_sistema = objprueba.fecha_sistema;
            objactualiza.observacion = objprueba.observacion;
            
           
            objactualiza.doc_entry_personal = objprueba.doc_entry_personal;
           
            
            objactualiza.fecha_sistema = objprueba.fecha_sistema;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Registro objeliminar = db.Registros.Single(r => r.cod_registro == key);
            db.Registros.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
