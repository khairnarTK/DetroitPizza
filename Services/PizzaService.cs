using DetroitPizza.Models;
using System.Collections.Generic;
using System.Linq;

namespace DetroitPizza.Services
{
	public static class PizzaService
	{
		static List<Pizza> Pizzas {get;}
		static int nextId = 3;
	   static PizzaService()
	   {
		   Pizzas = new List<Pizza>
		   {
			new Pizza { Id=1, Name="Margherita",IsGlutenFree=true },
			new Pizza { Id=2, Name="Peppy Paneer",IsGlutenFree=false }	
		   };

	   }

	   public static List<Pizza> GetAll() => Pizzas;
	   public static Pizza Get(int id) => Pizzas.FirstOrDefault(x => x.Id == id);

	   public static void Add(Pizza pizza)
	   {
		   pizza.Id = nextId++;
		   Pizzas.Add(pizza);
	   }
	   public static void Update(Pizza pizza)
	   {
		  var index = Pizzas.FindIndex(x => x.Id == pizza.Id);
		  if(index == -1)
		  	return;

		Pizzas[index]=pizza;
	   } 

	   public static void Delete(int id)
	   {
		   var pizza = Get(id);
		   if(pizza is null)
		   	return;

		Pizzas.Remove(pizza);
	   }  
	}
}