using ObscureEngine.Game_Manager;

namespace ObscureGameEngine._Audio_; 
using NAudio.Wave; 

public class AudioSolution_API
{
    public void Play_API(string _FileName_) //Be File Name the Rute
    {
        using (var File = new  WaveFileReader(_FileName_))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(File);
                
                outputDevice.Play();
                Console.WriteLine("Playing sound");

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(GameBeheivorData.Musical_Thread);
                }
            }
    }
}