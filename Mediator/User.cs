using Mediator;

public abstract class User(string name)
{
    public string Name { get; protected set; } = name;
    
    protected IChatMediator _mediator = default!;

    public void SetMediator(IChatMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message, string senderName);
}