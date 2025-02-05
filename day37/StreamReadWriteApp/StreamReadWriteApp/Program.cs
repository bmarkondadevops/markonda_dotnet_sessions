


namespace StreamReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateHTMLFile();

            ReadHTMLFile();
        }

        private static void ReadHTMLFile()
        {

            var fs = new FileStream("C:\\temp\\welcome.html", FileMode.Open);

            var sf =new StreamReader(fs);
           //var html=sf.ReadToEnd();
            //Console.WriteLine(html);


            while (true)
            {
                var line = sf.ReadLine();
                if (line == null) break;
            }
            sf.Close();
            fs.Close(); 

        }

        private static void GenerateHTMLFile()
        {
            var myhtmlbody = "$<html>" +
                 $"<body>" +
                 $"<h1>Welcome to file <h1>" +
                 $"</body>" +
                 $"</html>";
            //Traditional approach: we need to close manually
            /*
            FileStream fs = new("C:\\temp\\welcome.html",FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(myhtmlbody);
            sw.Close();
            fs.close();*/

            //Modern approach
            using (FileStream fs = new("C:\\temp\\welcome.html", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
                sw.WriteLine(myhtmlbody);
            //sw.Close(); 
        }
    }
}
