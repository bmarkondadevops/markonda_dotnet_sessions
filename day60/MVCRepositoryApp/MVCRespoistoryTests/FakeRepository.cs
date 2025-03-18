using MVCRepositoryApp.Domain;
using MVCRepositoryApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRespoistoryTests
{
    public class FakeRepository : IOrganizationRepository
    {
        public void AddOrganization(Organization organisation)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return 10;
        }

        public Organization GetOrganizationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Organization> GetOrganizations()
        {
            throw new NotImplementedException();
        }

        public void Remove(int organizaitonId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrganization(Organization newOrg)
        {
            throw new NotImplementedException();
        }
    }
}
