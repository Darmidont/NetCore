using System.Security.Cryptography.X509Certificates;
using Core1010.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Core1010.Repository.Interfaces
{
    public interface ITestRepositoryContext
    {
		DbSet<Engagement> Engagements { get; set; }
	    void AddEngagement(Engagement engagement);
    }
}
