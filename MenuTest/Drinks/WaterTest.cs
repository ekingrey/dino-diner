/* SodasaurousTest.cs
 * Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {

        //the correct price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water soda = new Water();
            Assert.Equal<double>(.10, soda.Price);

        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water soda = new Water();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(.10, soda.Price);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water soda = new Water();
            soda.Size = Size.Medium;
            Assert.Equal<double>(.10, soda.Price);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water soda = new Water();
            soda.Size = Size.Large;
            Assert.Equal<double>(.10, soda.Price);
        }

        // the correct default ice is ture
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water soda = new Water();
            Assert.True(soda.Ice);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water soda = new Water();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            
            Assert.Equal<int>(1, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water soda = new Water();
            Assert.Equal<uint>(0, soda.Calories);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water soda = new Water();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(0, soda.Calories);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water soda = new Water();
            soda.Size = Size.Medium;
            Assert.Equal<double>(0, soda.Calories);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water soda = new Water();
            soda.Size = Size.Large;
            Assert.Equal<double>(0, soda.Calories);
        }

        //checks default lemon
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water soda = new Water();
            Assert.False(soda.Lemon);

        }

        //checks if lemon was added
        [Fact]
        public void ShouldAddtLemon()
        {
            Water soda = new Water();
            soda.AddLemon();
            Assert.True(soda.Lemon);

        }

        //checks if ice was removed
        [Fact]
        public void ShouldHoldIce()
        {
            Water soda = new Water();
            soda.HoldIce();
            Assert.False(soda.Ice);

        }
    }
}
