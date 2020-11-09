﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
	public class Cart
	{
		[DisplayName("Name of Product")]
		public string ProductName { get; set; }
		[DisplayName("Shape")]
		public string Shape { get; set; }
		[DisplayName("Unit Price")]
		public double UnitPrice { get; set; }
		[DisplayName("Quantity")]
		public double Quantity { get; set; }

		private double _Total;

		public double Total
		{
			get { return UnitPrice * Quantity; }
			set { _Total = value; }
		}



	}
}
