using System;
using System.Collections.Generic;
using System.Xml;

namespace Homework
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Item> item = new List<Item>();

      string path = Console.ReadLine();

      XmlDocument document = new XmlDocument();
      document.Load(path);


    }
  }
}
