using Microsoft.EntityFrameworkCore;
using Lab05.Models;

namespace Lab05.Models
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options)
        {
        }
        public DbSet<Todo> Todos => Set<Todo>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>().HasData(
                new Todo
                {
                    Id = 1,
                    Name = "Mua sữa và trứng",
                    IsComplete = false,
                    Secret = "Nhiệm vụ 1: Mua sắm"
                },
                new Todo
                {
                    Id = 2,
                    Name = "Hoàn thành báo cáo Lab05",
                    IsComplete = false,
                    Secret = "Nhiệm vụ 2: Dự án code"
                },
                new Todo
                {
                    Id = 3,
                    Name = "Gọi điện cho mẹ",
                    IsComplete = true,
                    Secret = "Nhiệm vụ 3: Cá nhân"
                }
            );
        }
    }
}
