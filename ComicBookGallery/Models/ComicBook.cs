using System;
namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public string[] Artists { get; set; }
        public bool Favorite { get; set; }

        public ComicBook()
        {
        }
    }
}
