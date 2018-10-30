
using System.IO;
using System.Xml.Serialization;

namespace Main_Form
{
    public static class CategoryDatabaseHandling
    {
        private const string PATH = "kategorier.xml";

        public static void Serialize(CategoryList CategoryList)
        {
            var Serializer = new XmlSerializer(typeof(CategoryList));
            using (var Writer = new StreamWriter(PATH))
            {
                Serializer.Serialize(Writer, CategoryList);
            }
        }

        public static CategoryList Deserialize()
        {
            CategoryList CategoryList = new CategoryList();
            if (File.Exists(PATH))
            {
                var Serializer = new XmlSerializer(typeof(CategoryList));
                using (var Reader = new StreamReader(PATH))
                {
                    CategoryList = Serializer.Deserialize(Reader) as CategoryList;
                }
            }
            return CategoryList;
        }

    }
}
