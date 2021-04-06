namespace gbxRecode.gbx.Program
{
    public class App
    {
        public string name;
        public string path;
        public string link;
        public string description;
        public string finalPath;
        public Guna.UI2.WinForms.Guna2Button button;
        public AppTypes.Type type;

        public App(string name, string path, string link, string description = "An app.", AppTypes.Type type = AppTypes.Type.Exe, string finalZipPath = "")
        {
            this.name = name;
            this.path = path;
            this.link = link;
            this.description = description;
            this.type = type;
            this.finalPath = finalZipPath;
        }
    }

    public class AppTypes
    {
        public enum Type
        {
            Exe,
            Zip
        }
    }
}
