using System;
using System.Threading.Tasks;
using Pistoladas.Business.User;
using Pistoladas.Data.Annotation;
using Pistoladas.Models.Entities.MethodModels.Annotation;
using Pistoladas.Models.Entities.MethodModels.User;
using AddRequest = Pistoladas.Models.Entities.MethodModels.Annotation.AddRequest;
using AddResponse = Pistoladas.Models.Entities.MethodModels.Annotation.AddResponse;
using GetByIdRequest = Pistoladas.Models.Entities.MethodModels.Annotation.GetByIdRequest;
using GetByIdResponse = Pistoladas.Models.Entities.MethodModels.Annotation.GetByIdResponse;

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
        public Task<GetByIdResponse> GetById(GetByIdRequest request)
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

        public Task<AddResponse> Add(AddRequest request)
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

        public async Task<CheckAnnotationIsValidatedResponse> CheckIfAnnotationIsValidated(CheckAnnotationIsValidatedRequest request)
        {
            try
            {
                var currentActiveUsersCount = await _userBusiness.GetActiveCount(new GetActiveCountRequest());
                var annotation = await _data.GetById(new GetByIdRequest
                {
                    AnnotationId = request.AnnotationId
                });
                var activeUsersSimpleMajority = _userBusiness.ActiveUsersSimpleMajority(currentActiveUsersCount.ActiveUsersCount);
                
                var result = new CheckAnnotationIsValidatedResponse();  

                //TODO: refactor to user the annotationvotes method
                // if (annotation.Votes >= activeUsersSimpleMajority && annotation.IsActive)
                // {
                //     result.IsValidated = true;
                //     return result;
                // }

                result.IsValidated = false;
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}