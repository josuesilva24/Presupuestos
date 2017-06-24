using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Presupuesto.Presupuesto_WS;

namespace Presupuesto.Models
{

    public class Catalogos
    {

        Presupuesto_WS.Service1Client channel = new Presupuesto_WS.Service1Client();

        public void getCentroCostos()
        {
            var centrocosto= channel.getCentrosCosto();
        }


    }
}