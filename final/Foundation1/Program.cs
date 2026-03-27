using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> Videos = new List<Video>();
        
        // Create 4 videos and sets the appropriate values.
        Videos.Add(new Video("Opus No. 1", "Tim Carleton", 340));
        Videos.Add(new Video("Pirates Of The Caribbean From Barbosa's Perspective Is Hilarious", "Nomsynho", 1182));
        Videos.Add(new Video("The Failuere of Fyre Festival", "Internet Historian", 653));
        Videos.Add(new Video("What pretending to be crazy looks like", "JCS - Criminal Psychology", 3545));

        // For each video, the program adds a list of 3-4 comments with the commenter's name and text.
        Videos[0].AddComment("joshuaszeto", "This might be the first time I have ever heard it with both ears at the same time.");
        Videos[0].AddComment("thebadsinger3821", "This song is fire. That is why I always leave the customers on hold for at least 15 minutes, so they can enjoy its beauty.");
        Videos[0].AddComment("matthewmcteigue7347", "I don't know who needs to hear this, but your call is important to us and someone will be with you shortly.");
        Videos[0].AddComment("elevatorsof14s", "Admit it, you searched for this song.");

        Videos[1].AddComment("NeverwascooL", "Alternate title: Captain Jack Sparrow recounts Captain Barbosa's life for fun online");
        Videos[1].AddComment("thatguywiththeface2444", "''You sort of begrudgingly put up with Jack, because you think he's blessed by the gods'' hoo boy, that'switch pretty on point really.");
        Videos[1].AddComment("QuirkyBark32919", "Poor bootstrap bill was double cursed for a few years");

        Videos[2].AddComment("r.a.fgattaiguy845", "> no food > free tequila Oh boy that sure sounds like a great idea");
        Videos[2].AddComment("clownbaby7224", "LOL they paiud $1,200 for a refugee camp experience.");
        Videos[2].AddComment("spagett2487", "I love how Billy's wiki was changed from 'entrepreneur' to 'fraudster' xD");

        Videos[3].AddComment("UpForDown", "So this is how my acting looked when i pretended to be sick in front of my parents as a kid");
        Videos[3].AddComment("calvinsears1621", "Not sure why every murderer who gets featured here decides that their interrogation is the place to try their hand at acting for the first time.");
        Videos[3].AddComment("ΑλεξάνδραΘεοδώρου", "The second guy literally speaks as if he's in an interview for a job");
        Videos[3].AddComment("shlimthugg", "Imagine spending the rest of your life in jail while people laugh at the footage of you pretending to be insane");

        // Iterate through the list of videos and for each one, displays the title, author, length, number of comments,
        // and lists out all of the comments for that video.
        foreach (Video v in Videos)
        {
            v.Display();
        }
    }
}