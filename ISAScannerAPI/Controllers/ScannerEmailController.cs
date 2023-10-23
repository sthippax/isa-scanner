using ISAScannerDAL.Models;
using ISAScannerRepository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISAScannerAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ScannerEmailController : ControllerBase
    {
        private IScannerEmailInterface _IScannerEmail;
        public ScannerEmailController(IScannerEmailInterface _iScannerEmail)
        {
            _IScannerEmail = _iScannerEmail;
        }
        #region SendScannerEmailReport [Code Owner : Chenthilkumaran (17-07-2023)]
        [HttpPost("SendScannerEmailReport")]
        public async Task<IActionResult> SendScannerEmailReport(ReqScannerSendEmailReport objData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string _user = new HttpMessage().GetLogin(User.Identity.Name);

            try
            {
                object result = await _IScannerEmail.SendScannerEmailReport(objData);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new HttpMessage().GetOops());
            }

        }
        #endregion
    }
}
