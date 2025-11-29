using System;
using Constructor;

#region Script Info
/*  Project1 - Completed By: (Group Names) - 12/11/2025
 *  
 *  Credit: We will explain who did what here
 * 
 */
#endregion

#region Steps Completed without Code
//STEP 1: Create a new C# Console Application.
//STEP 13: Be sure to include helpful and appropriate comments throughout your program.
//STEP 14: In your program code comments, be sure to add citations and references for any and all materials that you consulted to help you produce your solution.
#endregion

//STEP 15: Either in the program comments code or below in the submission comment area below, please answer the following questions:
#region Questions and Answers
/*  Question: Did you use generative Artificial Intelligence (AI) to help you develop your program? Why orwhy not?
 *  Answer: 
 * 
 *  Question: If you did use AI - how did you use it? If you did not, how do you think it might help you with a challenge like this?
 *  Answer: 
 */
#endregion

namespace Project1
{
    internal class Program
    {
        static void Main()
        {
            //STEP 11: Create at least three new object instances of the class Album. SHY
            Album album1 = new Album(
                "Dark Side of the Moon",
                "Pink Floyd"
                1973,
                new List,string> {" Speak to Me", "Breathe (In the Air)", "On the Run", "Time, The great Gig in the Sky", "Money, Us and Them", "Any Colour You Like", "Brain Damage", "Eclipse"}
                );
            
            Album album2 = new Album(
                "Dark Side of the Moon",
                "Pink Floyd"
                1973,
                new List,string> {" "}
                );
            
            Album album3 = new Album(
                "Dark Side of the Moon",
                "Pink Floyd"
                1973,
                new List,string> {" "}
                );

            //STEP 12: Use the above method to output the Album object properties to the console for each Album object.
        }
    }
}

