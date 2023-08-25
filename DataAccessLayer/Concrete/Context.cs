using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        //DbContext  IdentityDbContext<WriterUser,WriterRole,int>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER2684TUNC\\SQLEXPRESS ; database=DbModCV ; integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<ToDoList> toDoLists { get; set; }
        public DbSet<Reminor> reminors { get; set; }
        public DbSet<Annonccement> annonccements { get; set; }
        public DbSet<WriterMessage> writerMessages { get; set; }
        public DbSet<MesWriterMessage> mesWriterMessages { get; set; }

    }
}
