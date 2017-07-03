using System.Threading;
using MusicBox.Abstraction;

namespace MusicBox.MusicSymbols
{
    public class Pause : IMusicSymbol
    {
        public Time Time { get; set; }

        public Pause(Time time)
        {
            Time = time;
        }

        public void Play(ISoundAdapter soundAdapter, int duration)
        {
            Thread.Sleep(duration);
        }
    }
}
