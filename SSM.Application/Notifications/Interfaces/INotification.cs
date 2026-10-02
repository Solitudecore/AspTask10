using SMM.Application.Notifications.DTOs;
using SMM.Domain.Enums;

namespace SMM.Application.Notifications.Interfaces;

public interface INotificationService
{
    Task<NotificationResponse> CreateAsync(
        Guid userId,
        Guid? actorUserId,
        NotificationType type,
        string message,
        Guid? postId = null,
        Guid? friendRequestId = null,
        Guid? messageId = null,
        CancellationToken cancellationToken = default
    );
}