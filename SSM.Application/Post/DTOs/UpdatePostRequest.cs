using Microsoft.AspNetCore.Http;

namespace SMM.Application.Posts.DTOs;

public class UpdatePostRequest
{
    public string? Content { get; set; }

    public IFormFile? Image { get; set; }
    public IFormFile? Video { get; set; }
    public bool RemoveImage { get; set; }
    public bool RemoveVideo { get; set; }
}