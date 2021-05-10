using System;
using Pistoladas.Data.AnnotationVote;
using Pistoladas.Models.Entities.MethodModels.AnnotationVote;
using Xunit;

namespace Pistoladas.Tests.Data.AnnotationVotes
{
    public class Tests
    {
        private readonly IAnnotationVoteData _data;
        
        public Tests(IAnnotationVoteData data)
        {
            _data = data;
        }
        
        [Fact]
        public async void Add_ShouldReturnAnnotationVoteAddResponse()
        {
            var result = await _data.Add(new AddRequest(){
                AnnotationId = Guid.Parse("C1E1916E-F3A6-EB11-B22B-001A7DDA7110"),
                VotingUserId = Guid.Parse("7455B728-1CA6-EB11-B22B-001A7DDA7110")
            });
            
            Assert.IsType<AddResponse>(result);
        }
    }
}