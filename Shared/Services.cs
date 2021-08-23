using System;
using System.ComponentModel.Composition;
using Zyan.Communication;
using Zyan.Communication.Composition;

namespace Ultima
{
	// root interface
	public interface RootInterface
	{
	}

	// common interface
	public interface CommonInterface
	{
	}

	// root service to import all dependencies
	[Export(typeof(RootInterface))]
	internal class RootService : RootInterface
	{
		[Import]
		private Interface_0_0 Imported { get; set; }
	}

	// ------------ Level #0
			
	public interface Interface_0_0
	{
	}
		
	[Export(typeof(Interface_0_0)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_0_0))]
	[Script(0)]
	internal class Service_0_0 : Interface_0_0, CommonInterface
	{
		
		[Import]
		private Interface_1_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_1_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_1_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_1_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_1_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_1_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_1_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_1_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_1_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_1_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_1_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_1_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_1_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_1_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_1_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_1_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_1_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_1_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_1_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_1_19 Imported_19 { get; set; }
			
	}
		
	// ------------ Level #1
			
	public interface Interface_1_0
	{
	}
		
	public interface Interface_1_1
	{
	}
		
	public interface Interface_1_2
	{
	}
		
	public interface Interface_1_3
	{
	}
		
	public interface Interface_1_4
	{
	}
		
	public interface Interface_1_5
	{
	}
		
	public interface Interface_1_6
	{
	}
		
	public interface Interface_1_7
	{
	}
		
	public interface Interface_1_8
	{
	}
		
	public interface Interface_1_9
	{
	}
		
	public interface Interface_1_10
	{
	}
		
	public interface Interface_1_11
	{
	}
		
	public interface Interface_1_12
	{
	}
		
	public interface Interface_1_13
	{
	}
		
	public interface Interface_1_14
	{
	}
		
	public interface Interface_1_15
	{
	}
		
	public interface Interface_1_16
	{
	}
		
	public interface Interface_1_17
	{
	}
		
	public interface Interface_1_18
	{
	}
		
	public interface Interface_1_19
	{
	}
		
	[Export(typeof(Interface_1_0))]
	[ZyanComponent(typeof(Interface_1_0))]
	[Script(1000)]
	internal class Service_1_0 : Interface_1_0
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_1))]
	[ZyanComponent(typeof(Interface_1_1))]
	[Script(1001)]
	internal class Service_1_1 : Interface_1_1
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_2)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_2))]
	[Script(1002)]
	internal class Service_1_2 : Interface_1_2, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_3))]
	[ZyanComponent(typeof(Interface_1_3))]
	[Script(1003)]
	internal class Service_1_3 : Interface_1_3
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_4))]
	[ZyanComponent(typeof(Interface_1_4))]
	[Script(1004)]
	internal class Service_1_4 : Interface_1_4
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_5)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_5))]
	[Script(1005)]
	internal class Service_1_5 : Interface_1_5, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_6))]
	[ZyanComponent(typeof(Interface_1_6))]
	[Script(1006)]
	internal class Service_1_6 : Interface_1_6
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_7))]
	[ZyanComponent(typeof(Interface_1_7))]
	[Script(1007)]
	internal class Service_1_7 : Interface_1_7
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_8)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_8))]
	[Script(1008)]
	internal class Service_1_8 : Interface_1_8, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_9))]
	[ZyanComponent(typeof(Interface_1_9))]
	[Script(1009)]
	internal class Service_1_9 : Interface_1_9
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_10))]
	[ZyanComponent(typeof(Interface_1_10))]
	[Script(1010)]
	internal class Service_1_10 : Interface_1_10
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_11)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_11))]
	[Script(1011)]
	internal class Service_1_11 : Interface_1_11, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_12))]
	[ZyanComponent(typeof(Interface_1_12))]
	[Script(1012)]
	internal class Service_1_12 : Interface_1_12
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_13))]
	[ZyanComponent(typeof(Interface_1_13))]
	[Script(1013)]
	internal class Service_1_13 : Interface_1_13
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_14)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_14))]
	[Script(1014)]
	internal class Service_1_14 : Interface_1_14, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_15))]
	[ZyanComponent(typeof(Interface_1_15))]
	[Script(1015)]
	internal class Service_1_15 : Interface_1_15
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_16))]
	[ZyanComponent(typeof(Interface_1_16))]
	[Script(1016)]
	internal class Service_1_16 : Interface_1_16
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_17)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_1_17))]
	[Script(1017)]
	internal class Service_1_17 : Interface_1_17, CommonInterface
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_18))]
	[ZyanComponent(typeof(Interface_1_18))]
	[Script(1018)]
	internal class Service_1_18 : Interface_1_18
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_19))]
	[ZyanComponent(typeof(Interface_1_19))]
	[Script(1019)]
	internal class Service_1_19 : Interface_1_19
	{
		
		[Import]
		private Interface_2_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_2_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_2_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_2_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_2_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_2_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_2_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_2_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_2_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_2_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_2_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_2_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_2_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_2_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_2_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_2_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_2_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_2_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_2_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_2_19 Imported_19 { get; set; }
			
	}
		
	// ------------ Level #2
			
	public interface Interface_2_0
	{
	}
		
	public interface Interface_2_1
	{
	}
		
	public interface Interface_2_2
	{
	}
		
	public interface Interface_2_3
	{
	}
		
	public interface Interface_2_4
	{
	}
		
	public interface Interface_2_5
	{
	}
		
	public interface Interface_2_6
	{
	}
		
	public interface Interface_2_7
	{
	}
		
	public interface Interface_2_8
	{
	}
		
	public interface Interface_2_9
	{
	}
		
	public interface Interface_2_10
	{
	}
		
	public interface Interface_2_11
	{
	}
		
	public interface Interface_2_12
	{
	}
		
	public interface Interface_2_13
	{
	}
		
	public interface Interface_2_14
	{
	}
		
	public interface Interface_2_15
	{
	}
		
	public interface Interface_2_16
	{
	}
		
	public interface Interface_2_17
	{
	}
		
	public interface Interface_2_18
	{
	}
		
	public interface Interface_2_19
	{
	}
		
	[Export(typeof(Interface_2_0))]
	[ZyanComponent(typeof(Interface_2_0))]
	[Script(2000)]
	internal class Service_2_0 : Interface_2_0
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_1)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_1))]
	[Script(2001)]
	internal class Service_2_1 : Interface_2_1, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_2))]
	[ZyanComponent(typeof(Interface_2_2))]
	[Script(2002)]
	internal class Service_2_2 : Interface_2_2
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_3))]
	[ZyanComponent(typeof(Interface_2_3))]
	[Script(2003)]
	internal class Service_2_3 : Interface_2_3
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_4)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_4))]
	[Script(2004)]
	internal class Service_2_4 : Interface_2_4, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_5))]
	[ZyanComponent(typeof(Interface_2_5))]
	[Script(2005)]
	internal class Service_2_5 : Interface_2_5
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_6))]
	[ZyanComponent(typeof(Interface_2_6))]
	[Script(2006)]
	internal class Service_2_6 : Interface_2_6
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_7)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_7))]
	[Script(2007)]
	internal class Service_2_7 : Interface_2_7, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_8))]
	[ZyanComponent(typeof(Interface_2_8))]
	[Script(2008)]
	internal class Service_2_8 : Interface_2_8
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_9))]
	[ZyanComponent(typeof(Interface_2_9))]
	[Script(2009)]
	internal class Service_2_9 : Interface_2_9
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_10)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_10))]
	[Script(2010)]
	internal class Service_2_10 : Interface_2_10, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_11))]
	[ZyanComponent(typeof(Interface_2_11))]
	[Script(2011)]
	internal class Service_2_11 : Interface_2_11
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_12))]
	[ZyanComponent(typeof(Interface_2_12))]
	[Script(2012)]
	internal class Service_2_12 : Interface_2_12
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_13)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_13))]
	[Script(2013)]
	internal class Service_2_13 : Interface_2_13, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_14))]
	[ZyanComponent(typeof(Interface_2_14))]
	[Script(2014)]
	internal class Service_2_14 : Interface_2_14
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_15))]
	[ZyanComponent(typeof(Interface_2_15))]
	[Script(2015)]
	internal class Service_2_15 : Interface_2_15
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_16)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_16))]
	[Script(2016)]
	internal class Service_2_16 : Interface_2_16, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_17))]
	[ZyanComponent(typeof(Interface_2_17))]
	[Script(2017)]
	internal class Service_2_17 : Interface_2_17
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_18))]
	[ZyanComponent(typeof(Interface_2_18))]
	[Script(2018)]
	internal class Service_2_18 : Interface_2_18
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_19)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_2_19))]
	[Script(2019)]
	internal class Service_2_19 : Interface_2_19, CommonInterface
	{
		
		[Import]
		private Interface_3_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_3_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_3_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_3_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_3_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_3_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_3_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_3_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_3_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_3_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_3_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_3_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_3_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_3_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_3_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_3_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_3_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_3_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_3_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_3_19 Imported_19 { get; set; }
			
	}
		
	// ------------ Level #3
			
	public interface Interface_3_0
	{
	}
		
	public interface Interface_3_1
	{
	}
		
	public interface Interface_3_2
	{
	}
		
	public interface Interface_3_3
	{
	}
		
	public interface Interface_3_4
	{
	}
		
	public interface Interface_3_5
	{
	}
		
	public interface Interface_3_6
	{
	}
		
	public interface Interface_3_7
	{
	}
		
	public interface Interface_3_8
	{
	}
		
	public interface Interface_3_9
	{
	}
		
	public interface Interface_3_10
	{
	}
		
	public interface Interface_3_11
	{
	}
		
	public interface Interface_3_12
	{
	}
		
	public interface Interface_3_13
	{
	}
		
	public interface Interface_3_14
	{
	}
		
	public interface Interface_3_15
	{
	}
		
	public interface Interface_3_16
	{
	}
		
	public interface Interface_3_17
	{
	}
		
	public interface Interface_3_18
	{
	}
		
	public interface Interface_3_19
	{
	}
		
	[Export(typeof(Interface_3_0)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_0))]
	[Script(3000)]
	internal class Service_3_0 : Interface_3_0, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_1))]
	[ZyanComponent(typeof(Interface_3_1))]
	[Script(3001)]
	internal class Service_3_1 : Interface_3_1
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_2))]
	[ZyanComponent(typeof(Interface_3_2))]
	[Script(3002)]
	internal class Service_3_2 : Interface_3_2
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_3)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_3))]
	[Script(3003)]
	internal class Service_3_3 : Interface_3_3, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_4))]
	[ZyanComponent(typeof(Interface_3_4))]
	[Script(3004)]
	internal class Service_3_4 : Interface_3_4
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_5))]
	[ZyanComponent(typeof(Interface_3_5))]
	[Script(3005)]
	internal class Service_3_5 : Interface_3_5
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_6)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_6))]
	[Script(3006)]
	internal class Service_3_6 : Interface_3_6, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_7))]
	[ZyanComponent(typeof(Interface_3_7))]
	[Script(3007)]
	internal class Service_3_7 : Interface_3_7
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_8))]
	[ZyanComponent(typeof(Interface_3_8))]
	[Script(3008)]
	internal class Service_3_8 : Interface_3_8
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_9)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_9))]
	[Script(3009)]
	internal class Service_3_9 : Interface_3_9, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_10))]
	[ZyanComponent(typeof(Interface_3_10))]
	[Script(3010)]
	internal class Service_3_10 : Interface_3_10
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_11))]
	[ZyanComponent(typeof(Interface_3_11))]
	[Script(3011)]
	internal class Service_3_11 : Interface_3_11
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_12)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_12))]
	[Script(3012)]
	internal class Service_3_12 : Interface_3_12, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_13))]
	[ZyanComponent(typeof(Interface_3_13))]
	[Script(3013)]
	internal class Service_3_13 : Interface_3_13
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_14))]
	[ZyanComponent(typeof(Interface_3_14))]
	[Script(3014)]
	internal class Service_3_14 : Interface_3_14
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_15)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_15))]
	[Script(3015)]
	internal class Service_3_15 : Interface_3_15, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_16))]
	[ZyanComponent(typeof(Interface_3_16))]
	[Script(3016)]
	internal class Service_3_16 : Interface_3_16
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_17))]
	[ZyanComponent(typeof(Interface_3_17))]
	[Script(3017)]
	internal class Service_3_17 : Interface_3_17
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_18)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_3_18))]
	[Script(3018)]
	internal class Service_3_18 : Interface_3_18, CommonInterface
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_19))]
	[ZyanComponent(typeof(Interface_3_19))]
	[Script(3019)]
	internal class Service_3_19 : Interface_3_19
	{
		
		[Import]
		private Interface_4_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_4_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_4_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_4_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_4_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_4_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_4_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_4_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_4_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_4_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_4_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_4_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_4_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_4_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_4_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_4_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_4_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_4_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_4_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_4_19 Imported_19 { get; set; }
			
	}
		
	// ------------ Level #4
			
	public interface Interface_4_0
	{
	}
		
	public interface Interface_4_1
	{
	}
		
	public interface Interface_4_2
	{
	}
		
	public interface Interface_4_3
	{
	}
		
	public interface Interface_4_4
	{
	}
		
	public interface Interface_4_5
	{
	}
		
	public interface Interface_4_6
	{
	}
		
	public interface Interface_4_7
	{
	}
		
	public interface Interface_4_8
	{
	}
		
	public interface Interface_4_9
	{
	}
		
	public interface Interface_4_10
	{
	}
		
	public interface Interface_4_11
	{
	}
		
	public interface Interface_4_12
	{
	}
		
	public interface Interface_4_13
	{
	}
		
	public interface Interface_4_14
	{
	}
		
	public interface Interface_4_15
	{
	}
		
	public interface Interface_4_16
	{
	}
		
	public interface Interface_4_17
	{
	}
		
	public interface Interface_4_18
	{
	}
		
	public interface Interface_4_19
	{
	}
		
	[Export(typeof(Interface_4_0))]
	[ZyanComponent(typeof(Interface_4_0))]
	[Script(4000)]
	internal class Service_4_0 : Interface_4_0
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_1))]
	[ZyanComponent(typeof(Interface_4_1))]
	[Script(4001)]
	internal class Service_4_1 : Interface_4_1
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_2)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_2))]
	[Script(4002)]
	internal class Service_4_2 : Interface_4_2, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_3))]
	[ZyanComponent(typeof(Interface_4_3))]
	[Script(4003)]
	internal class Service_4_3 : Interface_4_3
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_4))]
	[ZyanComponent(typeof(Interface_4_4))]
	[Script(4004)]
	internal class Service_4_4 : Interface_4_4
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_5)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_5))]
	[Script(4005)]
	internal class Service_4_5 : Interface_4_5, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_6))]
	[ZyanComponent(typeof(Interface_4_6))]
	[Script(4006)]
	internal class Service_4_6 : Interface_4_6
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_7))]
	[ZyanComponent(typeof(Interface_4_7))]
	[Script(4007)]
	internal class Service_4_7 : Interface_4_7
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_8)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_8))]
	[Script(4008)]
	internal class Service_4_8 : Interface_4_8, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_9))]
	[ZyanComponent(typeof(Interface_4_9))]
	[Script(4009)]
	internal class Service_4_9 : Interface_4_9
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_10))]
	[ZyanComponent(typeof(Interface_4_10))]
	[Script(4010)]
	internal class Service_4_10 : Interface_4_10
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_11)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_11))]
	[Script(4011)]
	internal class Service_4_11 : Interface_4_11, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_12))]
	[ZyanComponent(typeof(Interface_4_12))]
	[Script(4012)]
	internal class Service_4_12 : Interface_4_12
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_13))]
	[ZyanComponent(typeof(Interface_4_13))]
	[Script(4013)]
	internal class Service_4_13 : Interface_4_13
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_14)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_14))]
	[Script(4014)]
	internal class Service_4_14 : Interface_4_14, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_15))]
	[ZyanComponent(typeof(Interface_4_15))]
	[Script(4015)]
	internal class Service_4_15 : Interface_4_15
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_16))]
	[ZyanComponent(typeof(Interface_4_16))]
	[Script(4016)]
	internal class Service_4_16 : Interface_4_16
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_17)), Export(typeof(CommonInterface))]
	[ZyanComponent(typeof(Interface_4_17))]
	[Script(4017)]
	internal class Service_4_17 : Interface_4_17, CommonInterface
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_18))]
	[ZyanComponent(typeof(Interface_4_18))]
	[Script(4018)]
	internal class Service_4_18 : Interface_4_18
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_19))]
	[ZyanComponent(typeof(Interface_4_19))]
	[Script(4019)]
	internal class Service_4_19 : Interface_4_19
	{
		 /* Last level — no imports */ 
	}
		}

