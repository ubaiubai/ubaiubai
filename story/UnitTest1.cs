using Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story 1
{
    class Program
    {
        static void Main(string[] args)
    {

        Console.WriteLine("How many Book Details do you want to Enter:");
        int count = int.Parse(Console.ReadLine());
        List<Story> s1 = new List<Story>();
        int press = 0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the Details as follows:Name,AuthorName,Genre,NoOfChapters,NoOfLikes,NoOfReads");

            string story = Console.ReadLine();
            string[] story1 = story.Split(',');
            Story story_Details = new Story(story1[0], story1[1], int.Parse(story1[2]), int.Parse(story1[3]), int.Parse(story1[4]), int.Parse(story1[5]));
            s1.Add(story_Details);
        }
        Console.WriteLine("Press 1 for Searching based on Author:Press 2 for Searching based on Likes:");
        press = Convert.ToInt32(Console.ReadLine());
        StorySearch s = new StorySearch();
        List<Story> search = new List<Story>();
        switch (press)
        {
            case 1:
                Console.WriteLine("Please Enter the AuthorName:");
                search = NewMethod(s1, s);
                break;
            case 2:
                Console.WriteLine("Enter the Salary:");
                search = s.findStory(s1, Convert.ToInt32(Console.ReadLine()));
                break;

        }
        foreach (var item in search)
        {
            Console.WriteLine(item);
        }

    }

    private static List<Story> NewMethod(List<Story> s1, StorySearch s)
    {
        return s.findStory(s1, Console.ReadLine());
    }
}
}