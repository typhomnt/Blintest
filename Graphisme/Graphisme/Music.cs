using System.Runtime.InteropServices;
using System.Text;

namespace Graphisme
{
    class Music
    {
        // Importer la dll winmn.dll qui permet de lire les fichier mp3
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
            int uReturnLength, int hwndCallback);

        //To open a file to our application
        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMusic";
            mciSendString(command, null, 0, 0);
        }

        //To play the file
        public void play()
        {
            string command = "play MyMusic";
            mciSendString(command, null, 0, 0);
        }

        //To pause the file
        public void pause()
        {
            string command = "stop MyMusic";
            mciSendString(command, null, 0, 0);

        }

        //To stop the file
        public void stop()
        {
            string command = "close MyMusic";
            mciSendString(command, null, 0, 0);
        }

    }
}