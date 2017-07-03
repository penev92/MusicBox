using System;
using MusicBox.Abstraction;

namespace MusicBox.Players
{
    public class CommonPlayer : IPlayer
    {
        public ISoundAdapter SoundAdapter { get; }

        public bool IsPaused { get; set; }

        public CommonPlayer(ISoundAdapter soundAdapter)
        {
            SoundAdapter = soundAdapter;
        }

        public void Play(IComposition musicalComposition)
        {
            foreach (var symbol in musicalComposition)
            {
                var duration = musicalComposition.BeatDuration / (int) symbol.Time;
                symbol.Play(SoundAdapter, duration);
            }
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Backward()
        {
            throw new NotImplementedException();
        }
    }
}
