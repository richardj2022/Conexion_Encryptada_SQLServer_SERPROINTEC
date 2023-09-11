using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
// 
using System.Data.SqlClient;
using System.Data;

namespace Conexion_Encryptada_SQLServer_SERPROINTEC.Conexion
{
    internal class ConexionMaestra
    {
        public static string conexion = Convert.ToString(Librerias.Desencryptacion.checkServer());


    }
}
