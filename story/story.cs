using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story

{
    class Story
{
    string name;
    string authorname;
    string genre;
    int noOfChapters;
    int noOfLikes;
    int noOfReads;

    public Story(string name, string authorname, string genre, int noOfChapters, int noOfLikes, int noOfReads)
    {
        this.Name = name;
        this.Authorname = authorname;
        this.Genre = genre;
        this.NoOfChapters = noOfChapters;
        this.NoOfLikes = noOfLikes;
        this.NoOfReads = noOfReads;
    }

    public string Name { get => name; set => name = value; }
    public string Authorname { get => authorname; set => authorname = value; }
    public string Genre { get => genre; set => genre = value; }
    public int NoOfChapters { get => noOfChapters; set => noOfChapters = value; }
    public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }
    public int NoOfReads { get => noOfReads; set => noOfReads = value; }

    public static void genreWiseCount(List<Story> list)
    {

    }
    public override string ToString()
    {
        return string.Format("{0,15}", Genre);

    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    }
}