// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FactoryDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
	/// <summary>
	/// create a abstract class named Computer which is the parent class
	/// </summary>
	public abstract class Computer
	{
		/// <summary>
		/// Chargings this instance.
		/// </summary>
		public abstract void Charging();
		/// <summary>
		/// Nots the charging.
		/// </summary>
		public abstract void NotCharging();
		/// <summary>
		/// Runnings this instance.
		/// </summary>
		public abstract void Running();

	}
}
