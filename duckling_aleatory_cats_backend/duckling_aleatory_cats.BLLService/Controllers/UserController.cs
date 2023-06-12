using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using duckling_aleatory_cats.BLL;
using duckling_aleatory_cats.MODEL;

namespace duckling_aleatory_cats.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("PostUser")]
        public ActionResult<TbUser> PostUser(TbUser user)
        {
            try
            {
                UserRepository rep = new UserRepository();
                TbUser _user = rep.Add(user);

                return _user == null ? NotFound() : Ok(user);
            }
            catch
            (Exception ex)
            {
                return StatusCode(300, ex.Message);
            }
        }

        [HttpPost("CheckLogin")]
        public ActionResult<bool> CheckLogin(TbUser user)
        {
            try
            {
                UserRepository rep = new UserRepository();
                bool res = rep.CheckLogin(user);

                return res == false ? NotFound() : Ok(res);
            }
            catch
            (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
