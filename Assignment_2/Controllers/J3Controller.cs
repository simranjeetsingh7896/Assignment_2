using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// In a sumac sequence,t1, t2,...tm, each term is an integer greater than or equal 0. Also, each term, starting with the third, is the difference of the preceding two terms.
        /// </summary>
        /// <param name="t1"> Positive integer representing the first number in sumac sequence </param>
        /// <param name="t2"> Positive integer representing the second number in sumac sequence </param>
        /// <example>
        /// eg. GET api/J3/SumacSequence/120/71   (120,71,49,22,27 )  -> The length of the sumac sequence is 5.
        /// </example>
        /// <example>
        /// eg. GET api/J3/SumacSequence/120/71   (120,7,113 )  -> The length of the sumac sequence is 3.
        /// </example>
        /// <returns>Calculate the number of terms(length) in the Sumac Sequence defined by the integers you enter.</returns>
        [Route("api/J3/SumacSequence/{t1}/{t2}")]
        [HttpGet]
        public string SumacSequence(int t1, int t2)
        {
            int count = 2;
            while (t1 >= t2 && t1 >= 0 && t2 >= 0)
            {
                count = count + 1;
                int difference = t1 - t2;    
                t1 = t2;
                t2 = difference;

            } // end of while

                return "The length of the sumac sequence is " + count + ". " ;
            
        }           
    }
}
