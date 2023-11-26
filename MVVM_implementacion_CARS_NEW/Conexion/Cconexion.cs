using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_CARS_NEW.Conexion
{
    class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmcars-default-rtdb.firebaseio.com/");
    }
}
