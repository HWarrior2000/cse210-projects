using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("Neil deGrasse Tyson Explains Big Numbers", "StarTalk","1000");
        Video vid2 = new Video("The Moment That Makes Minecraft Great", "Any Austin","3000");
        Video vid3 = new Video("This GPU scam is Almost Impossible to Detect", "Linus Tech Tips","2000");

        vid1.AddComment("daddoesthings9461", "I love how Neil genuinely goes back and forth from hysterical to dead serious explaining something in a matter of seconds");
        vid1.AddComment("theinterruptedlife1783", "If you cant express it simply, you have not learnt it yet. How beautifully Mr.Tyson potrays  this");
        vid1.AddComment("lukeh2379", "It’s cool that he showed the universe is not only incomprehensibly large but also incomprehensibly small.");
        vid1.AddComment("StaticBlaster", "You should do a part 2 to this and talk about Graham's number, Tree(3), and countable/uncountable ordinals, Rayo's number, and absolute infinity. And the Hilbert Hotel paradox.");

        vid2.AddComment("MrPuddle01", "But where do Minecraft's rivers go?");
        vid2.AddComment("barb0za0", "also a big point is that the music plays randomly without any triggers, you’re always hopeful it’s gonna start again any second");
        vid2.AddComment("trevan5035", "Extremely refreshing to see someone celebrate the simplicities of Minecraft rather than complaining Mojang isn't making it more complicated");

        vid3.AddComment("Saturnuria", "I recently ordered a brick from eBay. When I opened the box, somebody had replaced my brick with a 5070 instead. I was furious and eBay refuse to refund me!");
        vid3.AddComment("RobertCoss", "Last year my wife tried to buy me an RTX 4070Ti Super as a birthday present. She was sent a box of assorted used cables. We never got it refunded! Thanks for covering topics like this.");
        vid3.AddComment("johnhodgson4591", "The next scam is the delivery proof where the 3rd party mailman takes a photo at your door, then pick up the item and leave.");

        List<Video> videos = new List<Video>();
        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);

        foreach(Video vid in videos)
        {
            vid.Display();
        }
    }
}