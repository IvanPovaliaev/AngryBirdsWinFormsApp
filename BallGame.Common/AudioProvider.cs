using NAudio.Wave;
using System.Threading.Tasks;

namespace BallGame.Common
{
    public static class AudioProvider
    {
        public async static Task PlaySoundAsync(string audiofilePath, int soundVolume)
        {
            await Task.Run(() =>
            {
                var player = new WaveOutEvent();
                var audioFileReader = new AudioFileReader(audiofilePath);
                player.Init(audioFileReader);
                player.Volume = soundVolume / 100f;

                player.PlaybackStopped += (sender, e) =>
                {
                    player.Dispose();
                    audioFileReader.Dispose();
                };

                player.Play();
            });
        }
    }
}
