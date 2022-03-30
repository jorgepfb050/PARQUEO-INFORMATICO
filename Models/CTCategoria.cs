using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CTCategoria
    {
        ModeloDatoDataContext db = new ModeloDatoDataContext();

        public List<Categoria> listar()
        {
            List<Categoria> list = db.Categorias.ToList();
            return list;
        }

        public Categoria obtener(int key)
        {
            Categoria objeto = db.Categorias.Single(r => r.cod_categoria == key);
            return objeto;
        }

        public void registrar(Categoria objprueba)
        {
            db.Categorias.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
        public void actualizar(Categoria objprueba)
        {
            Categoria objactualiza = db.Categorias.Single(r => r.cod_categoria == objprueba.cod_categoria);
            objactualiza.categoria = objprueba.categoria;
            objactualiza.activo = objprueba.activo;
            objactualiza.observacion = objprueba.observacion;
           
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Categoria objeliminar = db.Categorias.Single(r => r.cod_categoria == key);
            db.Categorias.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }

    }
}

