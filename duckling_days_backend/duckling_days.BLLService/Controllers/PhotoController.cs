using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using duckling_days.BLL;
using duckling_days.MODEL;

namespace duckling_days.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        [HttpGet(Name = "GetPhoto")]

        public ActionResult<List<TbPhoto>> GetTbPhoto()
        {
            try
            {
                List<TbPhoto> list = TbPhotoRepository.GetAll();

                if (list !=null )
                {
                    return Ok(list);
                }

                return NotFound();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        } 


    }
}
