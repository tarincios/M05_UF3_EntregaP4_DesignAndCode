using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_EntregaP4_DesignAndCode
{
    internal class DesignAndCode
    {
        public class Usuario
        {
            public int idUser;
            public string nombre;
            public string apellidos;
            public string dni;
            public string direccion;
            public string telefono;
            public string email;
            public string username;
            public string password;
            public ListaDeseos listaDeseos;
            public CarritoCompra carritoCompra;

            public void AddListaDeseos(Producto productoDeseado)
            {

            }


        }


        public class Producto
        {
            public int id;
            public string nombreProducto;
            public string marca;
            public string descripcion;
            public string imagenURL;
            public float precio;
            public float descuento;
            public Categoria categoria;
            public List<string> etiqueta;
            public List<Resena> resena;

        }


        public class Categoria
        {
            public string nomCategoria;
            public string nomSubcategoria;
            public string nomSubcategoria2;
        }

        public class ListaDeseos
        {
            public List <Producto> productoDeseo;
        }

        public class CarritoCompra
        {
            public List <DetallePedido> productoPedido;
            public float precioPedido;
        }

        public class DetallePedido
        {
            public Producto productoPedido;
            public int cantidad;
            public float precioProducto;
        }

        public class Pedido: CarritoCompra
        {
            public int numeroPedido;
            public Usuario usuario;
            public DateTime fechaPedido;

        }
        
        public class Resena
        {
            public Usuario usuario;
            public int valoracionResena;
            public string comentarioResena;
        }



    }
}
