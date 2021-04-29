using System;
using Pistoladas.Data.Annotation;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;
using Pistoladas.Models.Enums;
using Xunit;

namespace Pistoladas.Tests.Data.Annotation
{
    public class Tests
    {
        private readonly IAnnotationData _data;
        
        public Tests(IAnnotationData data)
        {
            _data = data;
        }
        
        [Fact]
        public async void Add_ShouldReturnAnnotationAddResponse()
        {
            var result = await _data.Add(new AnnotationAddRequest
            {
                Description = "simply testing new insert",
                AnnotationLevel = AnnotationLevelEnum.Easy,
                AccuserUserId = Guid.Parse("AC60EFB7-1AA6-EB11-B22B-001A7DDA7111"),
                VictimUserId = Guid.Parse("AC60EFB7-1AA6-EB11-B22B-001A7DDA7110"),
            });
            
            Assert.IsType<AnnotationAddResponse>(result);
        }
        
        [Theory]
        [InlineData("C1E1916E-F3A6-EB11-B22B-001A7DDA7110")]
        public async void GetById_ShouldReturnAnnotationGetByIdResponse(Guid annotationId)
        {
            var result = await _data.GetById(new AnnotationGetByIdRequest()
            {
                AnnotationId = annotationId
            });
            
            Assert.IsType<AnnotationGetByIdResponse>(result);
        }
        
    }
}