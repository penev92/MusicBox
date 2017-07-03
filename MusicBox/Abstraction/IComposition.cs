using System.Collections.Generic;

namespace MusicBox.Abstraction
{
    public interface IComposition : IEnumerable<IMusicSymbol>
    {
        int Tempo { get; }

        int BeatDuration { get; }
    }
}
