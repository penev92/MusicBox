using System.Collections;
using System.Collections.Generic;
using MusicBox.Abstraction;

namespace MusicBox.Compositions
{
    public abstract class BaseComposition : IComposition
    {
        public int Tempo { get; }

        public int BeatDuration { get; }

        protected IEnumerable<IMusicSymbol> Inner;

        protected BaseComposition(int tempo)
        {
            Tempo = tempo;
            BeatDuration = (int)(60.0 / Tempo * 1000);
        }

        public virtual IEnumerator<IMusicSymbol> GetEnumerator()
        {
            return Inner.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
