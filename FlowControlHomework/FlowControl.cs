using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlowControlHomework
{
    [TestClass]
    public class FlowControlHomework
    {
        [TestMethod]
        public void IfFundementals() // THE GOAL IS TO CHANGE THE FLOW TO REACH ALL THE PASSING STATEMENTS AND TO FIX COMPILATION ISSUES
        {
            //bool changeFlow = /*Answer Here*/; // assign me so I can reach the assert true in my flow of execution
            //if (changeFlow)
            //{
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Assert.IsTrue(false);
            //}

            //bool changeFlow2 = true; // assign me so I can reach the assert true in my flow of execution
            //if (changeFlow2)
            //{
            //    Assert.IsTrue(false);
            //}
            //else
            //{
            //    Assert.IsTrue(true);
            //}

            

            //bool changeFlow4 = false; // assign me so I can reach the assert true in my flow of execution
            //bool nextChangeFlow = false; // assign me so I can reach the assert true in my flow of execution
            //if (changeFlow4)
            //{
            //    Assert.IsTrue(false);
            //}
            //else if (nextChangeFlow)
            //{
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Assert.IsTrue(false);
            //}

            //bool changeFlow5 = true; // assign me so I can reach the assert true in my flow of execution
            //bool nextChangeFlow2 = true; // assign me so I can reach the assert true in my flow of execution
            //if (changeFlow5)
            //{
            //    Assert.IsTrue(false);
            //}
            //else if (nextChangeFlow2)
            //{
            //    Assert.IsTrue(false);
            //}
            //else
            //{
            //    Assert.IsTrue(true);
            //}

            

        }


        [TestMethod]
        public void IfWithOperators()
        {
            //This section is testing that you know what these operators do, provide operands to reach the pass statements.
            //     you can do this in may ways as long as you prove operands in the appropriate place.
            int myNum = 8;
            int yourNum = 6;
            int sumNum = 8;
            bool withOp = true;
            bool withOp2 = false;


            //if (myNum == yourNum)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if (myNum != sumNum)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if ( myNum < sumNum )
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if ( sumNum > myNum)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if (myNum <= yourNum)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if (sumNum >= myNum + yourNum)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if (!withOp)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if (!!withOp2)
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if ((myNum == yourNum) && (sumNum == myNum + yourNum))
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}

            //if ((yourNum == sumNum) || ( myNum == yourNum))
            //{
            //    Console.WriteLine(true);
            //    Assert.IsTrue(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Assert.IsTrue(false);
            //}  
        }

        [TestMethod]
        public void Switch()
        {
            //int number = 1;  //Assign me so I cause the next switch to pass.
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine(1);
            //        Assert.IsTrue(false);
            //        break;
            //    case 2:
            //        Console.WriteLine(2);
            //        Assert.IsTrue(false);
            //        break;
            //    case 3:
            //        Console.WriteLine(3);
            //        Assert.IsTrue(false);
            //        break;
            //    case 4:
            //        Console.WriteLine(4);
            //        Assert.IsTrue(false);
            //        break;
            //    case 5:
            //        Console.WriteLine(5);
            //        Assert.IsTrue(false);
            //        break;
            //    case 6:
            //        Console.WriteLine(6);
            //        Assert.IsTrue(false);
            //        break;
            //    case 7:
            //        Console.WriteLine(7);
            //        Assert.IsTrue(true);
            //        break;
            //}
        }


        [TestMethod]
        public void Loops()
        {
           int max2 = 17;
            // You need to do something special to get to the line that sets passed = true.
            // Some restrictions:
            // Don't change anything with the passed variable.
            // Dont change anything in the block, only change the for statement.
            // Don't change the initialization (int i = 0) in the for statement.
            // hint: you dont need increment by 1.
            // This one is tough, take your time.
            //bool passed = false;
            //for (int i = 0; i <= max2; i++)
            //{
            //    bool isOdd = !((i % 2) == 0); // notice how the variable name explains the expression? 
            //    if (isOdd)
            //    {
            //        // if you reach here test will fail. 
            //        Console.WriteLine(true);
            //        Assert.IsTrue(false);
            //    }

            //    if (i == 16) passed = true; // In the previous homework version, you could skip this line and the test would still pass. This makes sure that this statement actually is reached.
            //}
            //Assert.IsTrue(passed);  // Don't change this line.

            // break out of the loop after the test passes at least once, there are a couple ways do to this
            int counter = 0;  // Change me to get in.
            int passedCounter = 0;  // Don't change me.
            while (counter > 1 && counter < 15)
            {
                passedCounter++;
                Console.WriteLine(true);
                Assert.IsTrue(true);
                Console.WriteLine("IM STUCK IN HERE");
                if (counter == 10)
                {
                    break;
                }
            }
            Assert.IsTrue(passedCounter >= 1);  // Don't change this line.
            
            
        }
    }
}
