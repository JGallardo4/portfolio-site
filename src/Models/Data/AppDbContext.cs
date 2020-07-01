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
					ProjectId = 1,
					ImageUrl = "/images/projects/ascended/ascended.png",
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
				},

				new Project
				{
					ProjectId = 2,
					ImageUrl = "/images/projects/renova/renova.png",
					Name = "Renova Contracting",

					Description = "This website is for an edmonton company that specializes in home renovations.",
					
					/*
					+ "It features a job board that shows which player classes are needed at the moment, "
					+ "and how badly. It also has a page where the user can watch live streams from "
					+ "guild members who are Twitch Streamers. All parts of the website can be updated "
					+ "in place by logging in as the site administrator.",
					*/
					
					SourceCodeUrl = "https://github.com/Juan-G-04/renova",
					LiveUrl = "https://renovacontracting.ca",
					//Tags = new Tag[]{},
					Featured = true
				},

				new Project
				{
					ProjectId = 3,
					ImageUrl = "/images/projects/portfolio/portfolio.png",
					Name = "Personal Portfolio",

					Description = "This is my personal portfolio. In other words, the site you are currently on.",
					
					/*
					+ "It features a job board that shows which player classes are needed at the moment, "
					+ "and how badly. It also has a page where the user can watch live streams from "
					+ "guild members who are Twitch Streamers. All parts of the website can be updated "
					+ "in place by logging in as the site administrator.",
					*/
					
					SourceCodeUrl = "https://github.com/Juan-G-04/portfolio-site",
					LiveUrl = "https://jgallardo.dev",
					//Tags = new Tag[]{},
					Featured = true
				}
			);
		}
	}
}