using AutoMapper;
using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResponse>();
            CreateMap<Tutorial, TutorialResponse>();
        }
    }
}
