using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// To determines how many ways are to get the value of 10 by rolling 2 dices  .
        /// </summary>
        /// <param name="m"> Positive integer representing the number of sides on the first dice </param>
        /// <param name="n"> Positive integer representing the number of sides on the second dice </param>
        /// <example>
        /// eg.  GET api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// </example>
        /// <example>
        /// eg.  GET api/J2/DiceGame/5/5 -> There is 1 total way to get the sum 10.
        /// </example>
        /// <returns> calculate the number of ways to get the sum 10. </returns>

        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            int sum = 10;
            int counter = 0;
            for (int i = 1; i <= m; i++)
            {
                if (sum - i <= n && sum - i > 0)
                {

                    counter = counter + 1;

                } // end of if

            } // end of for loop

            if (counter == 1)
            {

                return "There is " + counter + " way to get the sum 10.";

            } // end of if

            else
            {

                return "There are " + counter + " ways to get the sum 10.";

            } // end of else
        }
    }
}
