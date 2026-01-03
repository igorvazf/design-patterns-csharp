using Adapter.Libs;

namespace Adapter.Adapters
{
    public class Mp3PlayerAdapter : IPlayer
    {
        public Mp3PlayerAdapter() { }

        public void Play(string file)
        {
            Mp3Player mp3Player = new(file);
            mp3Player.Run();
        }
    }
}
