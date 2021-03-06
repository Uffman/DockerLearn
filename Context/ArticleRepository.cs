﻿using DockerLearn.Models;
using System;
using System.Collections.Generic;

namespace DockerLearn.Context
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "What is Lorem Ipsum?",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 01, 20),
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            }
        };
   
        public List<Article> GetLatest()
        {
            return articles;
        }
    }
}
