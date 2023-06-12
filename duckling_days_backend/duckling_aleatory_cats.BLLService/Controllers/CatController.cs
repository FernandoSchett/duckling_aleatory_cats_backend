using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using duckling_aleatory_cats.BLLService;
using duckling_aleatory_cats.MODEL;
using duckling_aleatory_cats.BLL;
using System.Text.Json;

namespace duckling_aleatory_cats.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {

        [HttpPost("PostCat")]
        public ActionResult<TbCat> PostCat([FromBody] JsonElement requestData)
        {
            try
            {
                CatRepository rep = new CatRepository();
                TbCat cat = JsonSerializer.Deserialize<TbCat>(requestData.GetProperty("cat").GetRawText());
                TbUser user = JsonSerializer.Deserialize<TbUser>(requestData.GetProperty("user").GetRawText());

                TbCat _cat = rep.AddCat(cat);

                _cat = rep.AddUserCat(user, cat);


                return _cat == null ? NotFound() : Ok(_cat);
            }
            catch (Exception ex)
            {
                return StatusCode(300, ex.Message);
            }
        }

        [HttpGet("GetRandCat")]
        public ActionResult<string> GetRandCat()
        {
            try
            {
                CatRepository rep = new CatRepository();
                var catImageUrl = CatRepository.GetCatImageUrl().Result;

                return catImageUrl == null ? NotFound() : Ok(catImageUrl);
            }
            catch
            (Exception ex)
            {
                return StatusCode(300, ex.Message);
            }
        }

        [HttpGet("{id}",Name = "GetCatsFromUser")]

        public ActionResult<List<TbCat>> GetCatsFromUser(int id)
        {
            try
            {
                CatRepository rep = new CatRepository();
                List<TbCat> _cats = rep.GetCatsFromUser(id);
                return _cats == null ? NotFound() : Ok(_cats);
            }
            catch
            (Exception ex)
            {
                return StatusCode(300, ex.Message);
            }
        }
    }
}
