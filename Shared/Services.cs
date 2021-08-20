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
			
		[Import]
		private Interface_1_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_1_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_1_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_1_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_1_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_1_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_1_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_1_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_1_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_1_29 Imported_29 { get; set; }
			
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
		
	public interface Interface_1_20
	{
	}
		
	public interface Interface_1_21
	{
	}
		
	public interface Interface_1_22
	{
	}
		
	public interface Interface_1_23
	{
	}
		
	public interface Interface_1_24
	{
	}
		
	public interface Interface_1_25
	{
	}
		
	public interface Interface_1_26
	{
	}
		
	public interface Interface_1_27
	{
	}
		
	public interface Interface_1_28
	{
	}
		
	public interface Interface_1_29
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_20))]
	internal class Service_1_20 : Interface_1_20
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_21))]
	internal class Service_1_21 : Interface_1_21
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_22))]
	internal class Service_1_22 : Interface_1_22
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_23))]
	internal class Service_1_23 : Interface_1_23
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_24))]
	internal class Service_1_24 : Interface_1_24
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_25))]
	internal class Service_1_25 : Interface_1_25
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_26))]
	internal class Service_1_26 : Interface_1_26
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_27))]
	internal class Service_1_27 : Interface_1_27
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_28))]
	internal class Service_1_28 : Interface_1_28
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_1_29))]
	internal class Service_1_29 : Interface_1_29
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
			
		[Import]
		private Interface_2_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_2_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_2_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_2_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_2_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_2_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_2_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_2_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_2_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_2_29 Imported_29 { get; set; }
			
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
		
	public interface Interface_2_20
	{
	}
		
	public interface Interface_2_21
	{
	}
		
	public interface Interface_2_22
	{
	}
		
	public interface Interface_2_23
	{
	}
		
	public interface Interface_2_24
	{
	}
		
	public interface Interface_2_25
	{
	}
		
	public interface Interface_2_26
	{
	}
		
	public interface Interface_2_27
	{
	}
		
	public interface Interface_2_28
	{
	}
		
	public interface Interface_2_29
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_20))]
	internal class Service_2_20 : Interface_2_20
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_21))]
	internal class Service_2_21 : Interface_2_21
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_22))]
	internal class Service_2_22 : Interface_2_22
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_23))]
	internal class Service_2_23 : Interface_2_23
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_24))]
	internal class Service_2_24 : Interface_2_24
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_25))]
	internal class Service_2_25 : Interface_2_25
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_26))]
	internal class Service_2_26 : Interface_2_26
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_27))]
	internal class Service_2_27 : Interface_2_27
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_28))]
	internal class Service_2_28 : Interface_2_28
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_2_29))]
	internal class Service_2_29 : Interface_2_29
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
			
		[Import]
		private Interface_3_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_3_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_3_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_3_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_3_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_3_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_3_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_3_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_3_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_3_29 Imported_29 { get; set; }
			
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
		
	public interface Interface_3_20
	{
	}
		
	public interface Interface_3_21
	{
	}
		
	public interface Interface_3_22
	{
	}
		
	public interface Interface_3_23
	{
	}
		
	public interface Interface_3_24
	{
	}
		
	public interface Interface_3_25
	{
	}
		
	public interface Interface_3_26
	{
	}
		
	public interface Interface_3_27
	{
	}
		
	public interface Interface_3_28
	{
	}
		
	public interface Interface_3_29
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_20))]
	internal class Service_3_20 : Interface_3_20
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_21))]
	internal class Service_3_21 : Interface_3_21
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_22))]
	internal class Service_3_22 : Interface_3_22
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_23))]
	internal class Service_3_23 : Interface_3_23
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_24))]
	internal class Service_3_24 : Interface_3_24
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_25))]
	internal class Service_3_25 : Interface_3_25
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_26))]
	internal class Service_3_26 : Interface_3_26
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_27))]
	internal class Service_3_27 : Interface_3_27
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_28))]
	internal class Service_3_28 : Interface_3_28
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_3_29))]
	internal class Service_3_29 : Interface_3_29
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
			
		[Import]
		private Interface_4_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_4_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_4_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_4_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_4_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_4_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_4_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_4_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_4_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_4_29 Imported_29 { get; set; }
			
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
		
	public interface Interface_4_20
	{
	}
		
	public interface Interface_4_21
	{
	}
		
	public interface Interface_4_22
	{
	}
		
	public interface Interface_4_23
	{
	}
		
	public interface Interface_4_24
	{
	}
		
	public interface Interface_4_25
	{
	}
		
	public interface Interface_4_26
	{
	}
		
	public interface Interface_4_27
	{
	}
		
	public interface Interface_4_28
	{
	}
		
	public interface Interface_4_29
	{
	}
		
	[Export(typeof(Interface_4_0))]
	internal class Service_4_0 : Interface_4_0
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_1))]
	internal class Service_4_1 : Interface_4_1
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_2))]
	internal class Service_4_2 : Interface_4_2
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_3))]
	internal class Service_4_3 : Interface_4_3
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_4))]
	internal class Service_4_4 : Interface_4_4
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_5))]
	internal class Service_4_5 : Interface_4_5
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_6))]
	internal class Service_4_6 : Interface_4_6
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_7))]
	internal class Service_4_7 : Interface_4_7
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_8))]
	internal class Service_4_8 : Interface_4_8
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_9))]
	internal class Service_4_9 : Interface_4_9
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_10))]
	internal class Service_4_10 : Interface_4_10
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_11))]
	internal class Service_4_11 : Interface_4_11
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_12))]
	internal class Service_4_12 : Interface_4_12
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_13))]
	internal class Service_4_13 : Interface_4_13
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_14))]
	internal class Service_4_14 : Interface_4_14
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_15))]
	internal class Service_4_15 : Interface_4_15
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_16))]
	internal class Service_4_16 : Interface_4_16
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_17))]
	internal class Service_4_17 : Interface_4_17
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_18))]
	internal class Service_4_18 : Interface_4_18
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_19))]
	internal class Service_4_19 : Interface_4_19
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_20))]
	internal class Service_4_20 : Interface_4_20
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_21))]
	internal class Service_4_21 : Interface_4_21
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_22))]
	internal class Service_4_22 : Interface_4_22
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_23))]
	internal class Service_4_23 : Interface_4_23
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_24))]
	internal class Service_4_24 : Interface_4_24
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_25))]
	internal class Service_4_25 : Interface_4_25
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_26))]
	internal class Service_4_26 : Interface_4_26
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_27))]
	internal class Service_4_27 : Interface_4_27
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_28))]
	internal class Service_4_28 : Interface_4_28
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_4_29))]
	internal class Service_4_29 : Interface_4_29
	{
		
		[Import]
		private Interface_5_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_5_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_5_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_5_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_5_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_5_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_5_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_5_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_5_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_5_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_5_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_5_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_5_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_5_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_5_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_5_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_5_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_5_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_5_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_5_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_5_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_5_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_5_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_5_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_5_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_5_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_5_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_5_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_5_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_5_29 Imported_29 { get; set; }
			
	}
		
	// ------------ Level #5
			
	public interface Interface_5_0
	{
	}
		
	public interface Interface_5_1
	{
	}
		
	public interface Interface_5_2
	{
	}
		
	public interface Interface_5_3
	{
	}
		
	public interface Interface_5_4
	{
	}
		
	public interface Interface_5_5
	{
	}
		
	public interface Interface_5_6
	{
	}
		
	public interface Interface_5_7
	{
	}
		
	public interface Interface_5_8
	{
	}
		
	public interface Interface_5_9
	{
	}
		
	public interface Interface_5_10
	{
	}
		
	public interface Interface_5_11
	{
	}
		
	public interface Interface_5_12
	{
	}
		
	public interface Interface_5_13
	{
	}
		
	public interface Interface_5_14
	{
	}
		
	public interface Interface_5_15
	{
	}
		
	public interface Interface_5_16
	{
	}
		
	public interface Interface_5_17
	{
	}
		
	public interface Interface_5_18
	{
	}
		
	public interface Interface_5_19
	{
	}
		
	public interface Interface_5_20
	{
	}
		
	public interface Interface_5_21
	{
	}
		
	public interface Interface_5_22
	{
	}
		
	public interface Interface_5_23
	{
	}
		
	public interface Interface_5_24
	{
	}
		
	public interface Interface_5_25
	{
	}
		
	public interface Interface_5_26
	{
	}
		
	public interface Interface_5_27
	{
	}
		
	public interface Interface_5_28
	{
	}
		
	public interface Interface_5_29
	{
	}
		
	[Export(typeof(Interface_5_0))]
	internal class Service_5_0 : Interface_5_0
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_1))]
	internal class Service_5_1 : Interface_5_1
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_2))]
	internal class Service_5_2 : Interface_5_2
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_3))]
	internal class Service_5_3 : Interface_5_3
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_4))]
	internal class Service_5_4 : Interface_5_4
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_5))]
	internal class Service_5_5 : Interface_5_5
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_6))]
	internal class Service_5_6 : Interface_5_6
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_7))]
	internal class Service_5_7 : Interface_5_7
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_8))]
	internal class Service_5_8 : Interface_5_8
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_9))]
	internal class Service_5_9 : Interface_5_9
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_10))]
	internal class Service_5_10 : Interface_5_10
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_11))]
	internal class Service_5_11 : Interface_5_11
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_12))]
	internal class Service_5_12 : Interface_5_12
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_13))]
	internal class Service_5_13 : Interface_5_13
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_14))]
	internal class Service_5_14 : Interface_5_14
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_15))]
	internal class Service_5_15 : Interface_5_15
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_16))]
	internal class Service_5_16 : Interface_5_16
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_17))]
	internal class Service_5_17 : Interface_5_17
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_18))]
	internal class Service_5_18 : Interface_5_18
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_19))]
	internal class Service_5_19 : Interface_5_19
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_20))]
	internal class Service_5_20 : Interface_5_20
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_21))]
	internal class Service_5_21 : Interface_5_21
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_22))]
	internal class Service_5_22 : Interface_5_22
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_23))]
	internal class Service_5_23 : Interface_5_23
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_24))]
	internal class Service_5_24 : Interface_5_24
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_25))]
	internal class Service_5_25 : Interface_5_25
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_26))]
	internal class Service_5_26 : Interface_5_26
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_27))]
	internal class Service_5_27 : Interface_5_27
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_28))]
	internal class Service_5_28 : Interface_5_28
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_5_29))]
	internal class Service_5_29 : Interface_5_29
	{
		
		[Import]
		private Interface_6_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_6_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_6_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_6_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_6_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_6_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_6_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_6_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_6_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_6_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_6_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_6_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_6_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_6_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_6_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_6_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_6_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_6_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_6_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_6_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_6_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_6_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_6_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_6_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_6_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_6_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_6_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_6_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_6_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_6_29 Imported_29 { get; set; }
			
	}
		
	// ------------ Level #6
			
	public interface Interface_6_0
	{
	}
		
	public interface Interface_6_1
	{
	}
		
	public interface Interface_6_2
	{
	}
		
	public interface Interface_6_3
	{
	}
		
	public interface Interface_6_4
	{
	}
		
	public interface Interface_6_5
	{
	}
		
	public interface Interface_6_6
	{
	}
		
	public interface Interface_6_7
	{
	}
		
	public interface Interface_6_8
	{
	}
		
	public interface Interface_6_9
	{
	}
		
	public interface Interface_6_10
	{
	}
		
	public interface Interface_6_11
	{
	}
		
	public interface Interface_6_12
	{
	}
		
	public interface Interface_6_13
	{
	}
		
	public interface Interface_6_14
	{
	}
		
	public interface Interface_6_15
	{
	}
		
	public interface Interface_6_16
	{
	}
		
	public interface Interface_6_17
	{
	}
		
	public interface Interface_6_18
	{
	}
		
	public interface Interface_6_19
	{
	}
		
	public interface Interface_6_20
	{
	}
		
	public interface Interface_6_21
	{
	}
		
	public interface Interface_6_22
	{
	}
		
	public interface Interface_6_23
	{
	}
		
	public interface Interface_6_24
	{
	}
		
	public interface Interface_6_25
	{
	}
		
	public interface Interface_6_26
	{
	}
		
	public interface Interface_6_27
	{
	}
		
	public interface Interface_6_28
	{
	}
		
	public interface Interface_6_29
	{
	}
		
	[Export(typeof(Interface_6_0))]
	internal class Service_6_0 : Interface_6_0
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_1))]
	internal class Service_6_1 : Interface_6_1
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_2))]
	internal class Service_6_2 : Interface_6_2
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_3))]
	internal class Service_6_3 : Interface_6_3
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_4))]
	internal class Service_6_4 : Interface_6_4
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_5))]
	internal class Service_6_5 : Interface_6_5
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_6))]
	internal class Service_6_6 : Interface_6_6
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_7))]
	internal class Service_6_7 : Interface_6_7
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_8))]
	internal class Service_6_8 : Interface_6_8
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_9))]
	internal class Service_6_9 : Interface_6_9
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_10))]
	internal class Service_6_10 : Interface_6_10
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_11))]
	internal class Service_6_11 : Interface_6_11
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_12))]
	internal class Service_6_12 : Interface_6_12
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_13))]
	internal class Service_6_13 : Interface_6_13
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_14))]
	internal class Service_6_14 : Interface_6_14
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_15))]
	internal class Service_6_15 : Interface_6_15
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_16))]
	internal class Service_6_16 : Interface_6_16
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_17))]
	internal class Service_6_17 : Interface_6_17
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_18))]
	internal class Service_6_18 : Interface_6_18
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_19))]
	internal class Service_6_19 : Interface_6_19
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_20))]
	internal class Service_6_20 : Interface_6_20
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_21))]
	internal class Service_6_21 : Interface_6_21
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_22))]
	internal class Service_6_22 : Interface_6_22
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_23))]
	internal class Service_6_23 : Interface_6_23
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_24))]
	internal class Service_6_24 : Interface_6_24
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_25))]
	internal class Service_6_25 : Interface_6_25
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_26))]
	internal class Service_6_26 : Interface_6_26
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_27))]
	internal class Service_6_27 : Interface_6_27
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_28))]
	internal class Service_6_28 : Interface_6_28
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_6_29))]
	internal class Service_6_29 : Interface_6_29
	{
		
		[Import]
		private Interface_7_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_7_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_7_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_7_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_7_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_7_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_7_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_7_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_7_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_7_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_7_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_7_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_7_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_7_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_7_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_7_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_7_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_7_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_7_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_7_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_7_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_7_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_7_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_7_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_7_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_7_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_7_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_7_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_7_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_7_29 Imported_29 { get; set; }
			
	}
		
	// ------------ Level #7
			
	public interface Interface_7_0
	{
	}
		
	public interface Interface_7_1
	{
	}
		
	public interface Interface_7_2
	{
	}
		
	public interface Interface_7_3
	{
	}
		
	public interface Interface_7_4
	{
	}
		
	public interface Interface_7_5
	{
	}
		
	public interface Interface_7_6
	{
	}
		
	public interface Interface_7_7
	{
	}
		
	public interface Interface_7_8
	{
	}
		
	public interface Interface_7_9
	{
	}
		
	public interface Interface_7_10
	{
	}
		
	public interface Interface_7_11
	{
	}
		
	public interface Interface_7_12
	{
	}
		
	public interface Interface_7_13
	{
	}
		
	public interface Interface_7_14
	{
	}
		
	public interface Interface_7_15
	{
	}
		
	public interface Interface_7_16
	{
	}
		
	public interface Interface_7_17
	{
	}
		
	public interface Interface_7_18
	{
	}
		
	public interface Interface_7_19
	{
	}
		
	public interface Interface_7_20
	{
	}
		
	public interface Interface_7_21
	{
	}
		
	public interface Interface_7_22
	{
	}
		
	public interface Interface_7_23
	{
	}
		
	public interface Interface_7_24
	{
	}
		
	public interface Interface_7_25
	{
	}
		
	public interface Interface_7_26
	{
	}
		
	public interface Interface_7_27
	{
	}
		
	public interface Interface_7_28
	{
	}
		
	public interface Interface_7_29
	{
	}
		
	[Export(typeof(Interface_7_0))]
	internal class Service_7_0 : Interface_7_0
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_1))]
	internal class Service_7_1 : Interface_7_1
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_2))]
	internal class Service_7_2 : Interface_7_2
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_3))]
	internal class Service_7_3 : Interface_7_3
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_4))]
	internal class Service_7_4 : Interface_7_4
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_5))]
	internal class Service_7_5 : Interface_7_5
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_6))]
	internal class Service_7_6 : Interface_7_6
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_7))]
	internal class Service_7_7 : Interface_7_7
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_8))]
	internal class Service_7_8 : Interface_7_8
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_9))]
	internal class Service_7_9 : Interface_7_9
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_10))]
	internal class Service_7_10 : Interface_7_10
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_11))]
	internal class Service_7_11 : Interface_7_11
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_12))]
	internal class Service_7_12 : Interface_7_12
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_13))]
	internal class Service_7_13 : Interface_7_13
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_14))]
	internal class Service_7_14 : Interface_7_14
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_15))]
	internal class Service_7_15 : Interface_7_15
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_16))]
	internal class Service_7_16 : Interface_7_16
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_17))]
	internal class Service_7_17 : Interface_7_17
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_18))]
	internal class Service_7_18 : Interface_7_18
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_19))]
	internal class Service_7_19 : Interface_7_19
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_20))]
	internal class Service_7_20 : Interface_7_20
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_21))]
	internal class Service_7_21 : Interface_7_21
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_22))]
	internal class Service_7_22 : Interface_7_22
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_23))]
	internal class Service_7_23 : Interface_7_23
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_24))]
	internal class Service_7_24 : Interface_7_24
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_25))]
	internal class Service_7_25 : Interface_7_25
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_26))]
	internal class Service_7_26 : Interface_7_26
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_27))]
	internal class Service_7_27 : Interface_7_27
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_28))]
	internal class Service_7_28 : Interface_7_28
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_7_29))]
	internal class Service_7_29 : Interface_7_29
	{
		
		[Import]
		private Interface_8_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_8_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_8_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_8_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_8_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_8_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_8_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_8_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_8_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_8_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_8_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_8_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_8_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_8_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_8_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_8_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_8_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_8_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_8_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_8_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_8_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_8_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_8_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_8_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_8_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_8_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_8_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_8_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_8_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_8_29 Imported_29 { get; set; }
			
	}
		
	// ------------ Level #8
			
	public interface Interface_8_0
	{
	}
		
	public interface Interface_8_1
	{
	}
		
	public interface Interface_8_2
	{
	}
		
	public interface Interface_8_3
	{
	}
		
	public interface Interface_8_4
	{
	}
		
	public interface Interface_8_5
	{
	}
		
	public interface Interface_8_6
	{
	}
		
	public interface Interface_8_7
	{
	}
		
	public interface Interface_8_8
	{
	}
		
	public interface Interface_8_9
	{
	}
		
	public interface Interface_8_10
	{
	}
		
	public interface Interface_8_11
	{
	}
		
	public interface Interface_8_12
	{
	}
		
	public interface Interface_8_13
	{
	}
		
	public interface Interface_8_14
	{
	}
		
	public interface Interface_8_15
	{
	}
		
	public interface Interface_8_16
	{
	}
		
	public interface Interface_8_17
	{
	}
		
	public interface Interface_8_18
	{
	}
		
	public interface Interface_8_19
	{
	}
		
	public interface Interface_8_20
	{
	}
		
	public interface Interface_8_21
	{
	}
		
	public interface Interface_8_22
	{
	}
		
	public interface Interface_8_23
	{
	}
		
	public interface Interface_8_24
	{
	}
		
	public interface Interface_8_25
	{
	}
		
	public interface Interface_8_26
	{
	}
		
	public interface Interface_8_27
	{
	}
		
	public interface Interface_8_28
	{
	}
		
	public interface Interface_8_29
	{
	}
		
	[Export(typeof(Interface_8_0))]
	internal class Service_8_0 : Interface_8_0
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_1))]
	internal class Service_8_1 : Interface_8_1
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_2))]
	internal class Service_8_2 : Interface_8_2
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_3))]
	internal class Service_8_3 : Interface_8_3
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_4))]
	internal class Service_8_4 : Interface_8_4
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_5))]
	internal class Service_8_5 : Interface_8_5
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_6))]
	internal class Service_8_6 : Interface_8_6
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_7))]
	internal class Service_8_7 : Interface_8_7
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_8))]
	internal class Service_8_8 : Interface_8_8
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_9))]
	internal class Service_8_9 : Interface_8_9
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_10))]
	internal class Service_8_10 : Interface_8_10
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_11))]
	internal class Service_8_11 : Interface_8_11
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_12))]
	internal class Service_8_12 : Interface_8_12
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_13))]
	internal class Service_8_13 : Interface_8_13
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_14))]
	internal class Service_8_14 : Interface_8_14
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_15))]
	internal class Service_8_15 : Interface_8_15
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_16))]
	internal class Service_8_16 : Interface_8_16
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_17))]
	internal class Service_8_17 : Interface_8_17
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_18))]
	internal class Service_8_18 : Interface_8_18
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_19))]
	internal class Service_8_19 : Interface_8_19
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_20))]
	internal class Service_8_20 : Interface_8_20
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_21))]
	internal class Service_8_21 : Interface_8_21
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_22))]
	internal class Service_8_22 : Interface_8_22
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_23))]
	internal class Service_8_23 : Interface_8_23
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_24))]
	internal class Service_8_24 : Interface_8_24
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_25))]
	internal class Service_8_25 : Interface_8_25
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_26))]
	internal class Service_8_26 : Interface_8_26
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_27))]
	internal class Service_8_27 : Interface_8_27
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_28))]
	internal class Service_8_28 : Interface_8_28
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	[Export(typeof(Interface_8_29))]
	internal class Service_8_29 : Interface_8_29
	{
		
		[Import]
		private Interface_9_0 Imported_0 { get; set; }
			
		[Import]
		private Interface_9_1 Imported_1 { get; set; }
			
		[Import]
		private Interface_9_2 Imported_2 { get; set; }
			
		[Import]
		private Interface_9_3 Imported_3 { get; set; }
			
		[Import]
		private Interface_9_4 Imported_4 { get; set; }
			
		[Import]
		private Interface_9_5 Imported_5 { get; set; }
			
		[Import]
		private Interface_9_6 Imported_6 { get; set; }
			
		[Import]
		private Interface_9_7 Imported_7 { get; set; }
			
		[Import]
		private Interface_9_8 Imported_8 { get; set; }
			
		[Import]
		private Interface_9_9 Imported_9 { get; set; }
			
		[Import]
		private Interface_9_10 Imported_10 { get; set; }
			
		[Import]
		private Interface_9_11 Imported_11 { get; set; }
			
		[Import]
		private Interface_9_12 Imported_12 { get; set; }
			
		[Import]
		private Interface_9_13 Imported_13 { get; set; }
			
		[Import]
		private Interface_9_14 Imported_14 { get; set; }
			
		[Import]
		private Interface_9_15 Imported_15 { get; set; }
			
		[Import]
		private Interface_9_16 Imported_16 { get; set; }
			
		[Import]
		private Interface_9_17 Imported_17 { get; set; }
			
		[Import]
		private Interface_9_18 Imported_18 { get; set; }
			
		[Import]
		private Interface_9_19 Imported_19 { get; set; }
			
		[Import]
		private Interface_9_20 Imported_20 { get; set; }
			
		[Import]
		private Interface_9_21 Imported_21 { get; set; }
			
		[Import]
		private Interface_9_22 Imported_22 { get; set; }
			
		[Import]
		private Interface_9_23 Imported_23 { get; set; }
			
		[Import]
		private Interface_9_24 Imported_24 { get; set; }
			
		[Import]
		private Interface_9_25 Imported_25 { get; set; }
			
		[Import]
		private Interface_9_26 Imported_26 { get; set; }
			
		[Import]
		private Interface_9_27 Imported_27 { get; set; }
			
		[Import]
		private Interface_9_28 Imported_28 { get; set; }
			
		[Import]
		private Interface_9_29 Imported_29 { get; set; }
			
	}
		
	// ------------ Level #9
			
	public interface Interface_9_0
	{
	}
		
	public interface Interface_9_1
	{
	}
		
	public interface Interface_9_2
	{
	}
		
	public interface Interface_9_3
	{
	}
		
	public interface Interface_9_4
	{
	}
		
	public interface Interface_9_5
	{
	}
		
	public interface Interface_9_6
	{
	}
		
	public interface Interface_9_7
	{
	}
		
	public interface Interface_9_8
	{
	}
		
	public interface Interface_9_9
	{
	}
		
	public interface Interface_9_10
	{
	}
		
	public interface Interface_9_11
	{
	}
		
	public interface Interface_9_12
	{
	}
		
	public interface Interface_9_13
	{
	}
		
	public interface Interface_9_14
	{
	}
		
	public interface Interface_9_15
	{
	}
		
	public interface Interface_9_16
	{
	}
		
	public interface Interface_9_17
	{
	}
		
	public interface Interface_9_18
	{
	}
		
	public interface Interface_9_19
	{
	}
		
	public interface Interface_9_20
	{
	}
		
	public interface Interface_9_21
	{
	}
		
	public interface Interface_9_22
	{
	}
		
	public interface Interface_9_23
	{
	}
		
	public interface Interface_9_24
	{
	}
		
	public interface Interface_9_25
	{
	}
		
	public interface Interface_9_26
	{
	}
		
	public interface Interface_9_27
	{
	}
		
	public interface Interface_9_28
	{
	}
		
	public interface Interface_9_29
	{
	}
		
	[Export(typeof(Interface_9_0))]
	internal class Service_9_0 : Interface_9_0
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_1))]
	internal class Service_9_1 : Interface_9_1
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_2))]
	internal class Service_9_2 : Interface_9_2
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_3))]
	internal class Service_9_3 : Interface_9_3
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_4))]
	internal class Service_9_4 : Interface_9_4
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_5))]
	internal class Service_9_5 : Interface_9_5
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_6))]
	internal class Service_9_6 : Interface_9_6
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_7))]
	internal class Service_9_7 : Interface_9_7
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_8))]
	internal class Service_9_8 : Interface_9_8
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_9))]
	internal class Service_9_9 : Interface_9_9
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_10))]
	internal class Service_9_10 : Interface_9_10
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_11))]
	internal class Service_9_11 : Interface_9_11
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_12))]
	internal class Service_9_12 : Interface_9_12
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_13))]
	internal class Service_9_13 : Interface_9_13
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_14))]
	internal class Service_9_14 : Interface_9_14
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_15))]
	internal class Service_9_15 : Interface_9_15
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_16))]
	internal class Service_9_16 : Interface_9_16
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_17))]
	internal class Service_9_17 : Interface_9_17
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_18))]
	internal class Service_9_18 : Interface_9_18
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_19))]
	internal class Service_9_19 : Interface_9_19
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_20))]
	internal class Service_9_20 : Interface_9_20
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_21))]
	internal class Service_9_21 : Interface_9_21
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_22))]
	internal class Service_9_22 : Interface_9_22
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_23))]
	internal class Service_9_23 : Interface_9_23
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_24))]
	internal class Service_9_24 : Interface_9_24
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_25))]
	internal class Service_9_25 : Interface_9_25
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_26))]
	internal class Service_9_26 : Interface_9_26
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_27))]
	internal class Service_9_27 : Interface_9_27
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_28))]
	internal class Service_9_28 : Interface_9_28
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(Interface_9_29))]
	internal class Service_9_29 : Interface_9_29
	{
		 /* Last level — no imports */ 
	}
		}

