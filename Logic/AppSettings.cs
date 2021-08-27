using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public class AppSettings
    {
        private static readonly string sr_FileLocation = @"C:\Users\Public\FBSettings.xml";

        public string LastAccessToken 
        { 
            get;
            set;
        }

        public AppSettings()
        {
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings userSetting = new AppSettings();

            if (File.Exists(sr_FileLocation))
            {
                using (Stream stream = new FileStream(sr_FileLocation, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    userSetting = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return userSetting;
        }

        public void SaveToFile()
        {
            if (File.Exists(sr_FileLocation) == false)
            {
                Stream stream = new FileStream(sr_FileLocation, FileMode.Create);
                stream.Dispose();
            }

            using (Stream stream = new FileStream(sr_FileLocation, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
