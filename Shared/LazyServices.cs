using System;
using System.ComponentModel.Composition;

namespace Ultima
{
	// root interface
	public interface RootLazyInterface
	{
	}

	// root service to import all dependencies
	[Export(typeof(RootLazyInterface))]
	internal class RootLazyService : RootLazyInterface
	{
		[Import]
		private LazyInterface_0_0 Imported { get; set; }
	}

	// ------------ Level #0
			
	public interface LazyInterface_0_0
	{
	}
		
	[Export(typeof(LazyInterface_0_0))]
	internal class LazyService_0_0 : LazyInterface_0_0
	{
		
		[Import]
		private Lazy<LazyInterface_1_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_1_19> Imported_19 { get; set; }
			
	}
		
	// ------------ Level #1
			
	public interface LazyInterface_1_0
	{
	}
		
	public interface LazyInterface_1_1
	{
	}
		
	public interface LazyInterface_1_2
	{
	}
		
	public interface LazyInterface_1_3
	{
	}
		
	public interface LazyInterface_1_4
	{
	}
		
	public interface LazyInterface_1_5
	{
	}
		
	public interface LazyInterface_1_6
	{
	}
		
	public interface LazyInterface_1_7
	{
	}
		
	public interface LazyInterface_1_8
	{
	}
		
	public interface LazyInterface_1_9
	{
	}
		
	public interface LazyInterface_1_10
	{
	}
		
	public interface LazyInterface_1_11
	{
	}
		
	public interface LazyInterface_1_12
	{
	}
		
	public interface LazyInterface_1_13
	{
	}
		
	public interface LazyInterface_1_14
	{
	}
		
	public interface LazyInterface_1_15
	{
	}
		
	public interface LazyInterface_1_16
	{
	}
		
	public interface LazyInterface_1_17
	{
	}
		
	public interface LazyInterface_1_18
	{
	}
		
	public interface LazyInterface_1_19
	{
	}
		
	[Export(typeof(LazyInterface_1_0))]
	internal class LazyService_1_0 : LazyInterface_1_0
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_1))]
	internal class LazyService_1_1 : LazyInterface_1_1
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_2))]
	internal class LazyService_1_2 : LazyInterface_1_2
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_3))]
	internal class LazyService_1_3 : LazyInterface_1_3
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_4))]
	internal class LazyService_1_4 : LazyInterface_1_4
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_5))]
	internal class LazyService_1_5 : LazyInterface_1_5
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_6))]
	internal class LazyService_1_6 : LazyInterface_1_6
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_7))]
	internal class LazyService_1_7 : LazyInterface_1_7
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_8))]
	internal class LazyService_1_8 : LazyInterface_1_8
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_9))]
	internal class LazyService_1_9 : LazyInterface_1_9
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_10))]
	internal class LazyService_1_10 : LazyInterface_1_10
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_11))]
	internal class LazyService_1_11 : LazyInterface_1_11
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_12))]
	internal class LazyService_1_12 : LazyInterface_1_12
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_13))]
	internal class LazyService_1_13 : LazyInterface_1_13
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_14))]
	internal class LazyService_1_14 : LazyInterface_1_14
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_15))]
	internal class LazyService_1_15 : LazyInterface_1_15
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_16))]
	internal class LazyService_1_16 : LazyInterface_1_16
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_17))]
	internal class LazyService_1_17 : LazyInterface_1_17
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_18))]
	internal class LazyService_1_18 : LazyInterface_1_18
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_1_19))]
	internal class LazyService_1_19 : LazyInterface_1_19
	{
		
		[Import]
		private Lazy<LazyInterface_2_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_2_19> Imported_19 { get; set; }
			
	}
		
	// ------------ Level #2
			
	public interface LazyInterface_2_0
	{
	}
		
	public interface LazyInterface_2_1
	{
	}
		
	public interface LazyInterface_2_2
	{
	}
		
	public interface LazyInterface_2_3
	{
	}
		
	public interface LazyInterface_2_4
	{
	}
		
	public interface LazyInterface_2_5
	{
	}
		
	public interface LazyInterface_2_6
	{
	}
		
	public interface LazyInterface_2_7
	{
	}
		
	public interface LazyInterface_2_8
	{
	}
		
	public interface LazyInterface_2_9
	{
	}
		
	public interface LazyInterface_2_10
	{
	}
		
	public interface LazyInterface_2_11
	{
	}
		
	public interface LazyInterface_2_12
	{
	}
		
	public interface LazyInterface_2_13
	{
	}
		
	public interface LazyInterface_2_14
	{
	}
		
	public interface LazyInterface_2_15
	{
	}
		
	public interface LazyInterface_2_16
	{
	}
		
	public interface LazyInterface_2_17
	{
	}
		
	public interface LazyInterface_2_18
	{
	}
		
	public interface LazyInterface_2_19
	{
	}
		
	[Export(typeof(LazyInterface_2_0))]
	internal class LazyService_2_0 : LazyInterface_2_0
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_1))]
	internal class LazyService_2_1 : LazyInterface_2_1
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_2))]
	internal class LazyService_2_2 : LazyInterface_2_2
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_3))]
	internal class LazyService_2_3 : LazyInterface_2_3
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_4))]
	internal class LazyService_2_4 : LazyInterface_2_4
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_5))]
	internal class LazyService_2_5 : LazyInterface_2_5
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_6))]
	internal class LazyService_2_6 : LazyInterface_2_6
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_7))]
	internal class LazyService_2_7 : LazyInterface_2_7
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_8))]
	internal class LazyService_2_8 : LazyInterface_2_8
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_9))]
	internal class LazyService_2_9 : LazyInterface_2_9
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_10))]
	internal class LazyService_2_10 : LazyInterface_2_10
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_11))]
	internal class LazyService_2_11 : LazyInterface_2_11
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_12))]
	internal class LazyService_2_12 : LazyInterface_2_12
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_13))]
	internal class LazyService_2_13 : LazyInterface_2_13
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_14))]
	internal class LazyService_2_14 : LazyInterface_2_14
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_15))]
	internal class LazyService_2_15 : LazyInterface_2_15
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_16))]
	internal class LazyService_2_16 : LazyInterface_2_16
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_17))]
	internal class LazyService_2_17 : LazyInterface_2_17
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_18))]
	internal class LazyService_2_18 : LazyInterface_2_18
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_2_19))]
	internal class LazyService_2_19 : LazyInterface_2_19
	{
		
		[Import]
		private Lazy<LazyInterface_3_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_3_19> Imported_19 { get; set; }
			
	}
		
	// ------------ Level #3
			
	public interface LazyInterface_3_0
	{
	}
		
	public interface LazyInterface_3_1
	{
	}
		
	public interface LazyInterface_3_2
	{
	}
		
	public interface LazyInterface_3_3
	{
	}
		
	public interface LazyInterface_3_4
	{
	}
		
	public interface LazyInterface_3_5
	{
	}
		
	public interface LazyInterface_3_6
	{
	}
		
	public interface LazyInterface_3_7
	{
	}
		
	public interface LazyInterface_3_8
	{
	}
		
	public interface LazyInterface_3_9
	{
	}
		
	public interface LazyInterface_3_10
	{
	}
		
	public interface LazyInterface_3_11
	{
	}
		
	public interface LazyInterface_3_12
	{
	}
		
	public interface LazyInterface_3_13
	{
	}
		
	public interface LazyInterface_3_14
	{
	}
		
	public interface LazyInterface_3_15
	{
	}
		
	public interface LazyInterface_3_16
	{
	}
		
	public interface LazyInterface_3_17
	{
	}
		
	public interface LazyInterface_3_18
	{
	}
		
	public interface LazyInterface_3_19
	{
	}
		
	[Export(typeof(LazyInterface_3_0))]
	internal class LazyService_3_0 : LazyInterface_3_0
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_1))]
	internal class LazyService_3_1 : LazyInterface_3_1
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_2))]
	internal class LazyService_3_2 : LazyInterface_3_2
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_3))]
	internal class LazyService_3_3 : LazyInterface_3_3
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_4))]
	internal class LazyService_3_4 : LazyInterface_3_4
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_5))]
	internal class LazyService_3_5 : LazyInterface_3_5
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_6))]
	internal class LazyService_3_6 : LazyInterface_3_6
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_7))]
	internal class LazyService_3_7 : LazyInterface_3_7
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_8))]
	internal class LazyService_3_8 : LazyInterface_3_8
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_9))]
	internal class LazyService_3_9 : LazyInterface_3_9
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_10))]
	internal class LazyService_3_10 : LazyInterface_3_10
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_11))]
	internal class LazyService_3_11 : LazyInterface_3_11
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_12))]
	internal class LazyService_3_12 : LazyInterface_3_12
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_13))]
	internal class LazyService_3_13 : LazyInterface_3_13
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_14))]
	internal class LazyService_3_14 : LazyInterface_3_14
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_15))]
	internal class LazyService_3_15 : LazyInterface_3_15
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_16))]
	internal class LazyService_3_16 : LazyInterface_3_16
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_17))]
	internal class LazyService_3_17 : LazyInterface_3_17
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_18))]
	internal class LazyService_3_18 : LazyInterface_3_18
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	[Export(typeof(LazyInterface_3_19))]
	internal class LazyService_3_19 : LazyInterface_3_19
	{
		
		[Import]
		private Lazy<LazyInterface_4_0> Imported_0 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_1> Imported_1 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_2> Imported_2 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_3> Imported_3 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_4> Imported_4 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_5> Imported_5 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_6> Imported_6 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_7> Imported_7 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_8> Imported_8 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_9> Imported_9 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_10> Imported_10 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_11> Imported_11 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_12> Imported_12 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_13> Imported_13 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_14> Imported_14 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_15> Imported_15 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_16> Imported_16 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_17> Imported_17 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_18> Imported_18 { get; set; }
			
		[Import]
		private Lazy<LazyInterface_4_19> Imported_19 { get; set; }
			
	}
		
	// ------------ Level #4
			
	public interface LazyInterface_4_0
	{
	}
		
	public interface LazyInterface_4_1
	{
	}
		
	public interface LazyInterface_4_2
	{
	}
		
	public interface LazyInterface_4_3
	{
	}
		
	public interface LazyInterface_4_4
	{
	}
		
	public interface LazyInterface_4_5
	{
	}
		
	public interface LazyInterface_4_6
	{
	}
		
	public interface LazyInterface_4_7
	{
	}
		
	public interface LazyInterface_4_8
	{
	}
		
	public interface LazyInterface_4_9
	{
	}
		
	public interface LazyInterface_4_10
	{
	}
		
	public interface LazyInterface_4_11
	{
	}
		
	public interface LazyInterface_4_12
	{
	}
		
	public interface LazyInterface_4_13
	{
	}
		
	public interface LazyInterface_4_14
	{
	}
		
	public interface LazyInterface_4_15
	{
	}
		
	public interface LazyInterface_4_16
	{
	}
		
	public interface LazyInterface_4_17
	{
	}
		
	public interface LazyInterface_4_18
	{
	}
		
	public interface LazyInterface_4_19
	{
	}
		
	[Export(typeof(LazyInterface_4_0))]
	internal class LazyService_4_0 : LazyInterface_4_0
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_1))]
	internal class LazyService_4_1 : LazyInterface_4_1
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_2))]
	internal class LazyService_4_2 : LazyInterface_4_2
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_3))]
	internal class LazyService_4_3 : LazyInterface_4_3
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_4))]
	internal class LazyService_4_4 : LazyInterface_4_4
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_5))]
	internal class LazyService_4_5 : LazyInterface_4_5
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_6))]
	internal class LazyService_4_6 : LazyInterface_4_6
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_7))]
	internal class LazyService_4_7 : LazyInterface_4_7
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_8))]
	internal class LazyService_4_8 : LazyInterface_4_8
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_9))]
	internal class LazyService_4_9 : LazyInterface_4_9
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_10))]
	internal class LazyService_4_10 : LazyInterface_4_10
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_11))]
	internal class LazyService_4_11 : LazyInterface_4_11
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_12))]
	internal class LazyService_4_12 : LazyInterface_4_12
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_13))]
	internal class LazyService_4_13 : LazyInterface_4_13
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_14))]
	internal class LazyService_4_14 : LazyInterface_4_14
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_15))]
	internal class LazyService_4_15 : LazyInterface_4_15
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_16))]
	internal class LazyService_4_16 : LazyInterface_4_16
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_17))]
	internal class LazyService_4_17 : LazyInterface_4_17
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_18))]
	internal class LazyService_4_18 : LazyInterface_4_18
	{
		 /* Last level — no imports */ 
	}
		
	[Export(typeof(LazyInterface_4_19))]
	internal class LazyService_4_19 : LazyInterface_4_19
	{
		 /* Last level — no imports */ 
	}
		}

