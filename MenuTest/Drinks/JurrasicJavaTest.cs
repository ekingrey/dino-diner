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
    public class JurrasicJavaTest
    {
        
        //the correct price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava soda = new JurrasicJava();
            Assert.Equal<double>(.59, soda.Price);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(.59, soda.Price);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Medium;
            Assert.Equal<double>(.99, soda.Price);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Large;
            Assert.Equal<double>(1.49, soda.Price);
        }

        // the correct default ice is ture
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava soda = new JurrasicJava();
            Assert.False(soda.Ice);
        }

        //checks that Ice is false
        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.AddIce();
            Assert.True(soda.Ice);
        }

        //list has correct ingredients
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            JurrasicJava soda = new JurrasicJava();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava soda = new JurrasicJava();
            Assert.Equal<uint>(2, soda.Calories);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(2, soda.Calories);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Medium;
            Assert.Equal<double>(4, soda.Calories);
        }

        //The correct price and calories after changing to Large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.Size = Size.Large;
            Assert.Equal<double>(8, soda.Calories);
        }

        //correct default sspace for cream
        [Fact]
        public void CorrectDefaultSpaceForCream()
        {
            JurrasicJava soda = new JurrasicJava();
            Assert.False(soda.RoomForCream);
        }

        //correct space for cream after call
        [Fact]
        public void CorrectSpaceForCream()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.LeaveRoomForCream();
            Assert.True(soda.RoomForCream);
        }

        //correct adds ice
        [Fact]
        public void CorrectAddIce()
        {
            JurrasicJava soda = new JurrasicJava();
            soda.AddIce();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void DescriptionShouldMatch()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal(jj.Size + " Jurrasic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldSmallMatch()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal(jj.Size + " Jurrasic Java", jj.Description);
        }
        [Fact]
        public void DescriptionShouldMediumMatch()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal(jj.Size + " Jurrasic Java", jj.Description);
        }
        [Fact]
        public void DescriptionShouldLargeMatch()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal(jj.Size + " Jurrasic Java", jj.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void RoomSouldAddToSpecial()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Room For Cream", item);
                });
        }
        [Fact]
        public void AddIceAddToSpecial()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }


        [Fact]
        public void AddRoomShouldNotifySpecialChange()
        {
            JurrasicJava jj = new JurrasicJava();

            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }

        [Fact]
        public void SizeChangeShouldNotifyPriceChange()
        {
            JurrasicJava jj = new JurrasicJava();

            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size = Size.Large;
            });
        }
    }
}
