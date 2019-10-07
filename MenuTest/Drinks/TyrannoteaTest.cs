/* SodasaurousTest.cs
 * Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        

        //the correct price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea soda = new Tyrannotea();
            Assert.Equal<double>(.99, soda.Price);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(.99, soda.Price);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Medium;
            Assert.Equal<double>(1.49, soda.Price);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Large;
            Assert.Equal<double>(1.99, soda.Price);
        }

        // the correct default ice is ture
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea soda = new Tyrannotea();
            Assert.True(soda.Ice);
        }

        //checks that Ice is false
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Tyrannotea soda = new Tyrannotea();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);

            Assert.Equal<int>(2, ingredients.Count);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListIngredientsLemon()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.AddLemon();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListIngredientsSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Sweet = true;
            List<string> ingredients = soda.Ingredients;
            
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListIngredientsLemonAndSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.AddLemon();
            soda.Sweet = true;
            
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListIngredientsTrueFalseSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Sweet = true;
            soda.Sweet = false;
            List<string> ingredients = soda.Ingredients;

            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            
            Assert.Equal<int>(2, ingredients.Count);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea soda = new Tyrannotea();
            Assert.Equal<uint>(8, soda.Calories);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(8, soda.Calories);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Medium;
            Assert.Equal<double>(16, soda.Calories);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Size = Size.Large;
            Assert.Equal<double>(32, soda.Calories);
        }
        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmallSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Sweet = true;
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(8*2, soda.Calories);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMediumSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Sweet = true;
            soda.Size = Size.Medium;
            Assert.Equal<double>(16*2, soda.Calories);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLargeSweet()
        {
            Tyrannotea soda = new Tyrannotea();
            soda.Sweet = true;
            soda.Size = Size.Large;
            Assert.Equal<double>(32*2, soda.Calories);
        }
    }
}
