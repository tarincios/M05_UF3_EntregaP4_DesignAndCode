using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_EntregaP4_DesignAndCode
{
    internal class DesignAndCode
    {
        public class WebService
        {
            public WebService()
            {

            }
        }


        public class Usuario
        {
            public int id;
            public string nombre;
            public string apellidos;
            public string dni;
            public string direccion;
            public string telefono;
            public string email;
            public string username;
            public string password;

        }


        public abstract class Product
        {
            public int id;
            public string nombre;
            public string marca;
            public string imagenURL;
            public string descripcion;
            public float precioBase;
            public float descuento;



        }
        public abstract class Categoria
        {
            public string nomCategoria;
            public string nomSubcategoria;
            public string nomSubcategoria2;
        }





    }
}
