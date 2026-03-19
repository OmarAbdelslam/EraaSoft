using Lecture11.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Lecture11
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            using (var dbcontext = new BikeStoresContext())
            {
                // Q1
                //var customername = (from c in dbcontext.Customers
                //                   select new
                //                   {
                //                       c.FirstName,
                //                       c.LastName,
                //                       c.Email,
                //                   }).ToList();
                //foreach (var customer in customername)
                //{
                //    Console.WriteLine(customer);
                //}

                // Q2
                // var order = dbcontext.Staffs.FromSqlRaw("select s.first_name,s.last_name,o.order_id \n from sales.staffs s inner join sales.orders o \n on s.staff_id = o.staff_id").ToList();

                //var order2 = (from s in dbcontext.Staffs
                //              join o in dbcontext.Orders
                //              on s.StaffId equals o.StaffId
                //              select new { s.FirstName, s.LastName, o.OrderId, o.StaffId });
                //foreach (var o in order2)
                //{
                //    Console.WriteLine(o);
                //}

                // Q3 
                //var products = dbcontext.Products.Join(
                //    dbcontext.Categories,
                //    p=> p.CategoryId,
                //    c=> c.CategoryId,
                //    (p,c) => new
                //    {
                //        p.ProductName,
                //        p.BrandId,
                //        c.CategoryId,
                //        c.CategoryName == ""
                //    });

                //var products = dbcontext.Products.Where(p => p.Category.CategoryName == "Mountain Bikes").ToList();
                //foreach (var o in products)
                //{
                //    Console.WriteLine(o);
                //}

                ////Q4
                //var countorderstore = dbcontext.Orders.Where(o=> o.StoreId != null).Count();

                //// Q5
                //var allorder = dbcontext.Orders.Where(o=> o.ShippedDate == null).ToList();

                //// Q6

                //var customerorder = dbcontext.Orders.GroupBy(o => o.Customer.FirstName + "" + o.Customer.LastName)
                //    .Select(s => new
                //    {
                //        CustomerId = s.Key,
                //        count = s.Count()
                //    });

                //var customerorder = dbcontext.Orders.FromSqlRaw("select s.first_name +' '+s.last_name as FullName,Count(o.customer_id)\r\nfrom sales.customers s join sales.orders o\r\non s.customer_id = o.customer_id\r\ngroup by s.first_name+' '+s.last_name");
                //foreach (var o in customerorder)
                //{
                //    Console.WriteLine(o);
                //}

                //var customerorder2 = (from c in dbcontext.Customers
                //                     join o in dbcontext.Orders
                //                     on c.CustomerId equals o.CustomerId
                //                     select new
                //                     {
                //                         FullName = c.FirstName + " " + c.LastName,
                //                         o.OrderId
                //                     }).ToList();

                // Q7

                //var products = dbcontext.Products
                //                .Where(p => !dbcontext.OrderItems
                //                .Any(oi => oi.ProductId == p.ProductId))
                //                .ToList();

                // Q8 

                //var productslessthan5 = dbcontext.Products
                //    .Where(p=> dbcontext.Stocks
                //    .Any(s => s.ProductId == p.ProductId && s.Quantity < 5))
                //    .ToList();

                // 9

                //var firstProducts = dbcontext.Products.FirstOrDefault();

                //Console.WriteLine(firstProducts);

                // 10

                // var AllProducts= dbcontext.Products.Where(p=> p.ModelYear > 2018).ToList();

                // 11

                //var productorder = from oi in dbcontext.OrderItems
                //                   select new(s =>
                //                   {
                //                       oi.ProductId,
                //                       productitems = oi.ItemId
                //                   });

                //var productorder2 = dbcontext.OrderItems
                // .GroupBy(oi => oi.ProductId)
                // .Select(g => new
                // {
                //    ProductId = g.Key,
                //    Count = g.Count()
                // })
                // .ToList();


                //var productorder3 = dbcontext.Products
                //    .Select(p => new
                //    {
                //        productid = p.ProductId,
                //        productName = p.ProductName,
                //        productsOrderred = p.OrderItems.Count()
                //    });

                // 12

                //var countSpecificproduct = dbcontext.Categories
                //    .Select(c => new
                //    {
                //        c.CategoryId,
                //        c.CategoryName,
                //        productlist = c.Products.Count()
                //    });

                //var countSpecificproduct2 = from c in dbcontext.Categories

                //                             join p in dbcontext.Products

                //                             on c.CategoryId equals p.CategoryId
                //                             select new
                //                             {
                //                                 c.CategoryId,
                //                                 c.CategoryName,
                //                                 products = c.Products.Count()
                //                             };

                //foreach (var c in countSpecificproduct2) Console.WriteLine(c);

                // 13 

                //var AveragePrice = dbcontext.Products.Average(p=> p.ListPrice);

                //Console.WriteLine(AveragePrice);

                // 14 

                //var specificproducts = await dbcontext.Products.FirstOrDefaultAsync(p => p.ProductId == 11);
                //Console.WriteLine(specificproducts);

                // 15

                // var ListProduct = dbcontext.OrderItems.Where(p => p.Quantity > 3);

                // 16 

                //var staffsOrder = dbcontext.Staffs
                //    .Select(s => new
                //    {
                //        FullName = s.FirstName + " " + s.LastName,
                //        OrdersCount = s.Orders.Count()
                //    })
                //    .ToList();

                //foreach (var staffs in staffsOrder) Console.WriteLine(staffsOrder);

                //// 17

                //var ActiveStaffs = dbcontext.Staffs.Where(s => s.Active == 1);

                // 18

                //var allproducts = from p in dbcontext.Products
                //                  join b in dbcontext.Brands
                //                  on p.BrandId equals b.BrandId
                //                  join c in dbcontext.Categories
                //                  on p.CategoryId equals c.CategoryId
                //                  select new
                //                  {
                //                      p.ProductId,
                //                      p.ProductName,
                //                      p.ListPrice,
                //                      b.BrandId,
                //                      b.BrandName,
                //                      c.CategoryId,
                //                      c.CategoryName
                //                  };
                //foreach (var item in allproducts)
                //{
                //    Console.WriteLine(item);
                //}

                //// 19

                //var orderstatus = dbcontext.Orders.Where(o => o.OrderStatus == 1);

                // 20

                var products = dbcontext.Products.Where(p => p.ProductId == p.OrderItems.Any(oi=> p.ProductId == oi.ProductId) && p.OrderItems.Sum(o => o.Quantity));

                foreach(var product in products) Console.WriteLine(product);
            }

            Console.ReadKey(); 
        }
    }
}
