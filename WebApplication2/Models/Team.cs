using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class Team 
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string TwLink { get; set; }
        public string FCLink { get; set; }
        public string InLink { get; set; }
        public string InstaLink { get; set; }
    }
}
