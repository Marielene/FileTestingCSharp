using System;
using System.Xml;
using System.Xml.Linq;

namespace IOXMLFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string value = "simple value", property = "simpl property";

			string path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			//reading xml file

			using (XmlReader reader = XmlReader.Create (path)) {

				while (reader.Read ()) {
					switch (reader.Name) {
					case "row":
						property = reader ["property"];
						value = reader.ReadInnerXml ();
						Console.WriteLine ("value="+value);
						Console.WriteLine ("property="+property+"\n");
						break;
					case "simplerow":
						//property = reader ["property"];
						value = reader.ReadInnerXml ();
						Console.WriteLine ("value="+value);
						//Console.WriteLine ("property="+property+"\n");
						break;
					}
				}
				
			}

			Console.ReadKey ();

			//Saving XML flile

		
//			using (XmlWriter writer = XmlWriter.Create (path)) {
//				
//				writer.WriteStartDocument ();
//
//				writer.WriteStartElement ("Settings");
//
//				//file contains:
//				writer.WriteStartElement ("row");
//
//				writer.WriteAttributeString ("property", property); //<row> property =" ...">value..
//
//				writer.WriteString (value); //<row> value </row>
//
//				writer.WriteEndElement();
//
//				writer.WriteEndElement ();
//
//				writer.WriteEndDocument ();
//
//
//			}
//			XDocument document = XDocument.Load (path);
//			document.Save (path);
//			System.Diagnostics.Process.Start (path);

		}
	}
}
