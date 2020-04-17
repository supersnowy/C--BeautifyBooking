﻿namespace BeautyBooking.Web.ViewModels.Blog
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class BlogPostViewModel : IMapFrom<BlogPost>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}