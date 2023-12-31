﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) :base(options)
    {
        
    }

    // public DbSet<Quote> Quotes { get; set; }
    // public DbSet<Employee> Employees { get; set; }
    // public DbSet<Company> Companies { get; set; }
    // public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
    // public DbSet<Skill> Skills { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products  { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<EmployeeSkill>().HasKey(es => new { es.EmployeeId, es.SkillId });
    //     base.OnModelCreating(modelBuilder);
    // }

}