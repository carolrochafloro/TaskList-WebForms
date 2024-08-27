using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebFormsPractice.Models
{
    public class TaskDBInitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetTasks().ForEach(t => context.Tasks.Add(t));
            context.SaveChanges();
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Work"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Personal"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Urgent"
                }
            };

            return categories;
        }

        private static List<Task> GetTasks()
        {
            var categories = GetCategories(); // This ensures the categories exist before tasks

            var tasks = new List<Task>
            {
                new Task
                {
                    Id = Guid.NewGuid(),
                    Name = "Finish project report",
                    Description = "Complete the final report for the project.",
                    IsCompleted = false,
                    CategoryId = categories[0].Id
                },
                new Task
                {
                    Id = Guid.NewGuid(),
                    Name = "Grocery shopping",
                    Description = "Buy groceries for the week.",
                    IsCompleted = true,
                    CategoryId = categories[1].Id
                },
                new Task
                {
                    Id = Guid.NewGuid(),
                    Name = "Doctor's appointment",
                    Description = "Visit the doctor for a routine check-up.",
                    IsCompleted = false,
                    CategoryId = categories[2].Id
                }
            };

            return tasks;
        }
    }
}
