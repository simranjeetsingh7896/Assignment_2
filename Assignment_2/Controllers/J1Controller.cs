using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate the total Calories of the meal by choosing the burger,drink,side and dessert from menu.
        /// </summary> 
        /// <param name="burger"> 1 - Cheeseburger (461 Calories) , 2 - Fish Burger (431 Calories), 3 - Veggie Burger (420 Calories), 4 - no burger </param>
        /// <param name="drink"> 1 - Soft Drink (130 Calories), 2 - Orange Juice (160 Calories), 3 - Milk (118 Calories), 4 - no drink </param>
        /// <param name="side"> 1 - Fries (100 Calories), 2 - Baked Potato (57 Calories), 3 - Chef Salad (70 Calories), 4 - no side order</param>
        /// <param name="dessert"> 1 - Apple Pie (167 Calories), 2 - Sundae (266 Calories), 3 - Fruit Cup (75 Calories), 4 - No Dessert</param>
        /// <example>
        /// eg. GET api/J1/Menu/4/4/4/4  -> Your total calorie count is 0.
        /// </example>
        /// <example>
        /// eg. GET api/J1/Menu/1/2/3/4  -> Your total calorie count is 691.
        /// </example>
        /// <returns> Calculate the total calories by adding from selected choice </returns>

        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories;
            if (burger == 1)                       
            {
                calories = 461;

            } //end of if
            else if (burger == 2)
            {
                calories = 431;

            } //end of else if
            else if (burger == 3)
            {
                calories = 420;

            } //end of else if
            else
            {
                calories = 0;

            } //end of else 


            if (drink == 1)
            {
                calories = calories + 130;

            } //end of if
            else if (drink == 2)
            {
                calories = calories + 160;

            } //end of else if
            else if (drink == 3)
            {
                calories = calories + 118;

            } //end of else if
            else
            {
                calories = calories + 0;

            } //end of else 


            if (side == 1)
            {
                calories = calories + 100;

            } //end of if
            else if (side == 2)
            {
                calories = calories + 57;

            } //end of else if
            else if (side == 3)
            {
                calories = calories + 70;

            } //end of else if
            else
            {
                calories = calories + 0;

            } //end of else 

            if (dessert == 1)
            {
                calories = calories + 167;

            } //end of if
            else if (dessert == 2)
            {
                calories = calories + 266;

            } //end of else if
            else if (dessert == 3)
            {
                calories = calories + 75;

            } //end of else if
            else
            {
                calories = calories + 0;

            } //end of else 

                return "Your total Calorie count is " + calories + ".";
        }
    }
}
