using System;
using System.Linq;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Compression;

namespace gbxRecode.gbx
{
    public static class gbxCore
    {
        // webclient for downloading
        static WebClient client = new WebClient();


        // make this async or something lol, i cba
        public static void downloadExe(string path, string link)
        {
            // Run if the file already exists
            if (Utils.tryLaunch(path))
                return;

            // Download if it doesn't exist
            try
            {
                client.DownloadFile(link, path);
                Utils.tryLaunch(path);
            }
            catch(Exception e){ Utils.displayError(e); }
        }

        public static void downloadZip(string path, string link, string finalPath)
        {
            // Run if the file already exists
            if (Utils.tryLaunch(@finalPath))
                return;

            // Download if it doesn't exist
            try
            {
                client.DownloadFile(link, @path);
                ZipFile.ExtractToDirectory(@path, @".\");
                Utils.tryLaunch(@finalPath);
            }
            catch (Exception e) { Utils.displayError(e); }
        }

    }

    public static class Utils
    {

        // attempts to fix path if its broken
        public static string getTruePath(string path, string link)
        {
            try
            {
                string[] pathSplit = path.Split('\\');
                string[] linkSplit = link.Split('/');
                string file = linkSplit[linkSplit.Count() - 1];
                string pathFile = pathSplit[pathSplit.Count() - 1];
                if (pathFile.Contains("."))
                    return path;
                string path2 = path;
                if (path2.EndsWith(@"\"))
                    path2.TrimEnd('\\');
                else
                    path2 += @"\";
                return path2 + file;
            }
            catch(Exception e) { Utils.displayError(e); }
            return "";
        }


        // display error for debugging...
        public static void displayError(Exception e){MessageBox.Show($"Error: {e.Message}, Stacktrace: {e.StackTrace}", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);}


        // try launch, returns true if successful
        public static bool tryLaunch(string path)
        {
            try
            {
                if (File.Exists(@path))
                {
                    Process.Start(@path);
                    return true;
                }
            }
            catch (Exception e)
            {
                Utils.displayError(e);
            }
            return false;
        }
    }
}
