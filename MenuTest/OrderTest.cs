using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.Collections.ObjectModel;
namespace MenuTest
{
    public class OrderTest {

        public class MockEntree : Entrees
        {
            public override double Price { get; set; }
        }
        public class MockDrink : Side
        {
            public override double Price { get; set; }
            }

            public class MockSide : Drink
            {
                public override double Price { get; set; }
            }

            /// <summary>
            /// checks for correct subtotal
            /// </summary>

            [Theory]
            [InlineData(5, 3, 2, 0)]
            public void TotalCostShouldMatch(double ep, double sp, double dp, double t)
            {
                MockDrink d = new MockDrink();
                MockEntree e = new MockEntree();
                MockSide s = new MockSide();
                Order o = new Order();
                d.Price = 2;
                e.Price = 5;
                s.Price = 3;
                o.Add(d);
                o.Add(e);
                o.Add(s);

                Assert.Equal<double>((ep + sp + dp) + ((ep + sp + dp) * t), o.SubtotalCost);

            }

            /// <summary>
            /// checks for correct subtotal
            /// </summary>

            [Theory]
            [InlineData(5, 3, 2, 0)]
            public void NegativeSubtotalSouldntBeNegative(double ep, double sp, double dp, double t)
            {
                MockDrink d = new MockDrink();
                MockEntree e = new MockEntree();
                MockSide s = new MockSide();
                Order o = new Order();
                d.Price = 2;
                e.Price = -10;
                s.Price = 3;
                o.Add(d);
                o.Add(e);
                o.Add(s);

                Assert.Equal<double>(0, o.SubtotalCost);

            }

        }
    }
    

