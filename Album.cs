using System;
using System.Collections.Generic;

namespace Constructor
{
    //STEP 2: Include a Class that represents a music album featuring the following object properties:
    public class Album
    {
        public string Name { get; private set; } //STEP 3: Name of the album
        public string Artist { get; private set; } //STEP 4: Name of the artist
        public int Year { get; private set; } //STEP 5: Year of release
        public List<string> Tracks { get; private set; } //STEP 6: List of song tracks

        //STEP 7: Build a Class constructor that enables your program to create a new Album object instance, setting each of the above properties properly.
        public Album(string name, string artist, int year, List<string> tracks)
        {
            this.Name = name;
            this.Artist = artist;
            this.Year = year;
            this.Tracks = tracks;
        }

        //STEP 8: Create a Class method that does the following:
        public void ShowAlbumDetails()
        {
            //STEP 9: Outputs the name of the album, the artist, and the year of release to the console

            //STEP 10: Outputs a neatly-formatted list of all of the album song tracks to the console.
        }
    }
}


