using System.Collections.Generic;
using System.Web.Http;
using MvcApplication1.Models;
using MvcApplication1.DAL;
using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;

namespace MvcApplication1.Controllers
{
    public class CarWashingController : ApiController
    {
        static readonly IRepository<CarWashingSchedule> repository = new EntityRepository<CarWashingSchedule>(new CarWashContext(), true);

        //Get All the
        [HttpPost]
        public IEnumerable<CarWashingSchedule> SearchCarWashings(SearchCarWashingSchedule item)
        {
            return repository.Find(x => (item.WashManId == -1 || x.WashManId == item.WashManId) &&
                               (string.IsNullOrEmpty(item.CarNumber) || x.CarNumber.Contains(item.CarNumber)) &&
                               (item.WashingType == WashingType.All || item.WashingType == null || x.WashingType == item.WashingType) &&
                               (!item.IsMonth || (item.IsMonth && SqlFunctions.DatePart("month", x.BookedTime) == item.Month)) &&
                               (!item.IsYear || (item.IsYear && SqlFunctions.DatePart("year", x.BookedTime) == item.Year)) &&
                               (!item.IsDate || (item.IsDate && EntityFunctions.TruncateTime(x.BookedTime) == EntityFunctions.TruncateTime(item.BookedTime.Date))));
        }

        [HttpGet]
        //Get All the CarWashings
        public IEnumerable<CarWashingSchedule> GetAllCarWashings()
        {
            return repository.FindAll();
        }


        //Add a CarWashing
        [HttpPost]
        public CarWashingSchedule PostCarWashing(CarWashingSchedule item)
        {
            return repository.Add(item);
        }

        //Update a CarWashing
        [HttpPut]
        public IEnumerable<CarWashingSchedule> PutCarWashing(int id, CarWashingSchedule carWashing)
        {
            carWashing.Id = id;
            if (id == 0 || carWashing == null)
                return null;
            if (repository.Update(carWashing))
            {
                return repository.FindAll();
            }
            else
            {
                return null;
            }
        }

        //Delete a CarWashing
        [HttpDelete]
        public bool DeleteCarWashing(int id)
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