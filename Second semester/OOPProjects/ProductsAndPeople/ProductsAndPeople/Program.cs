using System;

namespace ProductsAndPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            // var r = people.GroupJoin(items, o => o.Id, i => i.PersonId, (o,i) => 
            // new { Person = o, Products = i.Join(products, o2 => o2.ProductId, i2 => i2.Id, (o2,i2) => i2).ToArray()}).ToArray();

            // var r = people.GroupJoin(items, o => o.Id, i => i.PersonId, (o,i) => 
            // new { Person = o, Products = i.Join(products, o2 => o2.ProductId, i2 => i2.Id, (o2,i2) => i2.Type + i2.Model).Aggregate((f,s) => f+s)}).ToArray();

            // Without GroupJoin and Join

            // var r = people.Select(s => new { Person = s, Products = items. Where(c => c.PersonId == s.Id).Select( s2 => products.Where(c2 => c2.Id == s2.ProductId).SingleOrDefault()).ToArray()}.ToArray();
        }
    }
}
