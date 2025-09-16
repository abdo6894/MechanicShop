namespace MechanicShop.Domain.Common.Entites;

public abstract class Entity 
{
    private readonly List<DomainEvent> _DomainEvent = [];
    public Guid Id { get; set; }
    protected Entity() { }
    protected Entity(Guid id)
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
    }

    public void AddDomainEvent(DomainEvent domainEvent)
    {
        _DomainEvent.Add(domainEvent);
    }
    public void RemoveDomainEvent(DomainEvent domainEvent)
    {
        _DomainEvent.Remove(domainEvent);
    }
        public void ClearDomainEvent()
    {
        _DomainEvent.Clear();
    }
    

} 