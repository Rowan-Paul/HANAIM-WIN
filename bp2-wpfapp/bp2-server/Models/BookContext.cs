﻿using Microsoft.EntityFrameworkCore;

namespace bp2_server.Models

{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}