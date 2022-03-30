using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTSoftware
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Software> listar()
        {
            List<Software> list = db.Softwares.ToList();
            return list;
        }

        public Software obtener(int key)
        {
            Software objeto = db.Softwares.Single(r => r.cod_software == key);
            return objeto;
        }

        public void registrar(Software objprueba)
        {
            db.Softwares.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Software objprueba)
        {
            Software objactualiza = db.Softwares.Single(r => r.cod_software == objprueba.cod_software);
           //se pasa el pk?
            objactualiza.software = objprueba.software;
            objactualiza.version = objprueba.version;
            objactualiza.cantidad_usuarios = objprueba.cantidad_usuarios;
            objactualiza.nro_orden_compra = objprueba.nro_orden_compra;
            objactualiza.anio_aquisicion = objprueba.anio_aquisicion;         
            objactualiza.observacion = objprueba.observacion;  db.SubmitChanges();
            objactualiza.activo = objprueba.activo;
        }

        public void eliminar(int key)
        {
            Software objeliminar = db.Softwares.Single(r => r.cod_software == key);
            db.Softwares.DeleteOnSubmit(objeliminar);         
            db.SubmitChanges();
            
        }
    }
}
