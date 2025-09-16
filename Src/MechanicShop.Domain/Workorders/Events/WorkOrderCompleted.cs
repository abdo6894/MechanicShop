using MechanicShop.Domain.Common;
using MechanicShop.Domain.Common.Entites;

namespace MechanicShop.Domain.Workorders.Events;

public sealed class WorkOrderCompleted : DomainEvent
{
    public Guid WorkOrderId { get; set; }
}