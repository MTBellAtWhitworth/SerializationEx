///////////////////////////////////////////////
///Example crafted by M.Bell using Troelsen and Japikse, 2022
///Demonstrates XML serialization
///Originally developed for CS371, Jan 2019
///Updated for .NET 8 / C# 6 in Jan 2024
//////////////////////////////////////////////

using SerializableEx;
using System.Xml.Serialization; //<= Hafta add this line

namespace SaveGameState
{
    class Program
    {
        //This function inspired by and largely taken from T&J, pp. 781ff
        static void SaveAsXmlFormat<T>(T entity, string filename)
        {
            // Save entity to filename as a binary file, see p. 789 in T&J
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            using (Stream fStream =
                new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, entity);
            }
        }

        static void Main(string[] args)
        {
            //Make a player:
            Player myMazeRunner = new Player("Thomas", 10);
            SaveAsXmlFormat(myMazeRunner, "Player.xml");
        }
    }
}