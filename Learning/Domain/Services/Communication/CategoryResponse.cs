using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Shared.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse<Category>
    {
        public CategoryResponse(string message) : base(message)
        {
        }

        public CategoryResponse(Category resource) : base(resource)
        {
        }
    }
}
