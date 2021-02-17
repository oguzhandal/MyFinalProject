﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını ilişkilendirmek
    public class NorthwindContext : DbContext
    {
        //Hangi veritabanına bağlanılacak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Hangi veritabanıyla ilişkili olduğunu belirteceğimiz yer 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        //Hangi tablo hangi class'a denk geliyor
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}