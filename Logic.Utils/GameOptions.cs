using Logic.Utils.EnumTypes;
namespace Logic.Utils;

public class GameOptions
{
    public DirectionType WhitePlayerDirectionType { get; protected set; } = DirectionType.Top;
    public DirectionType BlackPlayerDirectionType { get; protected set; } = DirectionType.Bottom;
}