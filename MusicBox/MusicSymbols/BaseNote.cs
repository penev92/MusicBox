using System;
using MusicBox.Abstraction;

namespace MusicBox.MusicSymbols
{
    public abstract class BaseNote : INote
    {
        protected int FrequencyMultiplier;

        public virtual double Frequency { get; }

        public Time Time { get; set; }

        protected BaseNote(int frequencyMultiplier, Time time)
        {
            FrequencyMultiplier = frequencyMultiplier;
            Frequency = Math.Pow(2, FrequencyMultiplier / 12.0d) * 440.0d;
            Time = time;
        }

        public void Play(ISoundAdapter soundAdapter, int duration)
        {
            soundAdapter.Play(this, duration);
        }
    }
}
