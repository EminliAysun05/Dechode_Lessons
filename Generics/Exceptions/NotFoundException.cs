using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exceptions
{
	public class NotFoundException : Exception
	{

		//      public NotFoundException(string message) : base("mehsul tapilmadi")
		//{
		//          //bunun iicnede vre bilersiniz
		//      }


		public NotFoundException(string message) : base(message)
		{
		}

		//throw new NotFoundException("mehsul tapilmadi");

		
	}
}
