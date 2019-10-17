using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entree
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach (string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }


        [Fact]
        public void DescriptionShouldMatch()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", TRex.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            Assert.Empty(TRex.Special);
        }

        [Fact]
        public void HoldBunSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldBun();
            Assert.Collection<string>(TRex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                });
        }

        [Fact]
        public void HoldMayoSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldMayo();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Mayo", item);
                });
        }

        [Fact]
        public void HoldTomatoSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldTomato();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Tomato", item);
                });
        }

        [Fact]
        public void HoldLettuceSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldLettuce();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Lettuce", item);
                });
        }

        [Fact]
        public void HoldOnionSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldOnion();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldKetchupSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldKetchup();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Ketchup", item);
                });
        }

        [Fact]
        public void HoldMustardSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldMustard();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldPicklesSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldPickle();
            Assert.Collection<string>(TRex.Special,
                item => {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldAllSouldAddToSpecial()
        {
            TRexKingBurger TRex = new TRexKingBurger();
            TRex.HoldBun();
            TRex.HoldKetchup();
            TRex.HoldMustard();
            TRex.HoldPickle();
            TRex.HoldMayo();
            TRex.HoldLettuce();
            TRex.HoldOnion();
            TRex.HoldTomato();

            Assert.Collection<string>(TRex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                
                 item =>
                 {
                     Assert.Equal("Hold Mayo", item);
                 },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                });

        }


        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldBun();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldMustard();
            });
        }

        [Fact]
        public void HoldingPicklesShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldPickle();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldOnion();
            });
        }
        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldLettuce();
            });
        }
        [Fact]
        public void HoldingTomatoShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldTomato();
            });
        }
        [Fact]
        public void HoldingMayoShouldNotifySpecialChange()
        {
            TRexKingBurger TRex = new TRexKingBurger();

            Assert.PropertyChanged(TRex, "Special", () =>
            {
                TRex.HoldMayo();
            });
        }

    }

}
