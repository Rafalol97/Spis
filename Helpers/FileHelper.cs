using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Spis.Models;
using Spis.ViewModels;

namespace Spis.Helpers
{
    public static class FileHelper
    {
        public static String homeFolderPath { get;} = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\RejestrRC\\";

        public static String mainFileName { get; } = "data.sps";

        public static String getFilePath(string filename)
        {
            return homeFolderPath + filename;
        }
        public static void ConfigurePaths()
        {
            if (!Directory.Exists(homeFolderPath))
            {
                Directory.CreateDirectory(homeFolderPath);
            }
        }
        public static List<EventModel> GetEventsFromFile(string path)
        {
           List<EventModel> eventModels = new List<EventModel>();
           if (File.Exists(path))
           {
               StreamReader stream= new StreamReader(path);
               string line;
               while ((line=stream.ReadLine())!=null)
               {
                   string[] eventElements = line.Split(',');
                   if(eventElements.Length<5) throw new Exception("File corrupted");
                   eventModels.Add(GetEventModelFromString(eventElements));
               }
           }

           return eventModels;
        }

        public static EventModel GetEventById(int id,string path)
        {
            if (File.Exists(path))
            {
                StreamReader stream = new StreamReader(path);
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] eventElements = line.Split(',');
                    if (Int32.Parse(eventElements[0]) == id)
                    {
                        return GetEventModelFromString(eventElements);
                    }
                }
            }

            return null;
        }

      
        public static String AddNewEvent(EventModel eventModel,string path)
        {
            if (File.Exists(path))
            {
                throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }
        public static EventModel RemoveModel(int id)
        {
            throw new NotImplementedException();
        }
        private static EventModel GetEventModelFromString(string[] eventElements)
        {
            if (eventElements.Length < 5) return null;
            return new EventModel()
            {
                id = Int32.Parse(eventElements[0]),
                Description = eventElements[1],
                endTime = DateTime.Parse(eventElements[2]),
                startTime = DateTime.Parse(eventElements[3]),
                severity = Int32.Parse(eventElements[4])

            };
        }

    }
}
