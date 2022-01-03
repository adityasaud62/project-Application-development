using System;
using System.IO;

namespace WindowsFormsApp1
{
    class Utility
    {
        private static string _filepath = "PriceRateDetail.txt";

        public static string Write(string data)
        {
            if (!File.Exists(_filepath))
            {
                using (File.Create(_filepath)) ;
            }
            using (StreamWriter outputfile = new StreamWriter(_filepath))
            {
                outputfile.WriteLine(data);
                outputfile.Close();
            }
            return "Done.";
        }



        public static string Read()
        {
            string json;
            if (File.Exists(_filepath))
            {
                return json = File.ReadAllText(_filepath);

            }
            else
            {
                return json = null;
            }
        }




        public static string Delete(string data)
        {
            if (!File.Exists(_filepath))
            {
                using (File.Create(_filepath)) ;
            }
            using (StreamWriter outputfile = new StreamWriter(_filepath))
            {
                outputfile.WriteLine(data);
                outputfile.Close();

            }
            return "Deleted";
        }



        public static string Reset()
        {
            if (File.Exists(_filepath))
            {
                try
                {
                    File.Delete(_filepath);
                    using (File.Create(_filepath)) ;
                }
                catch (Exception ex) { }

            }
            return null;
        }

    }

    class Utility2
    {
        private static string _filepath = "Visitor_json.txt";

        public static string Write(string data)
        {
            if (!File.Exists(_filepath))
            {
                using (File.Create(_filepath)) ;
            }
            using (StreamWriter outputfile = new StreamWriter(_filepath))
            {
                outputfile.WriteLine(data);
                outputfile.Close();

            }
            return "Successful.";
        }

        public static string Reset()
        {
            if (File.Exists(_filepath))
            {
                try
                {
                    File.Delete(_filepath);
                    using (File.Create(_filepath)) ;
                }
                catch (Exception ex) { }

            }
            return null;
        }


        internal static string Read()
        {
            string json;
            if (File.Exists(_filepath))
            {


                return json = File.ReadAllText(_filepath);

            }
            else
            {
                return json = null;
            }
        }

    }
}
