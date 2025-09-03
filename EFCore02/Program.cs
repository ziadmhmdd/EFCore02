using EFCore02.Contexts;
using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCore02
{
    internal class Program
    {
        static void Main()
        {
            #region Crud Operation
            // Crud Operation
            // Create - Read -  Update - Delete

            //AppDbContext context = new AppDbContext();

            //try
            //{
            //    // Code
            //}
            //finally
            //{
            //    //Context.Dispose();
            //}



            //using (AppDbContext context = new AppDbContext())
            //{
            // CRUD
            //}

            //using AppDbContext context = new AppDbContext();

            #region Create - Insert 
            //// Create - Insert 

            //var employee = new Employee()
            //{
            //    Name = "Mohamed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",
            //    Age = 25
            //};

            ////Console.WriteLine(context.Entry(employee).State); // Detached


            ////employee.Name = "Khaled";

            ////Console.WriteLine(context.Entry(employee).State); // Detached
            //////context.Add(employee);
            ////context.Employees.Add(employee);
            ////Console.WriteLine(context.Entry(employee).State); // Added

            ////var Result = context.SaveChanges();

            ////Console.WriteLine(context.Entry(employee).State); // Unchanged

            ////employee.Name = "Omar";

            ////Console.WriteLine(context.Entry(employee).State); // Modified


            ////Console.WriteLine(Result);

            ////context.Employees.Add(employee);
            ////context.Add(employee);

            ////context.SaveChanges();

            ////Console.WriteLine(context.Entry(employee).State); // Detached

            ////context.Entry(employee).State = EntityState.Added;

            ////Console.WriteLine(context.Entry(employee).State); // Added

            ////context.SaveChanges(); 
            #endregion

            #region Read - Select
            // Read - Select

            //var Result = context.Employees.Where(E => E.Id == 40).FirstOrDefault();
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //var Result = context.Employees.Select(E => E.Name);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Result?.Id);
            //Console.WriteLine(Result?.Name);

            #endregion

            #region Update
            // Update 

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(Result).State);

            //Result.Name = "Omar Ahmed";
            //Console.WriteLine(context.Entry(Result).State);

            //context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);


            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State);

            #endregion

            #region Delete
            // Delete

            //var Result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(Result).State); // Unchanged

            //context.Employees.Remove(Result);
            //Console.WriteLine(context.Entry(Result).State); // Deleted

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); // Detached 
            #endregion

            #endregion

            Department department = new Department();
            //department.Manager.
        }
    }
}
