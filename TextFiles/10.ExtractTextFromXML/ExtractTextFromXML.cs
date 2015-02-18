/* Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */
using System;
using System.IO;
using System.Text;
using System.Xml;

class ExtractTextFromXML
{
    static void Main()
    {
        string path = @"..\..\test.txt";
        XmlReader reader = new XmlTextReader(path);

        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Text:
                    Console.WriteLine("{0}", reader.Value);
                    break;
            }
        }
    }
}
