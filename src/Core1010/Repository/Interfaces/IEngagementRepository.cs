using System.Collections.Generic;
using Core1010.Repository.Models;

namespace Core1010.Repository.Interfaces
{
	public interface IEngagementRepository
	{
		IEnumerable<Engagement> GetEngagements();
		void AddEngagement(Engagement engagement);
	}
}