﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Getfund.Models
{
    public class ShowDetails
    {
        public int ProfileId { get; set; }

        public Nullable<int> Likes { get; set; }
        public int PId { get; set; }
        public Nullable<int> ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> NID { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string VideoLink { get; set; }
        public string Type { get; set; }
        public Nullable<double> Target { get; set; }
        public Nullable<double> MoneyRaised { get; set; }
        public Nullable<double> LikesP { get; set; }
    }
}