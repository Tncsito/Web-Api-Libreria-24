using libreria_EESA.Data;
using libreria_EESA.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace Libreria_EESA.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        { 
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any()) 
                {
                    context.Books.AddRange(new Book() //Lo blanco es de la base de datos, y lo de verde es el modelo
                    {
                        Titulo = "1st Book Title(Miguel)",
                        Descripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now,
                        Rate = 4,
                        Genero = "Biografia del Miguel",
                        Autor = "primero",
                        CoverURL = "Https...",
                        DateAdded = DateTime.Now,
                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title(Miguel)",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        Genero = "Biografia del Copito",
                        Autor = "segundo",
                        CoverURL = "Https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
