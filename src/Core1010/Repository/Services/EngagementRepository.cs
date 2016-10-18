using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core1010.Repository.Interfaces;
using Core1010.Repository.Models;

namespace Core1010.Repository.Services
{
    public class EngagementRepository : IEngagementRepository
	{

	    private readonly ITestRepositoryContext testRepositoryContext;
	    public EngagementRepository(ITestRepositoryContext testRepositoryContext)
	    {
		    this.testRepositoryContext = testRepositoryContext;
	    }

	    public IEnumerable<Engagement> GetEngagements()
	    {
		    return testRepositoryContext.Engagements;
	    }

		public void AddEngagement(Engagement engagement)
		{
			testRepositoryContext.AddEngagement(engagement);
		}
    }
}
