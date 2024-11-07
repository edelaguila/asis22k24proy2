﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Movimientos;
using System.Data;

namespace Capa_Controlador_Movimientos
{
    public class Controlador
    {
        private Modelo Capa_Modelo_Movimientos = new Modelo();

        // Cambiar el constructor para usar la interfaz
        public Controlador(Modelo modelo)
        {
            Capa_Modelo_Movimientos = modelo;
        }


        public DataTable ObtenerMovi()
        {
            DataTable tiposDeCambio = Capa_Modelo_Movimientos.ObtenerMov();
            return tiposDeCambio;
        }

    }



}