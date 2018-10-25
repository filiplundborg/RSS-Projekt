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

        public static void Serialize(KategoriList kategoriList)
        {
            var serializer = new XmlSerializer(typeof(KategoriList));
            using (var writer = new StreamWriter(PATH))
            {
                serializer.Serialize(writer, kategoriList);
            }
        }

        public static KategoriList Deserialize()
        {
            KategoriList kategoriList = new KategoriList();
            if (File.Exists(PATH))
            {
                var serializer = new XmlSerializer(typeof(KategoriList));
                using (var reader = new StreamReader(PATH))
                {
                    kategoriList = serializer.Deserialize(reader) as KategoriList;
                }
            }
            return kategoriList;
        }

    }
}
