using Biblo.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace Biblo.DataLayer
{
    public class BibloDbContext : DbContext
    {
        private readonly ClaimsPrincipal _claimsPrincipal;

        public BibloDbContext(DbContextOptions<BibloDbContext> options) : base(options)
        { 
        
        }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BoardMessage> BoardMessages { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<CommentBoard> CommentBoards { get; set; }
        public virtual DbSet<Inserting> Insertings { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PrivateChat> PrivateChats { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasOne(u => u.author);

            modelBuilder.Entity<CommentBoard>()
                .HasMany(u => u.messages);

            modelBuilder.Entity<PrivateChat>()
                .HasMany(u => u.privateMessages);

        }

    }


}