namespace MusicBox.Abstraction
{
    public interface INote : IMusicSymbol
    {
        double Frequency { get; }
    }
}
