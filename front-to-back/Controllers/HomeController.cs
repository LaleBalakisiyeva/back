using Microsoft.AspNetCore.Mvc;
using front_to_back.Models;
using front_to_back.ViewModels;
using front_to_back.DAL;

namespace front_to_back.Controllers
{
    public class HomeController : Controller
    {
      private readonly AppDbContext _context;
        
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide> ()
            {
               new Slide
               { 
                   
                   Title = "Rose",
                   Discount = 10,
                   Description = "The rose is a decorative and fragrant plant widely used in gardens and parks.",
                   Image = "1-1-524x617.png",
                    Order = 2
               },
               new Slide
               {
                    
                    Title = "Aloe Vera",
                    Discount = 15,
                    Description = "Aloe Vera is a medicinal plant known for its healing properties and easy indoor care.",
                    Image = "1-2-524x617.png",
                    Order = 3
                },
               new Slide
               {
                   
                   Title = "Ficus",
                   Discount = 5,
                   Description = "Ficus is a popular indoor plant that helps improve air quality.",
                   Image = "1-1-524x617.png",
                   Order = 1
    }
                };
            List<Product> products = new List<Product>()
{
           new Product
            {
             
              ImageUrl = "1-1-270x300.jpg",
              Text = "Rose is a popular flowering plant known for its beauty and pleasant fragrance.",
              Price = 15,
             Order = 2
            },
           new Product
            {
              
              ImageUrl = "1-1-270x300.jpg",
              Text = "Aloe Vera is a medicinal plant widely used for skin care and health purposes.",
              Price = 20,
              Order = 4
            },
           new Product
            {
               
               ImageUrl = "1-1-270x300.jpg",
               Text = "Ficus is a common indoor plant that helps purify the air and decorate interiors.",
               Price = 18,
               Order = 1
            },
           new Product
            {
              
              ImageUrl = "1-2-270x300.jpg",
              Text = "Orchid is an elegant plant admired for its colorful and long-lasting flowers.",
              Price = 25,
               Order = 3
            },
           new Product
           {
             
              ImageUrl = "1-1-270x300.jpg",
              Text = "Rose is a classic flowering plant known for its beauty, fragrance, and symbolism of love.",
              Price = 30,
              Order = 4
            },
           new Product
           {
              
               ImageUrl = "1-2-270x300.jpg",
              Text = "Tulip is a spring-blooming plant famous for its bright colors and simple, elegant shape.",
              Price = 22,
              Order = 5
            },
           new Product
           {
              
              ImageUrl = "1-1-270x300.jpg",
              Text = "Cactus is a hardy plant that thrives in dry environments and requires minimal care.",
              Price = 12,
              Order = 6
            },
         new Product
         {
              
              ImageUrl = "1-2-270x300.jpg",
              Text = "Lavender is a fragrant plant valued for its calming aroma and medicinal properties.",
              Price = 28,
              Order = 7
         }


};
            List<Blog> blogs = new List<Blog>()
            {
               new Blog
               {
                
                  Title = "The Beauty of Indoor Plants",
                  Description = "Indoor plants improve air quality and create a calm, natural atmosphere at home.",
                  Image = "1-1-310x220.jpg",
                  Date = new DateTime(2025, 1, 10),
                  Author = "Admin"
               },
               new Blog
               {
                   
                   Title = "How to Take Care of Orchids",
                   Description = "Orchids need proper light, watering, and humidity to bloom beautifully.",
                   Image = "1-1-310x220.jpg",
                   Date = new DateTime(2025, 2, 5),
                  Author = "Flora Expert"
               },
             new Blog
             {
                 
                 Title = "Benefits of Having Plants at Work",
                 Description = "Office plants reduce stress and increase productivity in the workplace.",
                  Image = "1-1-310x220.jpg",
                 Date = new DateTime(2025, 3, 1),
                Author = "Green Life"
             }
};




            _context.Sliders.AddRange(slides);
            _context.SaveChanges();

            _context.Blogs.AddRange(blogs);
            _context.SaveChanges();

            _context.Products.AddRange(products);
            _context.SaveChanges();

            HomeVM homeVM = new HomeVM 
            { 
                Slides = _context.Sliders.OrderBy(s=>s.Order).Take(2).ToList(),
                Products=products.OrderBy(s => s.Order).ToList(),
                Blogs = _context.Blogs.ToList()
            };
            return View(homeVM);
        }
    }
}
