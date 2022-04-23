using Microsoft.AspNetCore.Mvc;

namespace tryAgain.Controllers
{
    public class GloriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult Index(string encryptedMessage)
        {
            string incomingMessage = encryptedMessage.Replace("]", String.Empty);

            bool isInRow = false;
            int currentRow = 0;
            int xKey = 0;

            bool isNeedToChange = false;

            bool areWeGoingToChange = false;

            int _Gloria = 0;

            var example = "[1 2 [2 1 8 [1 3 7 10 [3 6 [1 8 [2 6 [1 8 [2 9 [1 8 4 8 9";

            string[] row1 = new string[] { "q", "w", "e", "r", "t", "y", "u", "ı", "o", "p", "ğ", "ü" };
            string[] row2 = new string[] { "a", "s", "d", "f", "g", "h", "j", "k", "l", "ş", "i" };
            string[] row3 = new string[] { "z", "x", "c", "v", "b", "n", "m", "ö", "ç" };


            string decodedMessage = "";


            foreach (var item in incomingMessage)
            {

                string currentChar = item.ToString();

                if (currentChar != " ")
                {
                    if (currentChar == "[") //MF brackets
                    {
                        if (_Gloria == 1)
                        {
                            isInRow = true;
                            isNeedToChange = true;

                            Console.WriteLine("I understood that we are in row");
                            Console.WriteLine("Im gonna change the row.");
                            _Gloria = 0;
                            xKey = 0;
                            continue;
                        }
                        else
                        {
                            if (areWeGoingToChange == false)
                            {
                                isInRow = true;
                                isNeedToChange = false;

                                Console.WriteLine("I understood that we are in row");
                                Console.WriteLine("Im not gonna change the row yet, because the letters no finished.");
                            }
                        }

                        
                    }
                    else if(isInRow && xKey == 0) //We got the middle number in the brackets
                    {
                        currentRow = (int)Char.GetNumericValue(item);
                        xKey = 1;

                        Console.WriteLine("Current row is now: " + currentRow);
                       
                    }
                    else //So we are no in the row and it' s a number of a letter.
                    {
                        switch (currentRow)
                        {
                            case 1:
                                decodedMessage += row1[(int)Char.GetNumericValue(item) - 1];
                                Console.WriteLine("I read the letter: " + decodedMessage);
                                break;

                            case 2:
                                decodedMessage += row2[(int)Char.GetNumericValue(item) - 1];
                                Console.WriteLine("I read the letter: " + decodedMessage);
                                break;

                            case 3:
                                decodedMessage += row3[(int)Char.GetNumericValue(item) - 1];
                                Console.WriteLine("I read the letter: " + decodedMessage);
                                break;
                        }
                    }
                }
                else
                {
                    if (currentChar == "[")
                    {
                        areWeGoingToChange = true;
                        Console.WriteLine("I am going to change the row.");
                    }
                    else
                    {
                        areWeGoingToChange = false;
                        Console.WriteLine("I am not going to change the row.");
                        _Gloria = 1;
                    }
                }
            }

            TempData["Resultat"] = decodedMessage;
            //return View("Result", decodedMessage);
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
