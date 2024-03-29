﻿using AutoMapper;
using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Resources;

namespace LearningCenter.API.Learning.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveTutorialResource, Tutorial>();
        }
    }
}
