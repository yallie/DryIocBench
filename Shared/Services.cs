using System;
using System.ComponentModel.Composition;

namespace Ultima
{
	// root interface
	public interface RootInterface
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
		
	[Export(typeof(Interface_0_0))]
	internal class Service_0_0 : Interface_0_0
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
		
	[Export(typeof(Interface_1_2))]
	internal class Service_1_2 : Interface_1_2
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
		
	[Export(typeof(Interface_1_5))]
	internal class Service_1_5 : Interface_1_5
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
		
	[Export(typeof(Interface_1_8))]
	internal class Service_1_8 : Interface_1_8
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
		
	[Export(typeof(Interface_1_11))]
	internal class Service_1_11 : Interface_1_11
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
		
	[Export(typeof(Interface_1_14))]
	internal class Service_1_14 : Interface_1_14
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
		
	[Export(typeof(Interface_1_17))]
	internal class Service_1_17 : Interface_1_17
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
		
	[Export(typeof(Interface_2_1))]
	internal class Service_2_1 : Interface_2_1
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
		
	[Export(typeof(Interface_2_4))]
	internal class Service_2_4 : Interface_2_4
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
		
	[Export(typeof(Interface_2_7))]
	internal class Service_2_7 : Interface_2_7
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
		
	[Export(typeof(Interface_2_10))]
	internal class Service_2_10 : Interface_2_10
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
		
	[Export(typeof(Interface_2_13))]
	internal class Service_2_13 : Interface_2_13
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
		
	[Export(typeof(Interface_2_16))]
	internal class Service_2_16 : Interface_2_16
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
		
	[Export(typeof(Interface_2_19))]
	internal class Service_2_19 : Interface_2_19
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
		
	[Export(typeof(Interface_3_0))]
	internal class Service_3_0 : Interface_3_0
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
		
	[Export(typeof(Interface_3_3))]
	internal class Service_3_3 : Interface_3_3
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
		
	[Export(typeof(Interface_3_6))]
	internal class Service_3_6 : Interface_3_6
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
		
	[Export(typeof(Interface_3_9))]
	internal class Service_3_9 : Interface_3_9
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
		
	[Export(typeof(Interface_3_12))]
	internal class Service_3_12 : Interface_3_12
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
		
	[Export(typeof(Interface_3_15))]
	internal class Service_3_15 : Interface_3_15
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
		
	[Export(typeof(Interface_3_18))]
	internal class Service_3_18 : Interface_3_18
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
	internal class Service_4_0 : Interface_4_0
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_1))]
	internal class Service_4_1 : Interface_4_1
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_2))]
	internal class Service_4_2 : Interface_4_2
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_3))]
	internal class Service_4_3 : Interface_4_3
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_4))]
	internal class Service_4_4 : Interface_4_4
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_5))]
	internal class Service_4_5 : Interface_4_5
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_6))]
	internal class Service_4_6 : Interface_4_6
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_7))]
	internal class Service_4_7 : Interface_4_7
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_8))]
	internal class Service_4_8 : Interface_4_8
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_9))]
	internal class Service_4_9 : Interface_4_9
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_10))]
	internal class Service_4_10 : Interface_4_10
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_11))]
	internal class Service_4_11 : Interface_4_11
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_12))]
	internal class Service_4_12 : Interface_4_12
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_13))]
	internal class Service_4_13 : Interface_4_13
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_14))]
	internal class Service_4_14 : Interface_4_14
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_15))]
	internal class Service_4_15 : Interface_4_15
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_16))]
	internal class Service_4_16 : Interface_4_16
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_17))]
	internal class Service_4_17 : Interface_4_17
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_18))]
	internal class Service_4_18 : Interface_4_18
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_4_19))]
	internal class Service_4_19 : Interface_4_19
	{
		 /* Last level — no imports */ 
	}
		}

