using System;
using MusicBox.Abstraction;

namespace MusicBox.SoundAdapters
{
    public class ConsoleSoundAdapter : ISoundAdapter
    {
        public void Play(INote note, int duration)
        {
            Console.Beep((int)Math.Round(note.Frequency), duration);
        }
    }
}
