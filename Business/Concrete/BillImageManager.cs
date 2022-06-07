using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;

using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillImageManager : IBillImageService
    {
      
            private static IBillImageDal billImagesDal;
            private static IAdisyonDal adisyondal;
            private IFileProcess fileProcess;

            public BillImageManager(IBillImageDal _billImageDal, IAdisyonDal _adisyondal, IFileProcess fileProcess)
            {
                billImagesDal = _billImageDal;
                adisyondal = _adisyondal;
                this.fileProcess = fileProcess;
            }

            public IResult Add(int id, IFormFile files)
            {
                IResult result = BusinessRules.Run(CheckImagesLimit(id), CheckTheCarExists(id));
                if (result != null)
                {
                    return new ErrorResult();
                }

                string FileName = Guid.NewGuid().ToString();
                BillImage billImg = new BillImage
                {
                    AdisyonId = id,
                    Date = DateTime.UtcNow,
                    ImagePath = FileName
                };
                billImagesDal.Add(billImg);
                var fileResult = fileProcess.Upload(FileName, files);
                return new SuccessResult(Messages.Add_Message(Messages.GetNameDict[typeof(BillImage)]));
            }

           

           

            #region Business rules for car Image class

            public static IResult CheckImagesLimit(int id)
            {
                return billImagesDal.GetAll(img => img.AdisyonId == id).Count() < 5 ? new Result(true) : new ErrorResult(Messages.ErrorMessage);
            }
            public static IResult CheckTheCarExists(int id)
            {
                return adisyondal.Get(id) != null ? (IResult)new Result(true) : new ErrorResult(Messages.ErrorMessage);
            }
            public static IResult CheckTheCarImageExists(int FileId)
            {
                return billImagesDal.Get(FileId) != null ? new Result(true) : new ErrorResult(Messages.ErrorMessage);
            }

        public IResult Delete(int id)
        {
            IResult result = BusinessRules.Run(CheckTheCarImageExists(FileId: id), CheckTheCarExists(id));
            if (result != null)
                return null;
            BillImage currentCar = GetById(id).Data;
            billImagesDal.Delete(currentCar);
            if (!currentCar.ImagePath.Equals("thumbnail.png")) // Delete it if current car's image is not thumbnail.
                fileProcess.Delete(currentCar.ImagePath);
            return new SuccessResult(Messages.Add_Message(Messages.GetNameDict[typeof(BillImage)]));
        }

        public IDataResult<BillImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BillImage>> GetAll()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    
}