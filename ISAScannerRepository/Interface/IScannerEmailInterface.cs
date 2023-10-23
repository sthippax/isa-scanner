using ISAScannerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAScannerRepository.Interface
{
    public interface IScannerEmailInterface
    {
        Task<object> SendScannerEmailReport(ReqScannerSendEmailReport objData);
    }
}
