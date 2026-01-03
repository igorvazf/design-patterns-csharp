using Adapter.Adapters;

string file = "musica.mp3";

var file_parte = file.Split('.');

IPlayer player;

switch (file_parte[1])
{
    case "mp3":
        {
            player = new Mp3PlayerAdapter();
            player.Play(file);
            break;
        }
    case "mp4":
        {
            player = new Mp4PlayerAdapter();
            player.Play(file);
            break;
        }
    default:
        {
            Console.WriteLine("Arquivo incompatível.");
            break;
        }
}