using System;
using System.Threading.Tasks;
using Pistoladas.Business.User;
using Pistoladas.Data.Annotation;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;
using Pistoladas.Models.Entities.MethodModels.UserModel;

namespace Pistoladas.Business.Annotations.Implementations
{
    public class AnnotationBusiness : IAnnotationsBusiness
    {
        private readonly IAnnotationData _data;
        private readonly IUserBusiness _userBusiness;
        public AnnotationBusiness(IAnnotationData data, IUserBusiness userBusiness)
        {
            _data = data;
            _userBusiness = userBusiness;
        }
        public Task<AnnotationGetByIdResponse> GetById(AnnotationGetByIdRequest request)
        {
            try
            {
                return _data.GetById(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task<AnnotationAddResponse> Add(AnnotationAddRequest request)
        {
            try
            {
                return _data.Add(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CheckAnnotationIsValidatedResponse> CheckAnnotationIsValidated(CheckAnnotationIsValidatedRequest request)
        {
            try
            {
                var currentActiveUsersCount = await _userBusiness.GetActiveCount(new UsersGetActiveCountRequest());
                var annotation = await _data.GetById(new AnnotationGetByIdRequest
                {
                    AnnotationId = request.AnnotationId
                });
                var activeUsersSimpleMajority = ActiveUsersSimpleMajority(currentActiveUsersCount.ActiveUsersCount);
                
                var result = new CheckAnnotationIsValidatedResponse();  

                if (annotation.Votes >= activeUsersSimpleMajority && annotation.IsActive)
                {
                    result.IsValidated = true;
                    return result;
                }

                result.IsValidated = false;
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static decimal ActiveUsersSimpleMajority(long currentActiveUsersCount)
        {
            return (decimal) currentActiveUsersCount / 2 + 1;
        }
    }
}