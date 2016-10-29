using System.Collections.Generic;
using System.Web.Http;
using MvcApplication1.Models;
using MvcApplication1.DAL;

namespace MvcApplication1.Controllers
{
    public class WashManController : ApiController
    {
        static readonly IRepository<WashMan> repository = new EntityRepository<WashMan>(new CarWashContext(),false);

        //Get All the WashMans
        public IEnumerable<WashMan> GetAllWashMans()
        {
            return repository.FindAll();
        }

        //Add a WashMan
        public WashMan PostWashMan(WashMan item)
        {
            return repository.Add(item);
        }

        //Update a WashMan
        public IEnumerable<WashMan> PutWashMan(int id, WashMan WashMan)
        {
            WashMan.Id = id;
            if (repository.Update(WashMan))
            {
                return repository.FindAll();
            }
            else
            {
                return null;
            }
        }

        //Delete a WashMan
        public bool DeleteWashMan(int id)
        {
            if (repository.Remove(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}