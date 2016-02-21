﻿using System.Collections.Generic;

namespace MaintainableSelenium.API.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Browser { get; set; }
        public List<Test> Tests { get; set; }
    }
}