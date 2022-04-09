using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : IdentityDbContext<RegisterUser,UserRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TL59DVJ\\SQLEXPRESS;database=PortfolioDB;integrated security=true");
        }

        public DbSet<About> Aboutss { get; set; }
        public DbSet<Contact> Contactss { get; set; }
        public DbSet<Experience> Experiencess { get; set; }
        public DbSet<Information> Informationss { get; set; }
        public DbSet<Message> Messagess { get; set; }
        public DbSet<Project> Projectss { get; set; }
        public DbSet<Service> Servicess { get; set; }
        public DbSet<Skill> Skillss { get; set; }
        public DbSet<SocialMedia> SocialMediass { get; set; }
        public DbSet<Testimonial> Testimonialss { get; set; }
        public DbSet<ToDoList> ToDoListss { get; set; }
        public DbSet<Announcement> Announcementss { get; set; }
        public DbSet<MessageUser> MessageUserss { get; set; }
    }
}
