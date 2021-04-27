using System;
using Pistoladas.Data.Annotation;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;
using Pistoladas.Models.Enums;
using Xunit;

namespace Pistoladas.Tests.Data.Annotation
{
    public class AnnotationDataTests
    {
        private readonly IAnnotationData _data;
        
        public AnnotationDataTests(IAnnotationData data)
        {
            _data = data;
        }
        
        [Fact]
        public async void Add_ShouldReturnUserAddResponse()
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
        
    }
}