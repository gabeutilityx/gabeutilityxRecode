using System.Collections.Generic;

namespace gbxRecode.gbx.Program
{
    public class Category
    {
        public List<App> programs = new List<App>();
        public string name;
        public Category(string name)
        {
            this.name = name;
        }
    }
}
