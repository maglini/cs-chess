using Logic.Infrastructure.EnumTypes;

namespace Logic.Infrastructure.Basis;

public class GameOptions
{
    public DirectionType WhitePlayerDirectionType { get; protected set; } = DirectionType.Top;
    public DirectionType BlackPlayerDirectionType { get; protected set; } = DirectionType.Bottom;
}