using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Main_Form
{
    public static class KategoriDatabaseHandling
    {
        private const string PATH = "kategorier.xml";

        public static void Serialize(CategoryList kategoriList)
        {
            var serializer = new XmlSerializer(typeof(CategoryList));
            using (var writer = new StreamWriter(PATH))
            {
                serializer.Serialize(writer, kategoriList);
            }
        }

        public static CategoryList Deserialize()
        {
            CategoryList kategoriList = new CategoryList();
            if (File.Exists(PATH))
            {
                var serializer = new XmlSerializer(typeof(CategoryList));
                using (var reader = new StreamReader(PATH))
                {
                    kategoriList = serializer.Deserialize(reader) as CategoryList;
                }
            }
            return kategoriList;
        }

    }
}
