using decodeMarina.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace decodeMarina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult Index(string codedMessage)
        {
            string[] row1 = new string[] {"q", "w", "e", "r", "t", "y", "u", "ı", "o", "p", "ğ", "ü" };
            string[] row2 = new string[] {"a", "s", "d", "f", "g", "h", "j", "k", "l", "ş", "i"};
            string[] row3 = new string[] {"z", "x", "c", "v", "b", "n", "m", "ö", "ç"};

            var ex = "[1] 2 [2] 1 8 [1] 3 7 10 [3] 6 [1] 8 [2] 6 [1] 8 [2] 9 [1] 8 4 8 9";

            var encodedMessage = "";

            int key = 0;
            int xKey = 0;
            int currentRow = 0;
            foreach (var item in codedMessage)
            {
                char[] charsToTrim = { '[', ']' };

                Console.WriteLine(item);

                if (item != ' ')
                {
                    if (key != 1)
                    {
                        if (item.ToString() == "[")
                        {
                            key = 1;
                            continue;
                        }
                    }
                    else if (item.ToString() == "[")
                    {
                        continue;
                    }
                    else
                    {
                        if (key == 1)
                        {
                            if (item.ToString() == "]")
                            {
                                xKey = 1;
                                continue;
                            }
                            else
                            {
                                if (xKey != 1)
                                {
                                    currentRow = (int)Char.GetNumericValue(item);
                                }
                                else
                                {
                                    switch (currentRow)
                                    {
                                        case 1:
                                            encodedMessage += row1[(int)Char.GetNumericValue(item) - 1];
                                            Console.WriteLine("xx: " + row1[(int)Char.GetNumericValue(item) - 1]);
                                            break;
                                        case 2:
                                            encodedMessage += row2[(int)Char.GetNumericValue(item) - 1];
                                            Console.WriteLine("xx: " + row2[(int)Char.GetNumericValue(item) - 1]);
                                            break;
                                        case 3:
                                            encodedMessage += row3[(int)Char.GetNumericValue(item) - 1];
                                            Console.WriteLine("xx: " + row3[(int)Char.GetNumericValue(item) - 1]);
                                            break;
                                        default:
                                            xKey = 0;
                                            break;
                                    }
                                }

                                
                            }

                            
                        }

                    }
                }
            }
            {                
                
            }

            Console.WriteLine(encodedMessage);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}