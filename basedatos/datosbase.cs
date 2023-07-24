using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;

namespace ESPERO_QUE_SI.basedatos
{
    public class Datosbase
    {
        public static FirebaseClient firebase = new FirebaseClient("https://green-app-6c4b8-default-rtdb.firebaseio.com/");
    }
}
