﻿namespace LearningCenter.API.Shared.Domain.Services.Communication
{
    public abstract class BaseResponse<T>
    {
        protected BaseResponse (string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }
        protected BaseResponse (T resource)
        {
            Success = false;
            Resource = resource;
            Message = string.Empty;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Resource { get; set; }
    }
}
