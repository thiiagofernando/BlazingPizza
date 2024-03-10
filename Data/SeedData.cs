namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new()
            {
                Name = "Pizza Básica de Queijo",
                Description = "É extravagante e delicioso. Por que você não iria querer uma?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new()
            {
                Id = 2,
                Name = "O Baconatorizor",
                Description = "Tem TODO tipo de bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new()
            {
                Id = 3,
                Name = "Calabresa clássica",
                Description = "é a pizza com a qual você cresceu, mas escaldante!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new()
            {
                Id = 4,
                Name = "Frango búfalo",
                Description = "Frango picante, molho picante e queijo bleu, com certeza vai te aquecer",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new()
            {
                Id = 5,
                Name = "Amantes de cogumelos",
                Description = "Tem cogumelos. Isso não é óbvio?",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new()
            {
                Id = 7,
                Name = "Delícia Vegetariana",
                Description = "é como salada, mas em uma pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new()
            {
                Id = 8,
                Name = "Marguerita",
                Description = "Pizza italiana tradicional com tomate e manjericão",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
            new()
            {
                Id = 9,
                Name = "Marguerita Tamanho Família",
                Description = "24\" de tomate puro e manjericão",
                BasePrice = 14.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
                FixedSize = 24
            }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}