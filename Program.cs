using Systems;
namespace ClassMethodDemo 
{
  class Program 
  {
     static void main(string[] args)
     }
     Costumer.Costumer1 = new Costumer;
     Costumer1.Name = "Buğra"
     Costumer1.Surname = "Çelik"
     Costumer1.City = "Adana"
       
     Costumer.Costumer2 = new Costumer;
     Costumer2.Name = "Fatih"
     Costumer2.Surname = "Aksoy"
     Costumer2.City = "Erzurum"
     
     Costumer.costumer3 = new Costumer; 
     Costumer3.Name = "Ali"
     Costumer3.Surname = "Soydan"
     Costumer3.City = "Batman"
       
     Costumer[] costumer = new Costumer[] { Costumer1, Costumer2, Costumer3 }
     CostumerManager  costumermanager = new CostumerManager 
     CostumerManager.Add(Costumer1);
     CostumerManager.Add(Costumer2);
     CostumerManger.Add(Costumer3);
     Console.WriteLine("----->Delete: ");
     CostumerManager.Del(Costumer3);
  
     CostumerManager.List(costumers);
   }
}
       
       
  
