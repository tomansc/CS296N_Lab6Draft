﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Toman296Lab6.Models
{
    public class Toman296Lab2Context : IdentityDbContext<AppUser>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Toman296Lab2Context() : base("name=Toman296Lab2Context")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public System.Data.Entity.DbSet<Toman296Lab6.Models.ForumView> ForumViews { get; set; }

        public System.Data.Entity.DbSet<Toman296Lab6.Models.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<Toman296Lab6.Models.Member> Members { get; set; }
        public System.Data.Entity.DbSet<Toman296Lab6.Models.MessageView> MessageView { get; set; }

    
    }
}