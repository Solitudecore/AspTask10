using Microsoft.AspNetCore.Http;

namespace SMM.Application.Posts.DTOs;

public class CreatePostRequest
{
    public string? Content { get; set; }

    public IFormFile? Image { get; set; }
    public IFormFile? Video { get; set; }

}