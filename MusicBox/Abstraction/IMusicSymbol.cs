namespace MusicBox.Abstraction
{
    public interface IMusicSymbol
    {
        Time Time { get; set; }

        void Play(ISoundAdapter soundAdapter, int duration);
    }
}
