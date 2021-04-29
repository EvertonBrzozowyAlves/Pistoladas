using System;
using Pistoladas.Business.Annotations;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;
using Xunit;

namespace Pistoladas.Tests.Business.Annotation
{
    public class Tests
    {
        private readonly IAnnotationsBusiness _business;
        
        public Tests(IAnnotationsBusiness business)
        {
            _business = business;
        }
        
        [Theory]
        [InlineData("C1E1916E-F3A6-EB11-B22B-001A7DDA7110")]
        public async void CheckAnnotationIsValidated_ShouldReturnCheckAnnotationIsValidatedResponse(Guid annotationId)
        {
            var result = await _business.CheckAnnotationIsValidated(new CheckAnnotationIsValidatedRequest
            {
                AnnotationId = annotationId
            });
            
            Assert.IsType<CheckAnnotationIsValidatedResponse>(result);
        }
    }
}