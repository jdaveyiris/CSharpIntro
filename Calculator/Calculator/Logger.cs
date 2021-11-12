using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class Logger
{
        public static async Task LogExe()
        {
            string path = @"C:\Users\Jim.Davey\Work\C#Training\CSharpIntro\Calculator\Log.txt";

        //using (StreamWriter sw = File.WriteAllText(string path, string.Empty))
        //File.AppendAllText(string path, string )
      

        //await File.WriteAllLinesAsync(path, either date or number output, default);
        //Bit beyond me at this point. Ideally I would have LogExe take the argument of 
        //(class.method) so that I can pass that into the File.WriteAllLinesAsync. 
        //Just not sure how to go about that or if it would even work. 

    }
    
}
