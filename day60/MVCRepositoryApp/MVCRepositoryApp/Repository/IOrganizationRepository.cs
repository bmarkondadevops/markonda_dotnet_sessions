using MVCRepositoryApp.Domain;

namespace MVCRepositoryApp.Repository
{
    public interface IOrganizationRepository
    {
        void AddOrganization(Organization organisation);
        List<Organization> GetOrganizations();

        int Count();
        Organization GetOrganizationById(int id);
        void UpdateOrganization(Organization newOrg);
        void Remove(int organizaitonId);
    }
}
