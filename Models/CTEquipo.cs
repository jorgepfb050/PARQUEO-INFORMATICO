
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTEquipo
    {
        
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Equipo> listar()
        {
            List<Equipo> list = db.Equipos.ToList();
            return list;
        }

        public Equipo obtener(int key)
        {
            Equipo objeto = db.Equipos.Single(r => r.cod_equipo == key);
            return objeto;
        }

        public void registrar(Equipo objprueba)
        {
            db.Equipos.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Equipo objprueba)
        {
            Equipo objactualiza = db.Equipos.Single(r => r.cod_equipo == objprueba.cod_equipo);
            objactualiza.equipoPadreCod = objprueba.equipoPadreCod;
            objactualiza.equipo = objprueba.equipo;
            objactualiza.ip_equipo = objprueba.ip_equipo;
            objactualiza.marca = objprueba.marca;
            objactualiza.modelo = objprueba.modelo;
            objactualiza.procesador = objprueba.procesador;
            objactualiza.nro_serie = objprueba.nro_serie;
            objactualiza.nro_control_patrimonial = objprueba.nro_control_patrimonial;
            objactualiza.anio_adquisicion = objprueba.anio_adquisicion;
            objactualiza.nro_orden_compra = objprueba.nro_orden_compra;
            objactualiza.activo = objprueba.activo;
            objactualiza.cod_categoria = objprueba.cod_categoria;     
            objactualiza.observacion = objprueba.observacion;
            objactualiza.fecha_desactivacion = objprueba.fecha_desactivacion;
            objactualiza.estado = objprueba.estado;
            objactualiza.service_tag = objprueba.service_tag;
            objactualiza.funcionamiento = objprueba.funcionamiento; 
             
           
            
            
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Equipo objeliminar = db.Equipos.Single(r => r.cod_equipo == key);
            db.Equipos.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
