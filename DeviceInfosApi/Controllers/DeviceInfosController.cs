using Microsoft.AspNetCore.Mvc;

namespace DeviceInfosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceInfosController : ControllerBase
    {
        private readonly DeviceInfosContext _db;
        public DeviceInfosController(DeviceInfosContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult AddDeviceInfos(DeviceInfos infos)
        {
            _db.Add(infos);

            _db.SaveChanges();

            return CreatedAtAction(nameof(AddDeviceInfos), infos);
        }

        [HttpGet]
        public IActionResult GetDeviceInfos(string id)
        {
            DeviceInfos infosfromDb = _db.DevicesInfos.SingleOrDefault<DeviceInfos>(i => i.Id == id);

            if (infosfromDb == null)
            {
                return NotFound();
            }

            return Ok(infosfromDb);
        }

        [HttpGet]
        [Route("GetAllDeviceInfos")]
        public IActionResult GetAllDeviceInfos()
        {
            var allDeviceInfos = _db.DevicesInfos.ToList();

            if (allDeviceInfos.Count == 0)
            {
                return Ok("No Infos available");
            }

            return Ok(allDeviceInfos);
        }

        [HttpDelete]
        public IActionResult DeleteDeviceInfos(string id)
        {
            DeviceInfos infosfromDb = _db.DevicesInfos.SingleOrDefault<DeviceInfos>(i => i.Id == id);

            if (infosfromDb == null)
            {
                return NotFound();
            }
            _db.Remove(infosfromDb);

            _db.SaveChanges();

            return Ok("Deleted Successfully");
        }
    }
}
