using System;
using Constructor;

#region Script Info
/*  Project1 - Completed By: (Group Names) - 12/11/2025
 *  
 *  Credit: We will explain who did what here
 Shy-Anna Lee step 11, step 12
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
            //STEP 11: Create at least three new object instances of the class Album. SHY-ANNA
            //Album 1 resources used: https://www.thetoptens.com/music/albums/ for top 10 albums of all time, and Wikipedia for Track list and year of release: https://en.wikipedia.org/wiki/The_Dark_Side_of_the_Moon#Track_listing
            Album album1 = new Album( 
                "Dark Side of the Moon",
                "Pink Floyd",
                1973,
                new List <string> {" Speak to Me", "Breathe (In the Air)", "On the Run", "Time, The great Gig in the Sky", "Money, Us and Them", "Any Colour You Like", "Brain Damage", "Eclipse"}
            );

            //Album 2 resources used: https://www.thetoptens.com/music/albums/ for top 10 albums of all time, and Wikipedia for Track list and year of release: https://en.wikipedia.org/wiki/American_Idiot
            Album album2 = new Album(
                "American Idiot",
                "Green Day",
                2004,
                new List <string> {"American Idiot", "Jesus of Suburbia", "Holiday", "Boulevard of Broken Dreams", "Are We the Waiting", "St. Jimmy", "Give Me Novacaine", "She's a Rebel", "Extraordinary Girl", "Letterbomb", "Wake Me up When September Ends", "Homecoming", "Whatshername"}
                );

            //Album 3 resources used: https://www.thetoptens.com/music/albums/ for top 10 albums of all time, and Wikipedia for Track list and year of release: https://en.wikipedia.org/wiki/Nevermind
            Album album3 = new Album(
                "Nevermind",
                "Nirvana",
                1991,
                new List <string> {"Smells Like Teen Spirit", "In Blossom", "Come as You Are", "Breed", "Lithium", "Polly", "Territorial Pissings", "Drain You", "Lounge Act", "Stay Away", "On a Plane", "Something in the Way", "Endless, Nameless"}
                );

            //STEP 12: Use the above method to output the Album object properties to the console for each Album object.
            album1.ShowAlbumInfo();
            album2.ShowAlbumInfo();
            album3.ShowAlbumInfo();

        }
    }
}




