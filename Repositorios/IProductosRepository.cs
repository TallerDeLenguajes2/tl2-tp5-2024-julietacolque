
using tl2_tp5_2024_julietacolque.Models;

namespace tl2_tp5_2024_julietacolque.Repositorios;

public interface IProductosRepository{
        public void CrearProducto(Producto prod);

        public void ModificarProducto(int id, Producto prod);
        public List<Producto>ListarProductos(int id);
        public Producto ProductoPorID(int id);
        public void EliminarProducto(int id);

}