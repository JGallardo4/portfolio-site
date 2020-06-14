using Microsoft.EntityFrameworkCore;
using Portfolio.Models.Projects;

namespace Portfolio.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{				
		}

		public DbSet<Project> Projects { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed projects
			modelBuilder.Entity<Project>().HasData(
				new Project
				{
					ProjectId = -1,
					ImageUrl = "/images/ascended/main-image.png",
					Name = "AscendedGuild",

					Description = "This website is the point of contact for World of Warcraft "
				  + "players who are interested in joining the Ascended guild on the Sargaris-US server.",
					
					/*
					+ "It features a job board that shows which player classes are needed at the moment, "
					+ "and how badly. It also has a page where the user can watch live streams from "
					+ "guild members who are Twitch Streamers. All parts of the website can be updated "
					+ "in place by logging in as the site administrator.",
					*/
					
					SourceCodeUrl = "https://github.com/Juan-G-04/ascended",
					LiveUrl = "https://ascendedguild.com",
					//Tags = new Tag[]{},
					Featured = true
				}
			);
		}
	}
}