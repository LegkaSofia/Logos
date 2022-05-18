﻿using System;

namespace Library.Core.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Content { get; set; }
    }
}
