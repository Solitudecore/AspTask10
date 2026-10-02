using SMM.Domain.Enums;

namespace SMM.Application.Friends.DTOs;

public class FriendRequestResponse
{
    public Guid Id { get; set; }

    public Guid SenderId { get; set; }

    public string SenderFirstName { get; set; } = null!;

    public string SenderLastName { get; set; } = null!;

    public string SenderUserName { get; set; } = null!;

    public string? SenderProfileImageUrl { get; set; }

    public Guid ReceiverId { get; set; }

    public FriendRequestStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }
}