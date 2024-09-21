using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class ControlListaCitas
    {
        DaoListaCitas daoThis = new DaoListaCitas();
        VistaListaAgendas vistaControlada;
        public ControlListaCitas(VistaListaAgendas vistaPasada, vistaMenu menuPasado) 
        {
            vistaControlada = vistaPasada;
            daoThis.Populate(vistaPasada);
            //Cuando se presione volver se volvera a VistaInicioGestion
            vistaControlada.btnVolver.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuPasado));
            //Cuando se presione borrar se ejecutara delete
            vistaPasada.btnBorrar.Click += (sender, e) => Delete();
        }

        //Se ejecutara la funcion delete del dao y populate para actualizar la tabla
        public void Delete()
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }
    }
}