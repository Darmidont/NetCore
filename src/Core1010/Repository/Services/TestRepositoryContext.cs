using Core1010.Configure;
using Core1010.Repository.Interfaces;
using Core1010.Repository.Models;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace Core1010.Repository.Services
{
	public class TestRepositoryContext : DbContext, ITestRepositoryContext
	{
		private readonly AppConnectionStrings _connectionStrings;

		public TestRepositoryContext(IOptions<AppConnectionStrings> conStrOptions)
		{
			_connectionStrings = conStrOptions.Value;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
			optionsBuilder.UseSqlServer(_connectionStrings.DefaultConnection);
		}

		public DbSet<Engagement> Engagements { get; set; }
		public void AddEngagement(Engagement engagement)
		{
			Engagements.Add(engagement);
			this.SaveChanges(true);
		}
	}
}