using System 
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
  
 class CostumerManager 
 {
   public void Add(Costumer costumer)
   {
     Console.WriteLine("Müşteri Eklendi:"+ costumer.Name);
     }
   public void Del(Costumer costumer)
   {
     Console.WriteLine(costumer Id""costumer.Name"+"Müşteri Silindi");
     }
   public void List(Costumer[] costumers)
   {
     foreach (Costumer costumer in costumers)
     {
       Console.WriteLine();

                Console.WriteLine("---------------------------");

                Console.WriteLine("Customer ID : " + customer.Id);

                Console.WriteLine("Müşteri İsmi : " + customer.Name);

                Console.WriteLine("Müşteri Soyadı : " + customer.SurName);

                Console.WriteLine("Müşteri Şehiri : " + customer.City);

                Console.WriteLine("Müşteri Telefonu : " + customer.Phone);

                Console.WriteLine("------------------------------");

            }
       }
   }
                       
