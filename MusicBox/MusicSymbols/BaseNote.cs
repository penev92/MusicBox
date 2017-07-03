using System;
using MusicBox.Abstraction;

namespace MusicBox.MusicSymbols
{
    public class BaseNote : INote
    {
        protected int FrequencyMultiplier;

        public virtual double Frequency { get; }

        public Time Time { get; set; }

        public  BaseNote(string definition, Time time)
        {
            FrequencyMultiplier = CalculateNote(definition);
            Frequency = Math.Pow(2, FrequencyMultiplier / 12.0d) * 440.0d;
            Time = time;
        }

        public void Play(ISoundAdapter soundAdapter, int duration)
        {
            soundAdapter.Play(this, duration);
        }

        private int CalculateNote(string noteName)
        {
            try
            {
                int finalOffset = GetOctaveOffset(noteName);

                if (noteName.Length == 2)
                {
                    return finalOffset;
                }
                else if (noteName.Contains("Sharp"))
                {
                    finalOffset += 1;
                }
                else if (noteName.Contains("Flat"))
                {
                    finalOffset -= 1;
                }
                return finalOffset;

            }
            catch (Exception ex)
            {
                throw new Exception("Error during note calculation");
            }
        }

        private int GetOctaveOffset(string noteName)
        {
            int offset;
            Octave note = (Octave)Enum.Parse(typeof(Octave), noteName[0].ToString());
            char octave = noteName[1];
            offset = GetNoteOffset(note);

            int octaveNumeric;
            try
            {
                octaveNumeric = (int)Char.GetNumericValue(octave);
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid format.");
            }

            int sign = GetSign(note, octave);

            int result;

            if (note == Octave.A || note == Octave.B)
            {
                result = sign * ((12 * Math.Abs(4 - octaveNumeric)) + (sign * offset));
            }
            else
            {
                result = sign * ((12 * Math.Abs(4 - octaveNumeric)) + (sign * (-12 + offset)));
            }

            return result;
        }

        private int GetNoteOffset(Octave note)
        {
            switch (note)
            {
                case Octave.A:
                    return 0;
                case Octave.B:
                    return 2;
                case Octave.C:
                    return 3;
                case Octave.D:
                    return 5;
                case Octave.E:
                    return 7;
                case Octave.F:
                    return 8;
                case Octave.G:
                    return 10;
                default:
                    throw new Exception("Invalid note");
            }
        }

        private int GetSign(Octave note, char octave)
        {
            if (note < Octave.A && octave <= 4)
            {
                return -1;
            }
            return 1;
        }

        private enum Octave
        {
            C, D, E, F, G, A, B
        }
    }
}
