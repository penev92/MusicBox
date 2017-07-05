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
                new BaseNote("A4", Time.Whole),
                new BaseNote("A4Sharp", Time.Whole),
                new BaseNote("B4", Time.Whole),
                new BaseNote("C5", Time.Whole),
                new BaseNote("C5Sharp", Time.Whole),
                new BaseNote("D5", Time.Whole),
                new BaseNote("D5Sharp", Time.Whole),
                new BaseNote("E5", Time.Whole),
                new BaseNote("F5", Time.Whole),
                new BaseNote("F5Sharp", Time.Whole),
                new BaseNote("G5", Time.Whole),
                new BaseNote("G5Sharp", Time.Whole),
                new BaseNote("A5", Time.Whole),
                new BaseNote("A5Flat", Time.Whole),
                new BaseNote("G5", Time.Whole),
                new BaseNote("G5Flat", Time.Whole),
                new BaseNote("F5", Time.Whole),
                new BaseNote("E5", Time.Whole),
                new BaseNote("E5Flat", Time.Whole),
                new BaseNote("D5", Time.Whole),
                new BaseNote("D5Flat", Time.Whole),
                new BaseNote("C5", Time.Whole),
                new BaseNote("B4", Time.Whole),
                new BaseNote("B4Flat", Time.Whole),
                new BaseNote("A4", Time.Whole)
            };
        }
    }
}
