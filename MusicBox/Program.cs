using MusicBox.Compositions;
using MusicBox.Players;
using MusicBox.SoundAdapters;

namespace MusicBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundAdapter = new ConsoleSoundAdapter();
            var player = new CommonPlayer(soundAdapter);
            player.Play(new SimpleLALALALAComposition());
        }
    }
}
