namespace MusicBox.Abstraction
{
    public interface ISoundAdapter
    {
        void Play(INote note, int duration);
    }
}
