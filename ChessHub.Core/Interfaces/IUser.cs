namespace ChessHub.Core.Interfaces;

public interface IUser : IPlayer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
}
