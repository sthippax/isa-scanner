using ISAScannerDAL.DataAccess;
using ISAScannerDAL.Models;
using ISAScannerRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAScannerRepository.Repository
{
    public class ScannerEmailRepository : IScannerEmailInterface
    {
        #region SendScannerEmailReport [Code Owner : Chenthilkumaran (17-07-2023)]
        public Task<object> SendScannerEmailReport(ReqScannerSendEmailReport objData)
        {
            try
            {
                object response = new ScannerEmailDAL().SendScannerEmailReport(objData);
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

    }
}
