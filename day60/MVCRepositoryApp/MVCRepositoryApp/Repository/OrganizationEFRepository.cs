using MVCRepositoryApp.Data;
using MVCRepositoryApp.Domain;

namespace MVCRepositoryApp.Repository
{
    public class OrganizationEFRepository : IOrganizationRepository
    {
        private NITRKLDbContext _dbContext;

        public OrganizationEFRepository(NITRKLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddOrganization(Organization organisation)
        {
           _dbContext.Organizations.Add(organisation);
            _dbContext.SaveChanges();

        }

        public int Count()
        {
            return _dbContext.Organizations.Count();
           
        }

        public List<Organization> GetOrganizations()
        {
           return _dbContext.Organizations.ToList();
        }
        public Organization GetOrganizationById(int id)
        {
            return _dbContext.Organizations.Where(o => o.Id == id).FirstOrDefault();
        }

        public void Remove(int organizaitonId)
        {
            var orgnization = GetOrganizationById(organizaitonId);
            _dbContext.Organizations.Remove(orgnization);
            _dbContext.SaveChanges();
        }
        public void UpdateOrganization(Organization newOrg)
        {
            _dbContext.Organizations.Update(newOrg);
            _dbContext.SaveChanges();
        }
    }
}
