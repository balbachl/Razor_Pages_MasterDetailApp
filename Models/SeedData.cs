using JellyPagesMasterDetailApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace JellyPagesMasterDetailApp.Models {
    public class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new JellyPagesMasterDetailAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JellyPagesMasterDetailAppContext>>())) {
                if (context.Phonebook.Any()) {
                    return;   // DB has been seeded
                }

                context.Phonebook.AddRange(
                    new Phonebook {
                        FirstName = "SpongeBob",
                        LastName = "SquarePants",
                        Address = "124 Conch St.",
                        Phone = "776-4377",
                        Email = "ssquarepants@bikinibottom.com"
                    },

                    new Phonebook {
                        FirstName = "Patrick",
                        LastName = "Star",
                        Address = "120 Conch St.",
                        Phone = "728-7742",
                        Email = "pstar@bikinibottom.com"
                    },

                    new Phonebook {
                        FirstName = "Eugene",
                        LastName = "Krabs",
                        Address = "2219 Anchor st.",
                        Phone = "384-3637",
                        Email = "ekrabs@bikinibottom.com"
                    },
                    new Phonebook {
                        FirstName = "Squidward",
                        LastName = "Tentacles",
                        Address = "122 Conch St.",
                        Phone = "778-4392",
                        Email = "stentacles@bikinibottom.com"
                    },
                    new Phonebook {
                        FirstName = "Sheldon",
                        LastName = "Plankton",
                        Address = "1490 Bottom Feeder Lane",
                        Phone = "723-5366",
                        Email = "splankton@bikinibottom.com"
                    },

                    new Phonebook {
                        FirstName = "Sandy",
                        LastName = "Cheeks",
                        Address = "123 Treedome St.",
                        Phone = "726-3977",
                        Email = "scheeks@bikinibottom.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
