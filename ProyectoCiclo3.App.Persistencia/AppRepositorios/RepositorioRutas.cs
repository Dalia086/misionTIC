using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> Rutas;
 
    public RepositorioRutas()
        {
            Rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen"Audi",destino= 2020,tiempo_estimado= 100000},
                new Rutas{id=2,origen"Toyota",destino= 2021,tiempo_estimado= 90000},
                new Rutas{id=3,origen"Mazda",destino= 2000,tiempo_estimado= 150000}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return Rutas;
        }
 
        public Rutas GetBusWithId(int id){
            return Rutas.SingleOrDefault(b => b.id == id);
        }
    }
}
