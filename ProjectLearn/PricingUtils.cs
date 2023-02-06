namespace DefaultNamespace;

class PricingUtils
{
   static void main(string[] args)
   {
       Product p1 = new Product();
       Product p2 = new Product();
       Product p3 = new Product();
       Product p4 = new Product();

       List<Product> Products = new List<Product>();
       Products.add(p1);
       Products.add(p2);
       Products.add(p3);
       Products.add(p4);

       for (Product p : Products)
       {
           console.WriteLine(Products);
       }    
   }
}