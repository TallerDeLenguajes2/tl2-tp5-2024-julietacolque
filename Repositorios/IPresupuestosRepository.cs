
using tl2_tp5_2024_julietacolque.Models;

namespace tl2_tp5_2024_julietacolque.Repositorios;

public interface IPresupuestosRepository{
    public void CrearPresupuesto(Presupuesto presupuesto);
    public List<Presupuesto> ListarPresupuestos();
    public Presupuesto PresupuestoPorID(int id);
    public void EliminarPresupuesto(int id);
}