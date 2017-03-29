using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Tpinfo3
{
  class Program
  {
    static void Main(string[] args)
    {

      //Font defintion file
      string fileName = @"FontDefinitions.txt";
      
      //DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
      string dir = Directory.GetCurrentDirectory();
      
      string path = dir + "/" + fileName; 
      System.Console.WriteLine(path);
      System.Console.WriteLine(Directory.GetCurrentDirectory());

      if (!File.Exists(path))
      {
        Console.WriteLine("file does not exists ");
        System.Environment.Exit(0);
      }

      Font f = FontUtilities.ParseFonTtextFile(path);      

      LCD lcd = new LCD(128, 24);
                  
      
      lcd.Clear();
      
      
      lcd.DrawText(f, "Nokia 3310 is a beatuful phone", 0, 0);
      lcd.Display();

    }
  }
  
}
