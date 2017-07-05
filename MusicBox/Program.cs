using System;
using MusicBox.Compositions;
using MusicBox.Players;
using MusicBox.SoundAdapters;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace MusicBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //var soundAdapter = new ConsoleSoundAdapter();
            //var player = new CommonPlayer(soundAdapter);
            //player.Play(new SimpleLALALALAComposition());

            BassFx.LoadMe();
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                BASSError errorCode;
                // Create a stream from a file
                var streamHandle = Bass.BASS_StreamCreateFile("Resources\\A4.wav", 0, 0, BASSFlag.BASS_DEFAULT);
                if (streamHandle == 0)
                {
                    Console.WriteLine("Stream handle error.");
                    errorCode = Bass.BASS_ErrorGetCode();
                    Console.WriteLine(errorCode);
                }

                BASS_BFX_PITCHSHIFT pitch = new BASS_BFX_PITCHSHIFT();
                // Add an FX effect to the stream
                var fxHandle = Bass.BASS_ChannelSetFX(streamHandle, BASSFXType.BASS_FX_BFX_PITCHSHIFT, 0);
                if (fxHandle == 0)
                {
                    Console.WriteLine("FX handle error.");
                    errorCode = Bass.BASS_ErrorGetCode();
                    Console.WriteLine(errorCode);
                }
                // Get the current effect parameters
                if (!Bass.BASS_FXGetParameters(fxHandle, pitch))
                {
                    Console.WriteLine("FX get error.");
                    errorCode = Bass.BASS_ErrorGetCode();
                    Console.WriteLine(errorCode);
                }
                // fucken magic
                pitch.fPitchShift = 1 + 1/12f;
                // Set the parameters with only the pitch changed
                if (!Bass.BASS_FXSetParameters(fxHandle, pitch))
                {
                    Console.WriteLine("FX set error.");
                    errorCode = Bass.BASS_ErrorGetCode();
                    Console.WriteLine(errorCode);
                }

                // Play the channel
                if (!Bass.BASS_ChannelPlay(streamHandle, false))
                {
                    Console.WriteLine("Play error.");
                    errorCode = Bass.BASS_ErrorGetCode();
                    Console.WriteLine(errorCode);
                }

                // Wait for a key so we don't terminate the playing prematurely
                // TODO: calculate termination based on the compositions's length
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(false);

                // Release
                Bass.BASS_Free();
            }
        }
    }
}
