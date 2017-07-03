namespace MusicBox.Abstraction
{
    public interface IPlayer
    {
        ISoundAdapter SoundAdapter { get; }

        bool IsPaused { get; set; }

        void Play(IComposition musicalComposition);

        void Forward();

        void Backward();
    }
}
