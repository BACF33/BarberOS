using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlListaRespuestas
    {
        VistaListaRespuestas vistaControlada;
        DaoListaRespuestas daoThis = new DaoListaRespuestas();

        public ControlListaRespuestas(VistaListaRespuestas vistaPasada) 
        {
            vistaControlada = vistaPasada;
            daoThis.Populate(vistaPasada);
            daoThis.PopulateUsers(vistaPasada);
            daoThis.PopulateQuestions(vistaPasada);

            vistaControlada.btnAgregar.Click += (sender, e) => Agregar();
            vistaControlada.btnActualizar2.Click += (sender, e) => Actualizar();
            vistaControlada.btnBorrar.Click += (sender, e) => Borrar();
        }

        public void Agregar()
        {
            daoThis.insertar(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void Actualizar()
        {
            daoThis.Update(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void Borrar()
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }
    }
}
