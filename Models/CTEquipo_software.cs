using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTEquipo_software
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Equipo_software> listar()
        {
            List<Equipo_software> list = db.Equipo_softwares.ToList();
            return list;
        }

        public Equipo_software obtener(int key)
        {
            Equipo_software objeto = db.Equipo_softwares.Single(r => r.cod_equipo_software == key);
            return objeto;
        }
        
        public void registrar(Equipo_software objprueba)
        {
            db.Equipo_softwares.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Equipo_software objprueba)
        {
            Equipo_software objactualiza = db.Equipo_softwares.Single(r => r.cod_equipo_software== objprueba.cod_equipo_software);
            objactualiza.fecha_instalacion = objprueba.fecha_instalacion;
            objactualiza.fecha_caducidad = objprueba.fecha_caducidad;
            objactualiza.observacion = objprueba.observacion;
            objactualiza.cod_software = objprueba.cod_software;
            objactualiza.cod_software = objprueba.cod_software;
            objactualiza.cod_equipo = objprueba.cod_equipo;       
            db.SubmitChanges();
        }

        public void eliminar(int pCod_eqSoft)
        {
            Equipo_software objeliminar = db.Equipo_softwares.Single(r => r.cod_equipo_software == pCod_eqSoft);
            db.Equipo_softwares.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
