using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            Estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre"Audi",direccion= 2020,coord_x= 100000,coord_y= 4,Tipo= "POP678"},
                new Estaciones{id=2,nombre"Toyota",direccion= 2021,coord_x= 90000,coord_y= 16,Tipo= "OIU859"},
                new Estaciones{id=3,nombre"Mazda",direccion= 2000,coord_x= 150000,coord_y= 24,Tipo= "YUH859"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return Estaciones;
        }
 
        public Estaciones GetBusWithId(int id){
            return Estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}
