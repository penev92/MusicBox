using MusicBox.MusicSymbols;
using MusicBox.MusicSymbols.Notes.TwelfthRootOfTwoChromaticScale;

namespace MusicBox.Compositions
{
    public class SimpleLALALALAComposition : BaseComposition
    {
        public SimpleLALALALAComposition() : base(120)
        {
            Inner = new BaseNote[]
            {
                new A4(Time.Whole),
                new A4(Time.Whole),
                new A4(Time.Half),
                new A4(Time.Whole),
                new A4(Time.Half),
                new A4(Time.Half),
                new A4(Time.Half),
                new A4(Time.Half),
                new A4(Time.Octa),
                new A4(Time.Octa),
                new A4(Time.Octa),
                new A4(Time.Octa),
                new A4(Time.Whole),
                new A4(Time.Half),
                new A4(Time.Sixtheenth),
                new A4(Time.Sixtheenth),
                new A4(Time.Sixtheenth),
                new A4(Time.Sixtheenth),
                new A4(Time.Sixtheenth),
                new A4(Time.Sixtheenth),
                new D(Time.Whole), 
                new D(Time.Whole), 
                new D(Time.Whole),
                new F5(Time.Half), 
                new F5(Time.Half), 
                new F5(Time.Half), 
                new F5(Time.Octa), 
            };
        }
    }
}
