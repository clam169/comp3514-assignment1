using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class SampleData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                // Look for any Provinces.
                if (context.Students.Any())
                {
                    return;   // DB has already been seeded
                }

                var Students = GetStudents().ToArray();
                context.Students.AddRange(Students);
                context.SaveChanges();
            }
        }

        public static List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>() {
            new Student() {
                FirstName="Jo Jo",
                LastName="Lam",
                MobileNumber="604-111-1111",
                Email="jojo@lam.com",
                City="Vancouver",
                Specialization="Full Stack"
            },
            new Student() {
                FirstName="Megan",
                LastName="Kuo",
                MobileNumber="604-222-2222",
                Email="Megan@kuo.com",
                City="New Westminster",
                Specialization="Full Stack"
            },
            new Student() {
                FirstName="Octavio",
                LastName="Villena",
                MobileNumber="604-333-3333",
                Email="octavio@villena.com",
                City="Surrey",
                Specialization="Full Stack"
            },
            new Student() {
                FirstName="Bonnie",
                LastName="Dam",
                MobileNumber="604-444-4444",
                Email="bonnie@dam.com",
                City="Vancouver",
                Specialization="D3"
            },
            new Student() {
                FirstName="Catherine",
                LastName="Lam",
                MobileNumber="604-555-5555",
                Email="catherine@lam.com",
                City="Richmond",
                Specialization="D3"
            },
            new Student() {
                FirstName="Lance",
                LastName="Bulesco",
                MobileNumber="604-666-6666",
                Email="lance@bulesco.com",
                City="Burnaby",
                Specialization="D3"
            },
        };

            return Students;
        }

    }
}