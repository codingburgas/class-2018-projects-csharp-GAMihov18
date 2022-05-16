using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Types
{
	public interface IItem
	{
		string Name { get; }
		COMMON_VALUES.ITEM_TYPE ItemType { get; }
		string GetData(bool isReadable);
	}
}
