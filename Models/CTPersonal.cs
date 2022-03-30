
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTPersonal
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Personal> listar()
        {
            List<Personal> list = db.Personals.ToList();
            return list;
        }

        public Personal obtener(int key)
        {
            Personal objeto = db.Personals.Single(r => r.doc_entry_personal == key);
            return objeto;
        }

        public void registrar(Personal objprueba)
        {
            db.Personals.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Personal objprueba)
        {
            Personal objactualiza = db.Personals.Single(r => r.doc_entry_personal == objprueba.doc_entry_personal);
            objactualiza.c_nombres = objprueba.c_nombres;
            objactualiza.c_ape_paterno = objprueba.c_ape_paterno;
            objactualiza.c_ape_materno = objprueba.c_ape_materno;
            objactualiza.fecha_ingreso = objprueba.fecha_ingreso;            
            objactualiza.c_perfil = objprueba.c_perfil;
            objactualiza.estado = objprueba.estado;
            objactualiza.dni = objprueba.dni;    
            objactualiza.c_sede = objprueba.c_sede;         
            objactualiza.c_instancia = objprueba.c_instancia;
            objactualiza.fecha_nacimiento = objprueba.fecha_nacimiento;
            objactualiza.escalafon = objprueba.escalafon;
            objactualiza.fecha_ingreso_lab = objprueba.fecha_ingreso_lab;
            objactualiza.fecha_termino_lab = objprueba.fecha_termino_lab;
            objactualiza.nombre_completo = objprueba.nombre_completo;   
            objactualiza.nombre_completo = objprueba.nombre_completo;
            objactualiza.unidad_organica = objprueba.unidad_organica;
            objactualiza.area = objprueba.area;
            objactualiza.tipo_personal = objprueba.tipo_personal;

            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Personal objeliminar = db.Personals.Single(r => r.doc_entry_personal == key);
            db.Personals.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
