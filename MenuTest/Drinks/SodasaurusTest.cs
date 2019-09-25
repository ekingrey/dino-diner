using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //The ability to set each possible flavor
        //The correct default price, calories, ice, and size
        
        //That invoking HoldIce() results in the Ice property being false.

        //the ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);


        }
        //the correct price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        //The correct price and calories after changing to small sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        //The correct price and calories after changing to medium sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

    }
}
