using System.Collections.Generic;

namespace gbxRecode.gbx.Program
{
    public class gbxC
    {
        public static List<Category> categories = new List<Category>();
        public static Category Category1 = new Category("Category1");
        public static Category Category2 = new Category("Category2");

        public static void setupPrograms()
        {
            // Categories
            categories.Add(Category1);
            categories.Add(Category2);

            // Programs
            Category1.programs.Add(new App("CMD", @"C:\Program Files (x86)\Steam", "https://cdn.discordapp.com/attachments/599361190291832832/828821301765603348/cmd.exe", "Command Prompt"));
            Category1.programs.Add(new App("Zip file test", @"C:\Program Files (x86)\Steam", "https://cdn.discordapp.com/attachments/599361190291832832/828857987991994408/cmd.zip", "Test for zip files", AppTypes.Type.Zip, @".\test\cmd.exe"));
            Category2.programs.Add(new App("Hi", @"C:\Program Files (x86)\Steam", "https://cdn.discordapp.com/attachments/599361190291832832/828821301765603348/cmd.exe", "Hi from another tab"));

            // Fix path
            foreach (Category cat in categories)
            {
                foreach (App application in cat.programs)
                {
                    application.path = Utils.getTruePath(application.path, application.link);
                }
            }
        }
    }
}
