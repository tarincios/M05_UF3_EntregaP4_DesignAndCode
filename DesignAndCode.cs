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

            public void VerificaPassword(string password) { }
            public void CambiaPassword(string viejoPassword, string nuevoPassword) { }
            public void AgregarListaDeseos(Producto productoDeseado) { }
            public void QuitarListaDeseos(Producto productoNoDeseado) { }
            public void AgregarResena(Producto productoResena, Resena resena) { }
            public void QuitarResena(Producto productoBorraResena, Resena resena) { }

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

            public void AgregarDetallePedido(DetallePedido detallePedido) { }

        }

        public class DetallePedido
        {
            public Producto productoPedido;
            public int cantidad;
            public float precioProducto;

            public void AgregarProductoPedido(Producto producto, int cantidad, float precio) { }
        }

        public class Pedido: CarritoCompra
        {
            public int numeroPedido;
            public Usuario usuario;
            public DateTime fechaPedido;

            public void UsuarioPedido(Usuario usuarioPedido) { }

        }
        
        public class Resena
        {
            public Usuario usuario;
            public int valoracionResena;
            public string comentarioResena;
        }



    }
}
