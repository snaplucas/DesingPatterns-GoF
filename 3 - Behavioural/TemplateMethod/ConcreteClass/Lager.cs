﻿using System;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClass
{
	public class Lager : Cerveja
	{
		public override void Fermentacao()
		{
			Console.WriteLine("Temperatura entre 6 e 12 graus");
		}
	}
}
