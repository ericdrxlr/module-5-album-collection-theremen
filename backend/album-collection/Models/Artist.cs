﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Hometown { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public Artist()
        {
        }

        public Artist(int id, string name, string image, string hometown)
        {
            ArtistId = id;
            Name = name;
            Image = image;
            Hometown = hometown;
        }
    }
}
