using System;
using System.Xml.Serialization;

namespace MonoDevelopTouchCells
{

	public class Item
	{
		
		public string Description { get; set; }
		public string Title { get; set; }
		
		public bool Checked { get; set; }
		
		public Item ()
		{
			
		}
	}
}
