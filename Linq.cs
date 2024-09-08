using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
        
namespace Code_First
{       
    internal class Linq
    {   
        static async Task Main(string[] args)
        {
            using (var db = new EcommerceDbContext())
            {
                var products = await db.Products.ToListAsync();
                foreach (var product in products)
                {
                    Console.Write(product.Name);

                }
            }
            Console.ReadLine();
        }
}       
}       