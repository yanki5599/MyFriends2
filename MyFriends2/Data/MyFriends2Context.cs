using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFriends2.Models;

namespace MyFriends2.Data
{
    public class MyFriends2Context : DbContext
    {
        public MyFriends2Context (DbContextOptions<MyFriends2Context> options)
            : base(options)
        {
        }

        public DbSet<MyFriends2.Models.Friend> Friend { get; set; } = default!;
        public DbSet<MyFriends2.Models.Image> Image { get; set; } = default!;
    }
}
