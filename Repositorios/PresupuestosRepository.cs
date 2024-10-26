namespace tl2_tp5_2024_julietacolque.Repositorios;
using tl2_tp5_2024_julietacolque.Models;
public class PresupuestosRepository : IPresupuestosRepository
{

    public void CrearPresupuesto(Presupuesto presupuesto) { }
    public List<Presupuesto> ListarPresupuestos()
    {
        var listaP = new List<Presupuesto>();
        return listaP;
    }
    public Presupuesto PresupuestoPorID(int id)
    {
        var presupuesto = new Presupuesto();
        return presupuesto;
    }
    public void EliminarPresupuesto(int id) { }
}