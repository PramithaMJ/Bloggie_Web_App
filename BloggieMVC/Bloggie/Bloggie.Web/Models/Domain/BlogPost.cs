namespace Bloggie.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; } //Guid - uniqueidentifier data type
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }    
        public DateTime PublishedDate { get; set; }
        public bool Author { get; set; }
        public bool Visible { get; set; }

        public ICollection<Tag> Tags { get; set; } //BlogPosts have multiple Tags
    }
}
