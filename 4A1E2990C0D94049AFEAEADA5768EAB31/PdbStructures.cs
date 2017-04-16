using System;

namespace LiveForensics.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("4A1E2990-C0D9-4049-AFEA-EADA5768EAB3"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Amd64"; } }
		 public string SymbolsFileName { get { return @"ntkrnlmp.pdb"; } }
		 public uint Signature { get { return 1414543128; } }
		 public string Contents { get { return @"[""_EPROCESS"",""_KUSER_SHARED_DATA"",""_OBJECT_TYPE"",""_OBJECT_HEADER"",""_OBJECT_DIRECTORY_ENTRY"",""_OBJECT_DIRECTORY"",""_OBJECT_HEADER_CREATOR_INFO"",""_OBJECT_HEADER_NAME_INFO"",""_OBJECT_HEADER_HANDLE_INFO"",""_OBJECT_HEADER_QUOTA_INFO"",""_OBJECT_HEADER_PROCESS_INFO"",""_OBJECT_HEADER_AUDIT_INFO"",""_KPROCESS"",""_EX_PUSH_LOCK"",""_LARGE_INTEGER"",""_UNNAMED_27152"",""_EX_RUNDOWN_REF"",""_LIST_ENTRY"",""_EX_FAST_REF"",""_RTL_AVL_TREE"",""_SE_AUDIT_PROCESS_CREATION_INFO"",""_MMSUPPORT"",""_ALPC_PROCESS_CONTEXT"",""_PS_PROTECTION"",""_KSYSTEM_TIME"",""_XSTATE_CONFIGURATION"",""_UNICODE_STRING"",""_OBJECT_TYPE_INITIALIZER"",""_QUAD"",""_OBJECT_HANDLE_COUNT_ENTRY"",""_DISPATCHER_HEADER"",""_KAFFINITY_EX"",""_SINGLE_LIST_ENTRY"",""_KEXECUTE_OPTIONS"",""_KSTACK_COUNT"",""_KGDTENTRY64"",""_UNNAMED_27353"",""_FAST_MUTEX"",""_UNNAMED_27355"",""_MMSUPPORT_FLAGS"",""_XSTATE_FEATURE"",""_GENERIC_MAPPING"",""_KEVENT""])"; } }
		 public string Created { get { return "16-04-2017T14:06:57"; } }
	}
	#endregion
	#region _EPROCESS
 
	public class _EPROCESS
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _EPROCESS(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 1752; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EPROCESS"": [ 1752, {
				 ""Pcb"": [ 0, [ ""_KPROCESS"", ""null"" ]],
				 ""ProcessLock"": [ 712, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""CreateTime"": [ 720, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""RundownProtect"": [ 728, [ ""_EX_RUNDOWN_REF"", ""null"" ]],
				 ""UniqueProcessId"": [ 736, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ActiveProcessLinks"": [ 744, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""Flags2"": [ 760, [ ""UInt32"", ""null"" ]],
				 ""JobNotReallyActive"": [ 760, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""AccountingFolded"": [ 760, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""NewProcessReported"": [ 760, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""ExitProcessReported"": [ 760, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""ReportCommitChanges"": [ 760, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""LastReportMemory"": [ 760, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""ForceWakeCharge"": [ 760, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""CrossSessionCreate"": [ 760, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""UInt32\""}"" ]],
				 ""NeedsHandleRundown"": [ 760, [ ""BitField"", ""{\""end_bit\"":9,\""start_bit\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""RefTraceEnabled"": [ 760, [ ""BitField"", ""{\""end_bit\"":10,\""start_bit\"":9,\""target\"":\""UInt32\""}"" ]],
				 ""DisableDynamicCode"": [ 760, [ ""BitField"", ""{\""end_bit\"":11,\""start_bit\"":10,\""target\"":\""UInt32\""}"" ]],
				 ""EmptyJobEvaluated"": [ 760, [ ""BitField"", ""{\""end_bit\"":12,\""start_bit\"":11,\""target\"":\""UInt32\""}"" ]],
				 ""DefaultPagePriority"": [ 760, [ ""BitField"", ""{\""end_bit\"":15,\""start_bit\"":12,\""target\"":\""UInt32\""}"" ]],
				 ""PrimaryTokenFrozen"": [ 760, [ ""BitField"", ""{\""end_bit\"":16,\""start_bit\"":15,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessVerifierTarget"": [ 760, [ ""BitField"", ""{\""end_bit\"":17,\""start_bit\"":16,\""target\"":\""UInt32\""}"" ]],
				 ""StackRandomizationDisabled"": [ 760, [ ""BitField"", ""{\""end_bit\"":18,\""start_bit\"":17,\""target\"":\""UInt32\""}"" ]],
				 ""AffinityPermanent"": [ 760, [ ""BitField"", ""{\""end_bit\"":19,\""start_bit\"":18,\""target\"":\""UInt32\""}"" ]],
				 ""AffinityUpdateEnable"": [ 760, [ ""BitField"", ""{\""end_bit\"":20,\""start_bit\"":19,\""target\"":\""UInt32\""}"" ]],
				 ""PropagateNode"": [ 760, [ ""BitField"", ""{\""end_bit\"":21,\""start_bit\"":20,\""target\"":\""UInt32\""}"" ]],
				 ""ExplicitAffinity"": [ 760, [ ""BitField"", ""{\""end_bit\"":22,\""start_bit\"":21,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessExecutionState"": [ 760, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":22,\""target\"":\""UInt32\""}"" ]],
				 ""DisallowStrippedImages"": [ 760, [ ""BitField"", ""{\""end_bit\"":25,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]],
				 ""HighEntropyASLREnabled"": [ 760, [ ""BitField"", ""{\""end_bit\"":26,\""start_bit\"":25,\""target\"":\""UInt32\""}"" ]],
				 ""ExtensionPointDisable"": [ 760, [ ""BitField"", ""{\""end_bit\"":27,\""start_bit\"":26,\""target\"":\""UInt32\""}"" ]],
				 ""ForceRelocateImages"": [ 760, [ ""BitField"", ""{\""end_bit\"":28,\""start_bit\"":27,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessStateChangeRequest"": [ 760, [ ""BitField"", ""{\""end_bit\"":30,\""start_bit\"":28,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessStateChangeInProgress"": [ 760, [ ""BitField"", ""{\""end_bit\"":31,\""start_bit\"":30,\""target\"":\""UInt32\""}"" ]],
				 ""DisallowWin32kSystemCalls"": [ 760, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":31,\""target\"":\""UInt32\""}"" ]],
				 ""Flags"": [ 764, [ ""UInt32"", ""null"" ]],
				 ""CreateReported"": [ 764, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""NoDebugInherit"": [ 764, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessExiting"": [ 764, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessDelete"": [ 764, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""ControlFlowGuardEnabled"": [ 764, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""VmDeleted"": [ 764, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""OutswapEnabled"": [ 764, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""Outswapped"": [ 764, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""UInt32\""}"" ]],
				 ""ForkFailed"": [ 764, [ ""BitField"", ""{\""end_bit\"":9,\""start_bit\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""Wow64VaSpace4Gb"": [ 764, [ ""BitField"", ""{\""end_bit\"":10,\""start_bit\"":9,\""target\"":\""UInt32\""}"" ]],
				 ""AddressSpaceInitialized"": [ 764, [ ""BitField"", ""{\""end_bit\"":12,\""start_bit\"":10,\""target\"":\""UInt32\""}"" ]],
				 ""SetTimerResolution"": [ 764, [ ""BitField"", ""{\""end_bit\"":13,\""start_bit\"":12,\""target\"":\""UInt32\""}"" ]],
				 ""BreakOnTermination"": [ 764, [ ""BitField"", ""{\""end_bit\"":14,\""start_bit\"":13,\""target\"":\""UInt32\""}"" ]],
				 ""DeprioritizeViews"": [ 764, [ ""BitField"", ""{\""end_bit\"":15,\""start_bit\"":14,\""target\"":\""UInt32\""}"" ]],
				 ""WriteWatch"": [ 764, [ ""BitField"", ""{\""end_bit\"":16,\""start_bit\"":15,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessInSession"": [ 764, [ ""BitField"", ""{\""end_bit\"":17,\""start_bit\"":16,\""target\"":\""UInt32\""}"" ]],
				 ""OverrideAddressSpace"": [ 764, [ ""BitField"", ""{\""end_bit\"":18,\""start_bit\"":17,\""target\"":\""UInt32\""}"" ]],
				 ""HasAddressSpace"": [ 764, [ ""BitField"", ""{\""end_bit\"":19,\""start_bit\"":18,\""target\"":\""UInt32\""}"" ]],
				 ""LaunchPrefetched"": [ 764, [ ""BitField"", ""{\""end_bit\"":20,\""start_bit\"":19,\""target\"":\""UInt32\""}"" ]],
				 ""Background"": [ 764, [ ""BitField"", ""{\""end_bit\"":21,\""start_bit\"":20,\""target\"":\""UInt32\""}"" ]],
				 ""VmTopDown"": [ 764, [ ""BitField"", ""{\""end_bit\"":22,\""start_bit\"":21,\""target\"":\""UInt32\""}"" ]],
				 ""ImageNotifyDone"": [ 764, [ ""BitField"", ""{\""end_bit\"":23,\""start_bit\"":22,\""target\"":\""UInt32\""}"" ]],
				 ""PdeUpdateNeeded"": [ 764, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":23,\""target\"":\""UInt32\""}"" ]],
				 ""VdmAllowed"": [ 764, [ ""BitField"", ""{\""end_bit\"":25,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessRundown"": [ 764, [ ""BitField"", ""{\""end_bit\"":26,\""start_bit\"":25,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessInserted"": [ 764, [ ""BitField"", ""{\""end_bit\"":27,\""start_bit\"":26,\""target\"":\""UInt32\""}"" ]],
				 ""DefaultIoPriority"": [ 764, [ ""BitField"", ""{\""end_bit\"":30,\""start_bit\"":27,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessSelfDelete"": [ 764, [ ""BitField"", ""{\""end_bit\"":31,\""start_bit\"":30,\""target\"":\""UInt32\""}"" ]],
				 ""SetTimerResolutionLink"": [ 764, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":31,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessQuotaUsage"": [ 768, [ ""Array"", ""{\""count\"":2,\""target\"":\""UInt64\""}"" ]],
				 ""ProcessQuotaPeak"": [ 784, [ ""Array"", ""{\""count\"":2,\""target\"":\""UInt64\""}"" ]],
				 ""PeakVirtualSize"": [ 800, [ ""UInt64"", ""null"" ]],
				 ""VirtualSize"": [ 808, [ ""UInt64"", ""null"" ]],
				 ""SessionProcessLinks"": [ 816, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""ExceptionPortData"": [ 832, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ExceptionPortValue"": [ 832, [ ""UInt64"", ""null"" ]],
				 ""ExceptionPortState"": [ 832, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":0,\""target\"":\""UInt64\""}"" ]],
				 ""Token"": [ 840, [ ""_EX_FAST_REF"", ""null"" ]],
				 ""WorkingSetPage"": [ 848, [ ""UInt64"", ""null"" ]],
				 ""AddressCreationLock"": [ 856, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""PageTableCommitmentLock"": [ 864, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""RotateInProgress"": [ 872, [ ""Pointer"", ""{\""target\"":\""_ETHREAD\""}"" ]],
				 ""ForkInProgress"": [ 880, [ ""Pointer"", ""{\""target\"":\""_ETHREAD\""}"" ]],
				 ""CommitChargeJob"": [ 888, [ ""Pointer"", ""{\""target\"":\""_EJOB\""}"" ]],
				 ""CloneRoot"": [ 896, [ ""_RTL_AVL_TREE"", ""null"" ]],
				 ""NumberOfPrivatePages"": [ 904, [ ""UInt64"", ""null"" ]],
				 ""NumberOfLockedPages"": [ 912, [ ""UInt64"", ""null"" ]],
				 ""Win32Process"": [ 920, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Job"": [ 928, [ ""Pointer"", ""{\""target\"":\""_EJOB\""}"" ]],
				 ""SectionObject"": [ 936, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SectionBaseAddress"": [ 944, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Cookie"": [ 952, [ ""UInt32"", ""null"" ]],
				 ""WorkingSetWatch"": [ 960, [ ""Pointer"", ""{\""target\"":\""_PAGEFAULT_HISTORY\""}"" ]],
				 ""Win32WindowStation"": [ 968, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""InheritedFromUniqueProcessId"": [ 976, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""LdtInformation"": [ 984, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""OwnerProcessId"": [ 992, [ ""UInt64"", ""null"" ]],
				 ""Peb"": [ 1000, [ ""Pointer"", ""{\""target\"":\""_PEB\""}"" ]],
				 ""Session"": [ 1008, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""AweInfo"": [ 1016, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""QuotaBlock"": [ 1024, [ ""Pointer"", ""{\""target\"":\""_EPROCESS_QUOTA_BLOCK\""}"" ]],
				 ""ObjectTable"": [ 1032, [ ""Pointer"", ""{\""target\"":\""_HANDLE_TABLE\""}"" ]],
				 ""DebugPort"": [ 1040, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Wow64Process"": [ 1048, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""DeviceMap"": [ 1056, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""EtwDataSource"": [ 1064, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""PageDirectoryPte"": [ 1072, [ ""UInt64"", ""null"" ]],
				 ""ImageFileName"": [ 1080, [ ""Array"", ""{\""count\"":15,\""target\"":\""Byte\""}"" ]],
				 ""PriorityClass"": [ 1095, [ ""Byte"", ""null"" ]],
				 ""SecurityPort"": [ 1096, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SeAuditProcessCreationInfo"": [ 1104, [ ""_SE_AUDIT_PROCESS_CREATION_INFO"", ""null"" ]],
				 ""JobLinks"": [ 1112, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""HighestUserAddress"": [ 1128, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ThreadListHead"": [ 1136, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""ActiveThreads"": [ 1152, [ ""UInt32"", ""null"" ]],
				 ""ImagePathHash"": [ 1156, [ ""UInt32"", ""null"" ]],
				 ""DefaultHardErrorProcessing"": [ 1160, [ ""UInt32"", ""null"" ]],
				 ""LastThreadExitStatus"": [ 1164, [ ""Int32"", ""null"" ]],
				 ""PrefetchTrace"": [ 1168, [ ""_EX_FAST_REF"", ""null"" ]],
				 ""LockedPagesList"": [ 1176, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ReadOperationCount"": [ 1184, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""WriteOperationCount"": [ 1192, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""OtherOperationCount"": [ 1200, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""ReadTransferCount"": [ 1208, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""WriteTransferCount"": [ 1216, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""OtherTransferCount"": [ 1224, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""CommitCharge"": [ 1232, [ ""UInt64"", ""null"" ]],
				 ""Vm"": [ 1240, [ ""_MMSUPPORT"", ""null"" ]],
				 ""MmProcessLinks"": [ 1472, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""ModifiedPageCount"": [ 1488, [ ""UInt32"", ""null"" ]],
				 ""ExitStatus"": [ 1492, [ ""Int32"", ""null"" ]],
				 ""VadRoot"": [ 1496, [ ""_RTL_AVL_TREE"", ""null"" ]],
				 ""VadHint"": [ 1504, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""VadCount"": [ 1512, [ ""UInt64"", ""null"" ]],
				 ""VadPhysicalPages"": [ 1520, [ ""UInt64"", ""null"" ]],
				 ""VadPhysicalPagesLimit"": [ 1528, [ ""UInt64"", ""null"" ]],
				 ""AlpcContext"": [ 1536, [ ""_ALPC_PROCESS_CONTEXT"", ""null"" ]],
				 ""TimerResolutionLink"": [ 1568, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""TimerResolutionStackRecord"": [ 1584, [ ""Pointer"", ""{\""target\"":\""_PO_DIAG_STACK_RECORD\""}"" ]],
				 ""RequestedTimerResolution"": [ 1592, [ ""UInt32"", ""null"" ]],
				 ""SmallestTimerResolution"": [ 1596, [ ""UInt32"", ""null"" ]],
				 ""ExitTime"": [ 1600, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""InvertedFunctionTable"": [ 1608, [ ""Pointer"", ""{\""target\"":\""_INVERTED_FUNCTION_TABLE\""}"" ]],
				 ""InvertedFunctionTableLock"": [ 1616, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""ActiveThreadsHighWatermark"": [ 1624, [ ""UInt32"", ""null"" ]],
				 ""LargePrivateVadCount"": [ 1628, [ ""UInt32"", ""null"" ]],
				 ""ThreadListLock"": [ 1632, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""WnfContext"": [ 1640, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Spare0"": [ 1648, [ ""UInt64"", ""null"" ]],
				 ""SignatureLevel"": [ 1656, [ ""Byte"", ""null"" ]],
				 ""SectionSignatureLevel"": [ 1657, [ ""Byte"", ""null"" ]],
				 ""Protection"": [ 1658, [ ""_PS_PROTECTION"", ""null"" ]],
				 ""SpareByte20"": [ 1659, [ ""Array"", ""{\""count\"":1,\""target\"":\""Byte\""}"" ]],
				 ""Flags3"": [ 1660, [ ""UInt32"", ""null"" ]],
				 ""Minimal"": [ 1660, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""SvmReserved"": [ 1664, [ ""Int32"", ""null"" ]],
				 ""SvmReserved1"": [ 1672, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SvmReserved2"": [ 1680, [ ""UInt64"", ""null"" ]],
				 ""LastFreezeInterruptTime"": [ 1688, [ ""UInt64"", ""null"" ]],
				 ""DiskCounters"": [ 1696, [ ""Pointer"", ""{\""target\"":\""_PROCESS_DISK_COUNTERS\""}"" ]],
				 ""PicoContext"": [ 1704, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""KeepAliveCounter"": [ 1712, [ ""UInt32"", ""null"" ]],
				 ""NoWakeKeepAliveCounter"": [ 1716, [ ""UInt32"", ""null"" ]],
				 ""DeepFreezeStartTime"": [ 1720, [ ""UInt64"", ""null"" ]],
				 ""CommitChargeLimit"": [ 1728, [ ""UInt64"", ""null"" ]],
				 ""CommitChargePeak"": [ 1736, [ ""UInt64"", ""null"" ]],
				 ""HighPriorityFaultsAllowed"": [ 1744, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _KPROCESS Pcb
		{
			get
			{
				_KPROCESS returnValue = new _KPROCESS(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK ProcessLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 712);
				return returnValue;
			}
		}
		public _LARGE_INTEGER CreateTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 720);
				return returnValue;
			}
		}
		public _EX_RUNDOWN_REF RundownProtect
		{
			get
			{
				_EX_RUNDOWN_REF returnValue = new _EX_RUNDOWN_REF(_StructureData, _BufferOffset + 728);
				return returnValue;
			}
		}
		public UInt64 UniqueProcessId { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 736); } }
		public _LIST_ENTRY ActiveProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 744);
				return returnValue;
			}
		}
		public UInt32 Flags2 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 760); } }
		public UInt32 JobNotReallyActive
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 AccountingFolded
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 NewProcessReported
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 ExitProcessReported
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 ReportCommitChanges
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 LastReportMemory
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 ForceWakeCharge
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 CrossSessionCreate
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 NeedsHandleRundown
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 RefTraceEnabled
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 DisableDynamicCode
		{
			get
			{
				// start: 10  end: 11  Mask: 0000010000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 1024) >> 10;
				return (UInt32)value2;
			}
		}
		public UInt32 EmptyJobEvaluated
		{
			get
			{
				// start: 11  end: 12  Mask: 0000100000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 2048) >> 11;
				return (UInt32)value2;
			}
		}
		public UInt32 DefaultPagePriority
		{
			get
			{
				// start: 12  end: 15  Mask: 0111000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 28672) >> 12;
				return (UInt32)value2;
			}
		}
		public UInt32 PrimaryTokenFrozen
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessVerifierTarget
		{
			get
			{
				// start: 16  end: 17  Mask: 10000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 65536) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 StackRandomizationDisabled
		{
			get
			{
				// start: 17  end: 18  Mask: 100000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 131072) >> 17;
				return (UInt32)value2;
			}
		}
		public UInt32 AffinityPermanent
		{
			get
			{
				// start: 18  end: 19  Mask: 1000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 262144) >> 18;
				return (UInt32)value2;
			}
		}
		public UInt32 AffinityUpdateEnable
		{
			get
			{
				// start: 19  end: 20  Mask: 10000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 524288) >> 19;
				return (UInt32)value2;
			}
		}
		public UInt32 PropagateNode
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 ExplicitAffinity
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessExecutionState
		{
			get
			{
				// start: 22  end: 24  Mask: 110000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 12582912) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 DisallowStrippedImages
		{
			get
			{
				// start: 24  end: 25  Mask: 1000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 16777216) >> 24;
				return (UInt32)value2;
			}
		}
		public UInt32 HighEntropyASLREnabled
		{
			get
			{
				// start: 25  end: 26  Mask: 10000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 33554432) >> 25;
				return (UInt32)value2;
			}
		}
		public UInt32 ExtensionPointDisable
		{
			get
			{
				// start: 26  end: 27  Mask: 100000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 67108864) >> 26;
				return (UInt32)value2;
			}
		}
		public UInt32 ForceRelocateImages
		{
			get
			{
				// start: 27  end: 28  Mask: 1000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 134217728) >> 27;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessStateChangeRequest
		{
			get
			{
				// start: 28  end: 30  Mask: 110000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 805306368) >> 28;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessStateChangeInProgress
		{
			get
			{
				// start: 30  end: 31  Mask: 1000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 1073741824) >> 30;
				return (UInt32)value2;
			}
		}
		public UInt32 DisallowWin32kSystemCalls
		{
			get
			{
				// start: 31  end: 32  Mask: 10000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 760);
				var value2 = (value & 2147483648) >> 31;
				return (UInt32)value2;
			}
		}
		public UInt32 Flags { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 764); } }
		public UInt32 CreateReported
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 NoDebugInherit
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessExiting
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessDelete
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 ControlFlowGuardEnabled
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 VmDeleted
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 OutswapEnabled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 Outswapped
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 ForkFailed
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 Wow64VaSpace4Gb
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 AddressSpaceInitialized
		{
			get
			{
				// start: 10  end: 12  Mask: 0000110000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 3072) >> 10;
				return (UInt32)value2;
			}
		}
		public UInt32 SetTimerResolution
		{
			get
			{
				// start: 12  end: 13  Mask: 0001000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 4096) >> 12;
				return (UInt32)value2;
			}
		}
		public UInt32 BreakOnTermination
		{
			get
			{
				// start: 13  end: 14  Mask: 0010000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 8192) >> 13;
				return (UInt32)value2;
			}
		}
		public UInt32 DeprioritizeViews
		{
			get
			{
				// start: 14  end: 15  Mask: 0100000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 16384) >> 14;
				return (UInt32)value2;
			}
		}
		public UInt32 WriteWatch
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessInSession
		{
			get
			{
				// start: 16  end: 17  Mask: 10000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 65536) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 OverrideAddressSpace
		{
			get
			{
				// start: 17  end: 18  Mask: 100000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 131072) >> 17;
				return (UInt32)value2;
			}
		}
		public UInt32 HasAddressSpace
		{
			get
			{
				// start: 18  end: 19  Mask: 1000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 262144) >> 18;
				return (UInt32)value2;
			}
		}
		public UInt32 LaunchPrefetched
		{
			get
			{
				// start: 19  end: 20  Mask: 10000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 524288) >> 19;
				return (UInt32)value2;
			}
		}
		public UInt32 Background
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 VmTopDown
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 ImageNotifyDone
		{
			get
			{
				// start: 22  end: 23  Mask: 10000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 4194304) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 PdeUpdateNeeded
		{
			get
			{
				// start: 23  end: 24  Mask: 100000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 8388608) >> 23;
				return (UInt32)value2;
			}
		}
		public UInt32 VdmAllowed
		{
			get
			{
				// start: 24  end: 25  Mask: 1000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 16777216) >> 24;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessRundown
		{
			get
			{
				// start: 25  end: 26  Mask: 10000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 33554432) >> 25;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessInserted
		{
			get
			{
				// start: 26  end: 27  Mask: 100000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 67108864) >> 26;
				return (UInt32)value2;
			}
		}
		public UInt32 DefaultIoPriority
		{
			get
			{
				// start: 27  end: 30  Mask: 111000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 939524096) >> 27;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessSelfDelete
		{
			get
			{
				// start: 30  end: 31  Mask: 1000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 1073741824) >> 30;
				return (UInt32)value2;
			}
		}
		public UInt32 SetTimerResolutionLink
		{
			get
			{
				// start: 31  end: 32  Mask: 10000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 764);
				var value2 = (value & 2147483648) >> 31;
				return (UInt32)value2;
			}
		}
		public UInt64[] ProcessQuotaUsage
		{
			get
			{
				UInt64[] returnValue = new UInt64[2];
				for(int i=0; i<2; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 768);
				return returnValue;
			}
		}
		public UInt64[] ProcessQuotaPeak
		{
			get
			{
				UInt64[] returnValue = new UInt64[2];
				for(int i=0; i<2; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 784);
				return returnValue;
			}
		}
		public UInt64 PeakVirtualSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 800); } }
		public UInt64 VirtualSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 808); } }
		public _LIST_ENTRY SessionProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 816);
				return returnValue;
			}
		}
		public UInt64 ExceptionPortData { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 832); } }
		public UInt64 ExceptionPortValue { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 832); } }
		public UInt64 ExceptionPortState
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 832);
				var value2 = (value & 7) >> 0;
				return (UInt64)value2;
			}
		}
		public _EX_FAST_REF Token
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 840);
				return returnValue;
			}
		}
		public UInt64 WorkingSetPage { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 848); } }
		public _EX_PUSH_LOCK AddressCreationLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 856);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK PageTableCommitmentLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 864);
				return returnValue;
			}
		}
		public UInt64 RotateInProgress { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 872); } }
		public UInt64 ForkInProgress { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 880); } }
		public UInt64 CommitChargeJob { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 888); } }
		public _RTL_AVL_TREE CloneRoot
		{
			get
			{
				_RTL_AVL_TREE returnValue = new _RTL_AVL_TREE(_StructureData, _BufferOffset + 896);
				return returnValue;
			}
		}
		public UInt64 NumberOfPrivatePages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 904); } }
		public UInt64 NumberOfLockedPages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 912); } }
		public UInt64 Win32Process { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 920); } }
		public UInt64 Job { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 928); } }
		public UInt64 SectionObject { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 936); } }
		public UInt64 SectionBaseAddress { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 944); } }
		public UInt32 Cookie { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 952); } }
		public UInt64 WorkingSetWatch { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 960); } }
		public UInt64 Win32WindowStation { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 968); } }
		public UInt64 InheritedFromUniqueProcessId { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 976); } }
		public UInt64 LdtInformation { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 984); } }
		public UInt64 OwnerProcessId { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 992); } }
		public UInt64 Peb { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1000); } }
		public UInt64 Session { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1008); } }
		public UInt64 AweInfo { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1016); } }
		public UInt64 QuotaBlock { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1024); } }
		public UInt64 ObjectTable { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1032); } }
		public UInt64 DebugPort { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1040); } }
		public UInt64 Wow64Process { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1048); } }
		public UInt64 DeviceMap { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1056); } }
		public UInt64 EtwDataSource { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1064); } }
		public UInt64 PageDirectoryPte { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1072); } }
		public Byte[] ImageFileName
		{
			get
			{
				Byte[] returnValue = new Byte[15];
				for(int i=0; i<15; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 1080];
				return returnValue;
			}
		}
		public Byte PriorityClass{ get { return _StructureData[_BufferOffset +1095]; } }
		public UInt64 SecurityPort { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1096); } }
		public _SE_AUDIT_PROCESS_CREATION_INFO SeAuditProcessCreationInfo
		{
			get
			{
				_SE_AUDIT_PROCESS_CREATION_INFO returnValue = new _SE_AUDIT_PROCESS_CREATION_INFO(_StructureData, _BufferOffset + 1104);
				return returnValue;
			}
		}
		public _LIST_ENTRY JobLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1112);
				return returnValue;
			}
		}
		public UInt64 HighestUserAddress { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1128); } }
		public _LIST_ENTRY ThreadListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1136);
				return returnValue;
			}
		}
		public UInt32 ActiveThreads { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1152); } }
		public UInt32 ImagePathHash { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1156); } }
		public UInt32 DefaultHardErrorProcessing { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1160); } }
		public Int32 LastThreadExitStatus { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1164); } }
		public _EX_FAST_REF PrefetchTrace
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 1168);
				return returnValue;
			}
		}
		public UInt64 LockedPagesList { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1176); } }
		public _LARGE_INTEGER ReadOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1184);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1192);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1200);
				return returnValue;
			}
		}
		public _LARGE_INTEGER ReadTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1208);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1216);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1224);
				return returnValue;
			}
		}
		public UInt64 CommitCharge { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1232); } }
		public _MMSUPPORT Vm
		{
			get
			{
				_MMSUPPORT returnValue = new _MMSUPPORT(_StructureData, _BufferOffset + 1240);
				return returnValue;
			}
		}
		public _LIST_ENTRY MmProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1472);
				return returnValue;
			}
		}
		public UInt32 ModifiedPageCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1488); } }
		public Int32 ExitStatus { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1492); } }
		public _RTL_AVL_TREE VadRoot
		{
			get
			{
				_RTL_AVL_TREE returnValue = new _RTL_AVL_TREE(_StructureData, _BufferOffset + 1496);
				return returnValue;
			}
		}
		public UInt64 VadHint { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1504); } }
		public UInt64 VadCount { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1512); } }
		public UInt64 VadPhysicalPages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1520); } }
		public UInt64 VadPhysicalPagesLimit { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1528); } }
		public _ALPC_PROCESS_CONTEXT AlpcContext
		{
			get
			{
				_ALPC_PROCESS_CONTEXT returnValue = new _ALPC_PROCESS_CONTEXT(_StructureData, _BufferOffset + 1536);
				return returnValue;
			}
		}
		public _LIST_ENTRY TimerResolutionLink
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 1568);
				return returnValue;
			}
		}
		public UInt64 TimerResolutionStackRecord { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1584); } }
		public UInt32 RequestedTimerResolution { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1592); } }
		public UInt32 SmallestTimerResolution { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1596); } }
		public _LARGE_INTEGER ExitTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 1600);
				return returnValue;
			}
		}
		public UInt64 InvertedFunctionTable { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1608); } }
		public _EX_PUSH_LOCK InvertedFunctionTableLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1616);
				return returnValue;
			}
		}
		public UInt32 ActiveThreadsHighWatermark { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1624); } }
		public UInt32 LargePrivateVadCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1628); } }
		public _EX_PUSH_LOCK ThreadListLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 1632);
				return returnValue;
			}
		}
		public UInt64 WnfContext { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1640); } }
		public UInt64 Spare0 { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1648); } }
		public Byte SignatureLevel{ get { return _StructureData[_BufferOffset +1656]; } }
		public Byte SectionSignatureLevel{ get { return _StructureData[_BufferOffset +1657]; } }
		public _PS_PROTECTION Protection
		{
			get
			{
				_PS_PROTECTION returnValue = new _PS_PROTECTION(_StructureData, _BufferOffset + 1658);
				return returnValue;
			}
		}
		public Byte[] SpareByte20
		{
			get
			{
				Byte[] returnValue = new Byte[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 1659];
				return returnValue;
			}
		}
		public UInt32 Flags3 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1660); } }
		public UInt32 Minimal
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 1660);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public Int32 SvmReserved { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 1664); } }
		public UInt64 SvmReserved1 { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1672); } }
		public UInt64 SvmReserved2 { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1680); } }
		public UInt64 LastFreezeInterruptTime { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1688); } }
		public UInt64 DiskCounters { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1696); } }
		public UInt64 PicoContext { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1704); } }
		public UInt32 KeepAliveCounter { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1712); } }
		public UInt32 NoWakeKeepAliveCounter { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1716); } }
		public UInt64 DeepFreezeStartTime { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1720); } }
		public UInt64 CommitChargeLimit { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1728); } }
		public UInt64 CommitChargePeak { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 1736); } }
		public UInt32 HighPriorityFaultsAllowed { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 1744); } }
	}
	#endregion
	#region _KUSER_SHARED_DATA
 
	public class _KUSER_SHARED_DATA
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KUSER_SHARED_DATA(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 1520; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KUSER_SHARED_DATA"": [ 1520, {
				 ""TickCountLowDeprecated"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""TickCountMultiplier"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""InterruptTime"": [ 8, [ ""_KSYSTEM_TIME"", ""null"" ]],
				 ""SystemTime"": [ 20, [ ""_KSYSTEM_TIME"", ""null"" ]],
				 ""TimeZoneBias"": [ 32, [ ""_KSYSTEM_TIME"", ""null"" ]],
				 ""ImageNumberLow"": [ 44, [ ""UInt16"", ""null"" ]],
				 ""ImageNumberHigh"": [ 46, [ ""UInt16"", ""null"" ]],
				 ""NtSystemRoot"": [ 48, [ ""Array"", ""{\""count\"":260,\""target\"":\""UInt16\""}"" ]],
				 ""MaxStackTraceDepth"": [ 568, [ ""UInt32"", ""null"" ]],
				 ""CryptoExponent"": [ 572, [ ""UInt32"", ""null"" ]],
				 ""TimeZoneId"": [ 576, [ ""UInt32"", ""null"" ]],
				 ""LargePageMinimum"": [ 580, [ ""UInt32"", ""null"" ]],
				 ""AitSamplingValue"": [ 584, [ ""UInt32"", ""null"" ]],
				 ""AppCompatFlag"": [ 588, [ ""UInt32"", ""null"" ]],
				 ""RNGSeedVersion"": [ 592, [ ""UInt64"", ""null"" ]],
				 ""GlobalValidationRunlevel"": [ 600, [ ""UInt32"", ""null"" ]],
				 ""TimeZoneBiasStamp"": [ 604, [ ""Int32"", ""null"" ]],
				 ""Reserved2"": [ 608, [ ""UInt32"", ""null"" ]],
				 ""NtProductType"": [ 612, [ ""Enumeration"", ""{\""enum_name\"":\""_NT_PRODUCT_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""ProductTypeIsValid"": [ 616, [ ""Byte"", ""null"" ]],
				 ""Reserved0"": [ 617, [ ""Array"", ""{\""count\"":1,\""target\"":\""Byte\""}"" ]],
				 ""NativeProcessorArchitecture"": [ 618, [ ""UInt16"", ""null"" ]],
				 ""NtMajorVersion"": [ 620, [ ""UInt32"", ""null"" ]],
				 ""NtMinorVersion"": [ 624, [ ""UInt32"", ""null"" ]],
				 ""ProcessorFeatures"": [ 628, [ ""Array"", ""{\""count\"":64,\""target\"":\""Byte\""}"" ]],
				 ""Reserved1"": [ 692, [ ""UInt32"", ""null"" ]],
				 ""Reserved3"": [ 696, [ ""UInt32"", ""null"" ]],
				 ""TimeSlip"": [ 700, [ ""UInt32"", ""null"" ]],
				 ""AlternativeArchitecture"": [ 704, [ ""Enumeration"", ""{\""enum_name\"":\""_ALTERNATIVE_ARCHITECTURE_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""AltArchitecturePad"": [ 708, [ ""Array"", ""{\""count\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""SystemExpirationDate"": [ 712, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""SuiteMask"": [ 720, [ ""UInt32"", ""null"" ]],
				 ""KdDebuggerEnabled"": [ 724, [ ""Byte"", ""null"" ]],
				 ""MitigationPolicies"": [ 725, [ ""Byte"", ""null"" ]],
				 ""NXSupportPolicy"": [ 725, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""SEHValidationPolicy"": [ 725, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""CurDirDevicesSkippedForDlls"": [ 725, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""Reserved"": [ 725, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""Reserved6"": [ 726, [ ""Array"", ""{\""count\"":2,\""target\"":\""Byte\""}"" ]],
				 ""ActiveConsoleId"": [ 728, [ ""UInt32"", ""null"" ]],
				 ""DismountCount"": [ 732, [ ""UInt32"", ""null"" ]],
				 ""ComPlusPackage"": [ 736, [ ""UInt32"", ""null"" ]],
				 ""LastSystemRITEventTickCount"": [ 740, [ ""UInt32"", ""null"" ]],
				 ""NumberOfPhysicalPages"": [ 744, [ ""UInt32"", ""null"" ]],
				 ""SafeBootMode"": [ 748, [ ""Byte"", ""null"" ]],
				 ""Reserved12"": [ 749, [ ""Array"", ""{\""count\"":3,\""target\"":\""Byte\""}"" ]],
				 ""SharedDataFlags"": [ 752, [ ""UInt32"", ""null"" ]],
				 ""DbgErrorPortPresent"": [ 752, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""DbgElevationEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""DbgVirtEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""DbgInstallerDetectEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""DbgLkgEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""DbgDynProcessorEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""DbgConsoleBrokerEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""DbgSecureBootEnabled"": [ 752, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""UInt32\""}"" ]],
				 ""SpareBits"": [ 752, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""DataFlagsPad"": [ 756, [ ""Array"", ""{\""count\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""TestRetInstruction"": [ 760, [ ""UInt64"", ""null"" ]],
				 ""QpcFrequency"": [ 768, [ ""Int64"", ""null"" ]],
				 ""SystemCallPad"": [ 776, [ ""Array"", ""{\""count\"":3,\""target\"":\""UInt64\""}"" ]],
				 ""TickCount"": [ 800, [ ""_KSYSTEM_TIME"", ""null"" ]],
				 ""TickCountQuad"": [ 800, [ ""UInt64"", ""null"" ]],
				 ""ReservedTickCountOverlay"": [ 800, [ ""Array"", ""{\""count\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""TickCountPad"": [ 812, [ ""Array"", ""{\""count\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""Cookie"": [ 816, [ ""UInt32"", ""null"" ]],
				 ""CookiePad"": [ 820, [ ""Array"", ""{\""count\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""ConsoleSessionForegroundProcessId"": [ 824, [ ""Int64"", ""null"" ]],
				 ""TimeUpdateLock"": [ 832, [ ""UInt64"", ""null"" ]],
				 ""BaselineSystemTimeQpc"": [ 840, [ ""UInt64"", ""null"" ]],
				 ""BaselineInterruptTimeQpc"": [ 848, [ ""UInt64"", ""null"" ]],
				 ""QpcSystemTimeIncrement"": [ 856, [ ""UInt64"", ""null"" ]],
				 ""QpcInterruptTimeIncrement"": [ 864, [ ""UInt64"", ""null"" ]],
				 ""QpcSystemTimeIncrement32"": [ 872, [ ""UInt32"", ""null"" ]],
				 ""QpcInterruptTimeIncrement32"": [ 876, [ ""UInt32"", ""null"" ]],
				 ""QpcSystemTimeIncrementShift"": [ 880, [ ""Byte"", ""null"" ]],
				 ""QpcInterruptTimeIncrementShift"": [ 881, [ ""Byte"", ""null"" ]],
				 ""UnparkedProcessorCount"": [ 882, [ ""UInt16"", ""null"" ]],
				 ""Reserved8"": [ 884, [ ""Array"", ""{\""count\"":12,\""target\"":\""Byte\""}"" ]],
				 ""UserModeGlobalLogger"": [ 896, [ ""Array"", ""{\""count\"":16,\""target\"":\""UInt16\""}"" ]],
				 ""ImageFileExecutionOptions"": [ 928, [ ""UInt32"", ""null"" ]],
				 ""LangGenerationCount"": [ 932, [ ""UInt32"", ""null"" ]],
				 ""Reserved4"": [ 936, [ ""UInt64"", ""null"" ]],
				 ""InterruptTimeBias"": [ 944, [ ""UInt64"", ""null"" ]],
				 ""QpcBias"": [ 952, [ ""UInt64"", ""null"" ]],
				 ""ActiveProcessorCount"": [ 960, [ ""UInt32"", ""null"" ]],
				 ""ActiveGroupCount"": [ 964, [ ""Byte"", ""null"" ]],
				 ""Reserved9"": [ 965, [ ""Byte"", ""null"" ]],
				 ""QpcData"": [ 966, [ ""UInt16"", ""null"" ]],
				 ""QpcBypassEnabled"": [ 966, [ ""Byte"", ""null"" ]],
				 ""QpcShift"": [ 967, [ ""Byte"", ""null"" ]],
				 ""TimeZoneBiasEffectiveStart"": [ 968, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""TimeZoneBiasEffectiveEnd"": [ 976, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""XState"": [ 984, [ ""_XSTATE_CONFIGURATION"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 TickCountLowDeprecated { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 TickCountMultiplier { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public _KSYSTEM_TIME InterruptTime
		{
			get
			{
				_KSYSTEM_TIME returnValue = new _KSYSTEM_TIME(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
		public _KSYSTEM_TIME SystemTime
		{
			get
			{
				_KSYSTEM_TIME returnValue = new _KSYSTEM_TIME(_StructureData, _BufferOffset + 20);
				return returnValue;
			}
		}
		public _KSYSTEM_TIME TimeZoneBias
		{
			get
			{
				_KSYSTEM_TIME returnValue = new _KSYSTEM_TIME(_StructureData, _BufferOffset + 32);
				return returnValue;
			}
		}
		public UInt16 ImageNumberLow { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 44); } }
		public UInt16 ImageNumberHigh { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 46); } }
		public UInt16[] NtSystemRoot
		{
			get
			{
				UInt16[] returnValue = new UInt16[260];
				for(int i=0; i<260; i++ )
					returnValue[i] = BitConverter.ToUInt16(_StructureData, (i * sizeof(UInt16)) + _BufferOffset + 48);
				return returnValue;
			}
		}
		public UInt32 MaxStackTraceDepth { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 568); } }
		public UInt32 CryptoExponent { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 572); } }
		public UInt32 TimeZoneId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 576); } }
		public UInt32 LargePageMinimum { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 580); } }
		public UInt32 AitSamplingValue { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 584); } }
		public UInt32 AppCompatFlag { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 588); } }
		public UInt64 RNGSeedVersion { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 592); } }
		public UInt32 GlobalValidationRunlevel { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 600); } }
		public Int32 TimeZoneBiasStamp { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 604); } }
		public UInt32 Reserved2 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 608); } }
		public _NT_PRODUCT_TYPE NtProductType { get { return (_NT_PRODUCT_TYPE)BitConverter.ToUInt32(_StructureData, _BufferOffset + 612); } }
		public Byte ProductTypeIsValid{ get { return _StructureData[_BufferOffset +616]; } }
		public Byte[] Reserved0
		{
			get
			{
				Byte[] returnValue = new Byte[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 617];
				return returnValue;
			}
		}
		public UInt16 NativeProcessorArchitecture { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 618); } }
		public UInt32 NtMajorVersion { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 620); } }
		public UInt32 NtMinorVersion { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 624); } }
		public Byte[] ProcessorFeatures
		{
			get
			{
				Byte[] returnValue = new Byte[64];
				for(int i=0; i<64; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 628];
				return returnValue;
			}
		}
		public UInt32 Reserved1 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 692); } }
		public UInt32 Reserved3 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 696); } }
		public UInt32 TimeSlip { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 700); } }
		public _ALTERNATIVE_ARCHITECTURE_TYPE AlternativeArchitecture { get { return (_ALTERNATIVE_ARCHITECTURE_TYPE)BitConverter.ToUInt32(_StructureData, _BufferOffset + 704); } }
		public UInt32[] AltArchitecturePad
		{
			get
			{
				UInt32[] returnValue = new UInt32[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 708);
				return returnValue;
			}
		}
		public _LARGE_INTEGER SystemExpirationDate
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 712);
				return returnValue;
			}
		}
		public UInt32 SuiteMask { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 720); } }
		public Byte KdDebuggerEnabled{ get { return _StructureData[_BufferOffset +724]; } }
		public Byte MitigationPolicies{ get { return _StructureData[_BufferOffset +725]; } }
		public Byte NXSupportPolicy
		{
			get
			{
				// start: 0  end: 2  Mask: 0000000000000011
				Byte value = _StructureData[_BufferOffset + 725];
				var value2 = (value & 3) >> 0;
				return (Byte)value2;
			}
		}
		public Byte SEHValidationPolicy
		{
			get
			{
				// start: 2  end: 4  Mask: 0000000000001100
				Byte value = _StructureData[_BufferOffset + 725];
				var value2 = (value & 12) >> 2;
				return (Byte)value2;
			}
		}
		public Byte CurDirDevicesSkippedForDlls
		{
			get
			{
				// start: 4  end: 6  Mask: 0000000000110000
				Byte value = _StructureData[_BufferOffset + 725];
				var value2 = (value & 48) >> 4;
				return (Byte)value2;
			}
		}
		public Byte Reserved
		{
			get
			{
				// start: 6  end: 8  Mask: 0000000011000000
				Byte value = _StructureData[_BufferOffset + 725];
				var value2 = (value & 192) >> 6;
				return (Byte)value2;
			}
		}
		public Byte[] Reserved6
		{
			get
			{
				Byte[] returnValue = new Byte[2];
				for(int i=0; i<2; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 726];
				return returnValue;
			}
		}
		public UInt32 ActiveConsoleId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 728); } }
		public UInt32 DismountCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 732); } }
		public UInt32 ComPlusPackage { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 736); } }
		public UInt32 LastSystemRITEventTickCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 740); } }
		public UInt32 NumberOfPhysicalPages { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 744); } }
		public Byte SafeBootMode{ get { return _StructureData[_BufferOffset +748]; } }
		public Byte[] Reserved12
		{
			get
			{
				Byte[] returnValue = new Byte[3];
				for(int i=0; i<3; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 749];
				return returnValue;
			}
		}
		public UInt32 SharedDataFlags { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 752); } }
		public UInt32 DbgErrorPortPresent
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgElevationEnabled
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgVirtEnabled
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgInstallerDetectEnabled
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgLkgEnabled
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgDynProcessorEnabled
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgConsoleBrokerEnabled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 DbgSecureBootEnabled
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 SpareBits
		{
			get
			{
				// start: 8  end: 32  Mask: 11111111111111111111111100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 752);
				var value2 = (value & 4294967040) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32[] DataFlagsPad
		{
			get
			{
				UInt32[] returnValue = new UInt32[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 756);
				return returnValue;
			}
		}
		public UInt64 TestRetInstruction { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 760); } }
		public Int64 QpcFrequency { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 768); } }
		public UInt64[] SystemCallPad
		{
			get
			{
				UInt64[] returnValue = new UInt64[3];
				for(int i=0; i<3; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 776);
				return returnValue;
			}
		}
		public _KSYSTEM_TIME TickCount
		{
			get
			{
				_KSYSTEM_TIME returnValue = new _KSYSTEM_TIME(_StructureData, _BufferOffset + 800);
				return returnValue;
			}
		}
		public UInt64 TickCountQuad { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 800); } }
		public UInt32[] ReservedTickCountOverlay
		{
			get
			{
				UInt32[] returnValue = new UInt32[3];
				for(int i=0; i<3; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 800);
				return returnValue;
			}
		}
		public UInt32[] TickCountPad
		{
			get
			{
				UInt32[] returnValue = new UInt32[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 812);
				return returnValue;
			}
		}
		public UInt32 Cookie { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 816); } }
		public UInt32[] CookiePad
		{
			get
			{
				UInt32[] returnValue = new UInt32[1];
				for(int i=0; i<1; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 820);
				return returnValue;
			}
		}
		public Int64 ConsoleSessionForegroundProcessId { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 824); } }
		public UInt64 TimeUpdateLock { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 832); } }
		public UInt64 BaselineSystemTimeQpc { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 840); } }
		public UInt64 BaselineInterruptTimeQpc { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 848); } }
		public UInt64 QpcSystemTimeIncrement { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 856); } }
		public UInt64 QpcInterruptTimeIncrement { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 864); } }
		public UInt32 QpcSystemTimeIncrement32 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 872); } }
		public UInt32 QpcInterruptTimeIncrement32 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 876); } }
		public Byte QpcSystemTimeIncrementShift{ get { return _StructureData[_BufferOffset +880]; } }
		public Byte QpcInterruptTimeIncrementShift{ get { return _StructureData[_BufferOffset +881]; } }
		public UInt16 UnparkedProcessorCount { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 882); } }
		public Byte[] Reserved8
		{
			get
			{
				Byte[] returnValue = new Byte[12];
				for(int i=0; i<12; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 884];
				return returnValue;
			}
		}
		public UInt16[] UserModeGlobalLogger
		{
			get
			{
				UInt16[] returnValue = new UInt16[16];
				for(int i=0; i<16; i++ )
					returnValue[i] = BitConverter.ToUInt16(_StructureData, (i * sizeof(UInt16)) + _BufferOffset + 896);
				return returnValue;
			}
		}
		public UInt32 ImageFileExecutionOptions { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 928); } }
		public UInt32 LangGenerationCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 932); } }
		public UInt64 Reserved4 { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 936); } }
		public UInt64 InterruptTimeBias { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 944); } }
		public UInt64 QpcBias { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 952); } }
		public UInt32 ActiveProcessorCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 960); } }
		public Byte ActiveGroupCount{ get { return _StructureData[_BufferOffset +964]; } }
		public Byte Reserved9{ get { return _StructureData[_BufferOffset +965]; } }
		public UInt16 QpcData { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 966); } }
		public Byte QpcBypassEnabled{ get { return _StructureData[_BufferOffset +966]; } }
		public Byte QpcShift{ get { return _StructureData[_BufferOffset +967]; } }
		public _LARGE_INTEGER TimeZoneBiasEffectiveStart
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 968);
				return returnValue;
			}
		}
		public _LARGE_INTEGER TimeZoneBiasEffectiveEnd
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 976);
				return returnValue;
			}
		}
		public _XSTATE_CONFIGURATION XState
		{
			get
			{
				_XSTATE_CONFIGURATION returnValue = new _XSTATE_CONFIGURATION(_StructureData, _BufferOffset + 984);
				return returnValue;
			}
		}
	}
	#endregion
	#region _OBJECT_TYPE
 
	public class _OBJECT_TYPE
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_TYPE(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 216; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_TYPE"": [ 216, {
				 ""TypeList"": [ 0, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""Name"": [ 16, [ ""_UNICODE_STRING"", ""null"" ]],
				 ""DefaultObject"": [ 32, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Index"": [ 40, [ ""Byte"", ""null"" ]],
				 ""TotalNumberOfObjects"": [ 44, [ ""UInt32"", ""null"" ]],
				 ""TotalNumberOfHandles"": [ 48, [ ""UInt32"", ""null"" ]],
				 ""HighWaterNumberOfObjects"": [ 52, [ ""UInt32"", ""null"" ]],
				 ""HighWaterNumberOfHandles"": [ 56, [ ""UInt32"", ""null"" ]],
				 ""TypeInfo"": [ 64, [ ""_OBJECT_TYPE_INITIALIZER"", ""null"" ]],
				 ""TypeLock"": [ 184, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""Key"": [ 192, [ ""UInt32"", ""null"" ]],
				 ""CallbackList"": [ 200, [ ""_LIST_ENTRY"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _LIST_ENTRY TypeList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _UNICODE_STRING Name
		{
			get
			{
				_UNICODE_STRING returnValue = new _UNICODE_STRING(_StructureData, _BufferOffset + 16);
				return returnValue;
			}
		}
		public UInt64 DefaultObject { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 32); } }
		public Byte Index{ get { return _StructureData[_BufferOffset +40]; } }
		public UInt32 TotalNumberOfObjects { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 44); } }
		public UInt32 TotalNumberOfHandles { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
		public UInt32 HighWaterNumberOfObjects { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 52); } }
		public UInt32 HighWaterNumberOfHandles { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 56); } }
		public _OBJECT_TYPE_INITIALIZER TypeInfo
		{
			get
			{
				_OBJECT_TYPE_INITIALIZER returnValue = new _OBJECT_TYPE_INITIALIZER(_StructureData, _BufferOffset + 64);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK TypeLock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 184);
				return returnValue;
			}
		}
		public UInt32 Key { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 192); } }
		public _LIST_ENTRY CallbackList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 200);
				return returnValue;
			}
		}
	}
	#endregion
	#region _OBJECT_HEADER
 
	public class _OBJECT_HEADER
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 56; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER"": [ 56, {
				 ""PointerCount"": [ 0, [ ""Int64"", ""null"" ]],
				 ""HandleCount"": [ 8, [ ""Int64"", ""null"" ]],
				 ""NextToFree"": [ 8, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Lock"": [ 16, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""TypeIndex"": [ 24, [ ""Byte"", ""null"" ]],
				 ""TraceFlags"": [ 25, [ ""Byte"", ""null"" ]],
				 ""DbgRefTrace"": [ 25, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""DbgTracePermanent"": [ 25, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""InfoMask"": [ 26, [ ""Byte"", ""null"" ]],
				 ""Flags"": [ 27, [ ""Byte"", ""null"" ]],
				 ""NewObject"": [ 27, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""KernelObject"": [ 27, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""KernelOnlyAccess"": [ 27, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""ExclusiveObject"": [ 27, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""PermanentObject"": [ 27, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""DefaultSecurityQuota"": [ 27, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""Byte\""}"" ]],
				 ""SingleHandleEntry"": [ 27, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""DeletedInline"": [ 27, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""Spare"": [ 28, [ ""UInt32"", ""null"" ]],
				 ""ObjectCreateInfo"": [ 32, [ ""Pointer"", ""{\""target\"":\""_OBJECT_CREATE_INFORMATION\""}"" ]],
				 ""QuotaBlockCharged"": [ 32, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SecurityDescriptor"": [ 40, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Body"": [ 48, [ ""_QUAD"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int64 PointerCount { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 0); } }
		public Int64 HandleCount { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 8); } }
		public UInt64 NextToFree { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
		public _EX_PUSH_LOCK Lock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 16);
				return returnValue;
			}
		}
		public Byte TypeIndex{ get { return _StructureData[_BufferOffset +24]; } }
		public Byte TraceFlags{ get { return _StructureData[_BufferOffset +25]; } }
		public Byte DbgRefTrace
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 25];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte DbgTracePermanent
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 25];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte InfoMask{ get { return _StructureData[_BufferOffset +26]; } }
		public Byte Flags{ get { return _StructureData[_BufferOffset +27]; } }
		public Byte NewObject
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte KernelObject
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte KernelOnlyAccess
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte ExclusiveObject
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte PermanentObject
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 16) >> 4;
				return (Byte)value2;
			}
		}
		public Byte DefaultSecurityQuota
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 32) >> 5;
				return (Byte)value2;
			}
		}
		public Byte SingleHandleEntry
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte DeletedInline
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 27];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public UInt32 Spare { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 28); } }
		public UInt64 ObjectCreateInfo { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 32); } }
		public UInt64 QuotaBlockCharged { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 32); } }
		public UInt64 SecurityDescriptor { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 40); } }
		public _QUAD Body
		{
			get
			{
				_QUAD returnValue = new _QUAD(_StructureData, _BufferOffset + 48);
				return returnValue;
			}
		}
	}
	#endregion
	#region _OBJECT_DIRECTORY_ENTRY
 
	public class _OBJECT_DIRECTORY_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_DIRECTORY_ENTRY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 24; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_DIRECTORY_ENTRY"": [ 24, {
				 ""ChainLink"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_DIRECTORY_ENTRY\""}"" ]],
				 ""Object"": [ 8, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""HashValue"": [ 16, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 ChainLink { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Object { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
		public UInt32 HashValue { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
	}
	#endregion
	#region _OBJECT_DIRECTORY
 
	public class _OBJECT_DIRECTORY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_DIRECTORY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 336; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_DIRECTORY"": [ 336, {
				 ""HashBuckets"": [ 0, [ ""Array"", ""{\""count\"":37,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""_OBJECT_DIRECTORY_ENTRY\""}}"" ]],
				 ""Lock"": [ 296, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""DeviceMap"": [ 304, [ ""Pointer"", ""{\""target\"":\""_DEVICE_MAP\""}"" ]],
				 ""ShadowDirectory"": [ 304, [ ""Pointer"", ""{\""target\"":\""_OBJECT_DIRECTORY\""}"" ]],
				 ""SessionId"": [ 312, [ ""UInt32"", ""null"" ]],
				 ""NamespaceEntry"": [ 320, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Flags"": [ 328, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64[] HashBuckets
		{
			get
			{
				UInt64[] returnValue = new UInt64[37];
				int size = 8;
				for(int i=0; i<37; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * size) + _BufferOffset + 0);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK Lock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 296);
				return returnValue;
			}
		}
		public UInt64 DeviceMap { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 304); } }
		public UInt64 ShadowDirectory { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 304); } }
		public UInt32 SessionId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 312); } }
		public UInt64 NamespaceEntry { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 320); } }
		public UInt32 Flags { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 328); } }
	}
	#endregion
	#region _OBJECT_HEADER_CREATOR_INFO
 
	public class _OBJECT_HEADER_CREATOR_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_CREATOR_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_CREATOR_INFO"": [ 32, {
				 ""TypeList"": [ 0, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""CreatorUniqueProcess"": [ 16, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CreatorBackTraceIndex"": [ 24, [ ""UInt16"", ""null"" ]],
				 ""Reserved"": [ 26, [ ""UInt16"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _LIST_ENTRY TypeList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public UInt64 CreatorUniqueProcess { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 16); } }
		public UInt16 CreatorBackTraceIndex { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 24); } }
		public UInt16 Reserved { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 26); } }
	}
	#endregion
	#region _OBJECT_HEADER_NAME_INFO
 
	public class _OBJECT_HEADER_NAME_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_NAME_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_NAME_INFO"": [ 32, {
				 ""Directory"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_DIRECTORY\""}"" ]],
				 ""Name"": [ 8, [ ""_UNICODE_STRING"", ""null"" ]],
				 ""ReferenceCount"": [ 24, [ ""Int32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Directory { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public _UNICODE_STRING Name
		{
			get
			{
				_UNICODE_STRING returnValue = new _UNICODE_STRING(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
		public Int32 ReferenceCount { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 24); } }
	}
	#endregion
	#region _OBJECT_HEADER_HANDLE_INFO
 
	public class _OBJECT_HEADER_HANDLE_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_HANDLE_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_HANDLE_INFO"": [ 16, {
				 ""HandleCountDataBase"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_HANDLE_COUNT_DATABASE\""}"" ]],
				 ""SingleEntry"": [ 0, [ ""_OBJECT_HANDLE_COUNT_ENTRY"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 HandleCountDataBase { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public _OBJECT_HANDLE_COUNT_ENTRY SingleEntry
		{
			get
			{
				_OBJECT_HANDLE_COUNT_ENTRY returnValue = new _OBJECT_HANDLE_COUNT_ENTRY(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
	}
	#endregion
	#region _OBJECT_HEADER_QUOTA_INFO
 
	public class _OBJECT_HEADER_QUOTA_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_QUOTA_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_QUOTA_INFO"": [ 32, {
				 ""PagedPoolCharge"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""NonPagedPoolCharge"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""SecurityDescriptorCharge"": [ 8, [ ""UInt32"", ""null"" ]],
				 ""SecurityDescriptorQuotaBlock"": [ 16, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Reserved"": [ 24, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 PagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 NonPagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 SecurityDescriptorCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public UInt64 SecurityDescriptorQuotaBlock { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 16); } }
		public UInt64 Reserved { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 24); } }
	}
	#endregion
	#region _OBJECT_HEADER_PROCESS_INFO
 
	public class _OBJECT_HEADER_PROCESS_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_PROCESS_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_PROCESS_INFO"": [ 16, {
				 ""ExclusiveProcess"": [ 0, [ ""Pointer"", ""{\""target\"":\""_EPROCESS\""}"" ]],
				 ""Reserved"": [ 8, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 ExclusiveProcess { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Reserved { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _OBJECT_HEADER_AUDIT_INFO
 
	public class _OBJECT_HEADER_AUDIT_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HEADER_AUDIT_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_AUDIT_INFO"": [ 16, {
				 ""SecurityDescriptor"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Reserved"": [ 8, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 SecurityDescriptor { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Reserved { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _KPROCESS
 
	public class _KPROCESS
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KPROCESS(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 712; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KPROCESS"": [ 712, {
				 ""Header"": [ 0, [ ""_DISPATCHER_HEADER"", ""null"" ]],
				 ""ProfileListHead"": [ 24, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""DirectoryTableBase"": [ 40, [ ""UInt64"", ""null"" ]],
				 ""ThreadListHead"": [ 48, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""ProcessLock"": [ 64, [ ""UInt32"", ""null"" ]],
				 ""Spare0"": [ 68, [ ""UInt32"", ""null"" ]],
				 ""Affinity"": [ 72, [ ""_KAFFINITY_EX"", ""null"" ]],
				 ""ReadyListHead"": [ 240, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""SwapListEntry"": [ 256, [ ""_SINGLE_LIST_ENTRY"", ""null"" ]],
				 ""ActiveProcessors"": [ 264, [ ""_KAFFINITY_EX"", ""null"" ]],
				 ""AutoAlignment"": [ 432, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Int32\""}"" ]],
				 ""DisableBoost"": [ 432, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Int32\""}"" ]],
				 ""DisableQuantum"": [ 432, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Int32\""}"" ]],
				 ""AffinitySet"": [ 432, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Int32\""}"" ]],
				 ""DeepFreeze"": [ 432, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""TimerVirtualization"": [ 432, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""CheckStackExtents"": [ 432, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""ActiveGroupsMask"": [ 432, [ ""BitField"", ""{\""end_bit\"":27,\""start_bit\"":7,\""target\"":\""UInt32\""}"" ]],
				 ""ReservedFlags"": [ 432, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":27,\""target\"":\""Int32\""}"" ]],
				 ""ProcessFlags"": [ 432, [ ""Int32"", ""null"" ]],
				 ""BasePriority"": [ 436, [ ""Char"", ""null"" ]],
				 ""QuantumReset"": [ 437, [ ""Char"", ""null"" ]],
				 ""Visited"": [ 438, [ ""Byte"", ""null"" ]],
				 ""Flags"": [ 439, [ ""_KEXECUTE_OPTIONS"", ""null"" ]],
				 ""ThreadSeed"": [ 440, [ ""Array"", ""{\""count\"":20,\""target\"":\""UInt32\""}"" ]],
				 ""IdealNode"": [ 520, [ ""Array"", ""{\""count\"":20,\""target\"":\""UInt16\""}"" ]],
				 ""IdealGlobalNode"": [ 560, [ ""UInt16"", ""null"" ]],
				 ""Spare1"": [ 562, [ ""UInt16"", ""null"" ]],
				 ""StackCount"": [ 564, [ ""_KSTACK_COUNT"", ""null"" ]],
				 ""ProcessListEntry"": [ 568, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""CycleTime"": [ 584, [ ""UInt64"", ""null"" ]],
				 ""ContextSwitches"": [ 592, [ ""UInt64"", ""null"" ]],
				 ""SchedulingGroup"": [ 600, [ ""Pointer"", ""{\""target\"":\""_KSCHEDULING_GROUP\""}"" ]],
				 ""FreezeCount"": [ 608, [ ""UInt32"", ""null"" ]],
				 ""KernelTime"": [ 612, [ ""UInt32"", ""null"" ]],
				 ""UserTime"": [ 616, [ ""UInt32"", ""null"" ]],
				 ""LdtFreeSelectorHint"": [ 620, [ ""UInt16"", ""null"" ]],
				 ""LdtTableLength"": [ 622, [ ""UInt16"", ""null"" ]],
				 ""LdtSystemDescriptor"": [ 624, [ ""_KGDTENTRY64"", ""null"" ]],
				 ""LdtBaseAddress"": [ 640, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""LdtProcessLock"": [ 648, [ ""_FAST_MUTEX"", ""null"" ]],
				 ""InstrumentationCallback"": [ 704, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public _DISPATCHER_HEADER Header
		{
			get
			{
				_DISPATCHER_HEADER returnValue = new _DISPATCHER_HEADER(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _LIST_ENTRY ProfileListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 24);
				return returnValue;
			}
		}
		public UInt64 DirectoryTableBase { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 40); } }
		public _LIST_ENTRY ThreadListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 48);
				return returnValue;
			}
		}
		public UInt32 ProcessLock { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 64); } }
		public UInt32 Spare0 { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 68); } }
		public _KAFFINITY_EX Affinity
		{
			get
			{
				_KAFFINITY_EX returnValue = new _KAFFINITY_EX(_StructureData, _BufferOffset + 72);
				return returnValue;
			}
		}
		public _LIST_ENTRY ReadyListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 240);
				return returnValue;
			}
		}
		public _SINGLE_LIST_ENTRY SwapListEntry
		{
			get
			{
				_SINGLE_LIST_ENTRY returnValue = new _SINGLE_LIST_ENTRY(_StructureData, _BufferOffset + 256);
				return returnValue;
			}
		}
		public _KAFFINITY_EX ActiveProcessors
		{
			get
			{
				_KAFFINITY_EX returnValue = new _KAFFINITY_EX(_StructureData, _BufferOffset + 264);
				return returnValue;
			}
		}
		public UInt32 AutoAlignment
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 DisableBoost
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 DisableQuantum
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 AffinitySet
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 DeepFreeze
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 TimerVirtualization
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 CheckStackExtents
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 ActiveGroupsMask
		{
			get
			{
				// start: 7  end: 27  Mask: 111111111111111111110000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 134217600) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 ReservedFlags
		{
			get
			{
				// start: 27  end: 32  Mask: 11111000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 432);
				var value2 = (value & 4160749568) >> 27;
				return (UInt32)value2;
			}
		}
		public Int32 ProcessFlags { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 432); } }
		public Char BasePriority { get { return BitConverter.ToChar(_StructureData, _BufferOffset + 436); } }
		public Char QuantumReset { get { return BitConverter.ToChar(_StructureData, _BufferOffset + 437); } }
		public Byte Visited{ get { return _StructureData[_BufferOffset +438]; } }
		public _KEXECUTE_OPTIONS Flags
		{
			get
			{
				_KEXECUTE_OPTIONS returnValue = new _KEXECUTE_OPTIONS(_StructureData, _BufferOffset + 439);
				return returnValue;
			}
		}
		public UInt32[] ThreadSeed
		{
			get
			{
				UInt32[] returnValue = new UInt32[20];
				for(int i=0; i<20; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 440);
				return returnValue;
			}
		}
		public UInt16[] IdealNode
		{
			get
			{
				UInt16[] returnValue = new UInt16[20];
				for(int i=0; i<20; i++ )
					returnValue[i] = BitConverter.ToUInt16(_StructureData, (i * sizeof(UInt16)) + _BufferOffset + 520);
				return returnValue;
			}
		}
		public UInt16 IdealGlobalNode { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 560); } }
		public UInt16 Spare1 { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 562); } }
		public _KSTACK_COUNT StackCount
		{
			get
			{
				_KSTACK_COUNT returnValue = new _KSTACK_COUNT(_StructureData, _BufferOffset + 564);
				return returnValue;
			}
		}
		public _LIST_ENTRY ProcessListEntry
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 568);
				return returnValue;
			}
		}
		public UInt64 CycleTime { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 584); } }
		public UInt64 ContextSwitches { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 592); } }
		public UInt64 SchedulingGroup { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 600); } }
		public UInt32 FreezeCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 608); } }
		public UInt32 KernelTime { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 612); } }
		public UInt32 UserTime { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 616); } }
		public UInt16 LdtFreeSelectorHint { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 620); } }
		public UInt16 LdtTableLength { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 622); } }
		public _KGDTENTRY64 LdtSystemDescriptor
		{
			get
			{
				_KGDTENTRY64 returnValue = new _KGDTENTRY64(_StructureData, _BufferOffset + 624);
				return returnValue;
			}
		}
		public UInt64 LdtBaseAddress { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 640); } }
		public _FAST_MUTEX LdtProcessLock
		{
			get
			{
				_FAST_MUTEX returnValue = new _FAST_MUTEX(_StructureData, _BufferOffset + 648);
				return returnValue;
			}
		}
		public UInt64 InstrumentationCallback { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 704); } }
	}
	#endregion
	#region _EX_PUSH_LOCK
 
	public class _EX_PUSH_LOCK
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _EX_PUSH_LOCK(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_PUSH_LOCK"": [ 8, {
				 ""Locked"": [ 0, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt64\""}"" ]],
				 ""Waiting"": [ 0, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt64\""}"" ]],
				 ""Waking"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt64\""}"" ]],
				 ""MultipleShared"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt64\""}"" ]],
				 ""Shared"": [ 0, [ ""BitField"", ""{\""end_bit\"":64,\""start_bit\"":4,\""target\"":\""UInt64\""}"" ]],
				 ""Value"": [ 0, [ ""UInt64"", ""null"" ]],
				 ""Ptr"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Locked
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1) >> 0;
				return (UInt64)value2;
			}
		}
		public UInt64 Waiting
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2) >> 1;
				return (UInt64)value2;
			}
		}
		public UInt64 Waking
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4) >> 2;
				return (UInt64)value2;
			}
		}
		public UInt64 MultipleShared
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 8) >> 3;
				return (UInt64)value2;
			}
		}
		public UInt64 Shared
		{
			get
			{
				// start: 4  end: 64  Mask: 0000000000000000000000000000000011111111111111111111111111110000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4294967280) >> 4;
				return (UInt64)value2;
			}
		}
		public UInt64 Value { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Ptr { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _LARGE_INTEGER
 
	public class _LARGE_INTEGER
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _LARGE_INTEGER(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_LARGE_INTEGER"": [ 8, {
				 ""LowPart"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""HighPart"": [ 4, [ ""Int32"", ""null"" ]],
				 ""u"": [ 0, [ ""_UNNAMED_27152"", ""null"" ]],
				 ""QuadPart"": [ 0, [ ""Int64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 LowPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 HighPart { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public _UNNAMED_27152 u
		{
			get
			{
				_UNNAMED_27152 returnValue = new _UNNAMED_27152(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public Int64 QuadPart { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _UNNAMED_27152
 
	public class _UNNAMED_27152
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _UNNAMED_27152(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_UNNAMED_27152"": [ 8, {
				 ""LowPart"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""HighPart"": [ 4, [ ""Int32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 LowPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 HighPart { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
	}
	#endregion
	#region _EX_RUNDOWN_REF
 
	public class _EX_RUNDOWN_REF
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _EX_RUNDOWN_REF(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_RUNDOWN_REF"": [ 8, {
				 ""Count"": [ 0, [ ""UInt64"", ""null"" ]],
				 ""Ptr"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Count { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Ptr { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _LIST_ENTRY
 
	public class _LIST_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _LIST_ENTRY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_LIST_ENTRY"": [ 16, {
				 ""Flink"": [ 0, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]],
				 ""Blink"": [ 8, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Flink { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 Blink { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _EX_FAST_REF
 
	public class _EX_FAST_REF
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _EX_FAST_REF(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_FAST_REF"": [ 8, {
				 ""Object"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""RefCnt"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":0,\""target\"":\""UInt64\""}"" ]],
				 ""Value"": [ 0, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Object { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 RefCnt
		{
			get
			{
				// start: 0  end: 4  Mask: 0000000000001111
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 15) >> 0;
				return (UInt64)value2;
			}
		}
		public UInt64 Value { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _RTL_AVL_TREE
 
	public class _RTL_AVL_TREE
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _RTL_AVL_TREE(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_RTL_AVL_TREE"": [ 8, {
				 ""Root"": [ 0, [ ""Pointer"", ""{\""target\"":\""_RTL_BALANCED_NODE\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Root { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _SE_AUDIT_PROCESS_CREATION_INFO
 
	public class _SE_AUDIT_PROCESS_CREATION_INFO
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _SE_AUDIT_PROCESS_CREATION_INFO(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_SE_AUDIT_PROCESS_CREATION_INFO"": [ 8, {
				 ""ImageFileName"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_NAME_INFORMATION\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 ImageFileName { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _MMSUPPORT
 
	public class _MMSUPPORT
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _MMSUPPORT(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 232; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_MMSUPPORT"": [ 232, {
				 ""ExitGate"": [ 0, [ ""Pointer"", ""{\""target\"":\""_KGATE\""}"" ]],
				 ""AccessLog"": [ 8, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""WorkingSetMutex"": [ 16, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""WorkingSetExpansionLinks"": [ 24, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""AgeDistribution"": [ 40, [ ""Array"", ""{\""count\"":7,\""target\"":\""UInt64\""}"" ]],
				 ""MinimumWorkingSetSize"": [ 96, [ ""UInt64"", ""null"" ]],
				 ""WorkingSetLeafSize"": [ 104, [ ""UInt64"", ""null"" ]],
				 ""WorkingSetLeafPrivateSize"": [ 112, [ ""UInt64"", ""null"" ]],
				 ""WorkingSetSize"": [ 120, [ ""UInt64"", ""null"" ]],
				 ""WorkingSetPrivateSize"": [ 128, [ ""UInt64"", ""null"" ]],
				 ""MaximumWorkingSetSize"": [ 136, [ ""UInt64"", ""null"" ]],
				 ""ChargedWslePages"": [ 144, [ ""UInt64"", ""null"" ]],
				 ""ActualWslePages"": [ 152, [ ""UInt64"", ""null"" ]],
				 ""WorkingSetSizeOverhead"": [ 160, [ ""UInt64"", ""null"" ]],
				 ""PeakWorkingSetSize"": [ 168, [ ""UInt64"", ""null"" ]],
				 ""HardFaultCount"": [ 176, [ ""UInt32"", ""null"" ]],
				 ""VmWorkingSetList"": [ 184, [ ""Pointer"", ""{\""target\"":\""_MMWSL\""}"" ]],
				 ""NextPageColor"": [ 192, [ ""UInt16"", ""null"" ]],
				 ""LastTrimStamp"": [ 194, [ ""UInt16"", ""null"" ]],
				 ""PageFaultCount"": [ 196, [ ""UInt32"", ""null"" ]],
				 ""TrimmedPageCount"": [ 200, [ ""UInt64"", ""null"" ]],
				 ""ForceTrimPages"": [ 208, [ ""UInt64"", ""null"" ]],
				 ""Flags"": [ 216, [ ""_MMSUPPORT_FLAGS"", ""null"" ]],
				 ""WsSwapSupport"": [ 224, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 ExitGate { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 AccessLog { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
		public _EX_PUSH_LOCK WorkingSetMutex
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 16);
				return returnValue;
			}
		}
		public _LIST_ENTRY WorkingSetExpansionLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 24);
				return returnValue;
			}
		}
		public UInt64[] AgeDistribution
		{
			get
			{
				UInt64[] returnValue = new UInt64[7];
				for(int i=0; i<7; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 40);
				return returnValue;
			}
		}
		public UInt64 MinimumWorkingSetSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 96); } }
		public UInt64 WorkingSetLeafSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 104); } }
		public UInt64 WorkingSetLeafPrivateSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 112); } }
		public UInt64 WorkingSetSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 120); } }
		public UInt64 WorkingSetPrivateSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 128); } }
		public UInt64 MaximumWorkingSetSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 136); } }
		public UInt64 ChargedWslePages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 144); } }
		public UInt64 ActualWslePages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 152); } }
		public UInt64 WorkingSetSizeOverhead { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 160); } }
		public UInt64 PeakWorkingSetSize { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 168); } }
		public UInt32 HardFaultCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 176); } }
		public UInt64 VmWorkingSetList { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 184); } }
		public UInt16 NextPageColor { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 192); } }
		public UInt16 LastTrimStamp { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 194); } }
		public UInt32 PageFaultCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 196); } }
		public UInt64 TrimmedPageCount { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 200); } }
		public UInt64 ForceTrimPages { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 208); } }
		public _MMSUPPORT_FLAGS Flags
		{
			get
			{
				_MMSUPPORT_FLAGS returnValue = new _MMSUPPORT_FLAGS(_StructureData, _BufferOffset + 216);
				return returnValue;
			}
		}
		public UInt64 WsSwapSupport { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 224); } }
	}
	#endregion
	#region _ALPC_PROCESS_CONTEXT
 
	public class _ALPC_PROCESS_CONTEXT
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _ALPC_PROCESS_CONTEXT(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_ALPC_PROCESS_CONTEXT"": [ 32, {
				 ""Lock"": [ 0, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""ViewListHead"": [ 8, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""PagedPoolQuotaCache"": [ 24, [ ""UInt64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _EX_PUSH_LOCK Lock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _LIST_ENTRY ViewListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
		public UInt64 PagedPoolQuotaCache { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 24); } }
	}
	#endregion
	#region _PS_PROTECTION
 
	public class _PS_PROTECTION
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _PS_PROTECTION(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 1; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_PS_PROTECTION"": [ 1, {
				 ""Level"": [ 0, [ ""Byte"", ""null"" ]],
				 ""Type"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""Audit"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""Signer"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]] }]
				 }
				)";
			}
		}
		public Byte Level{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte Type
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 7) >> 0;
				return (Byte)value2;
			}
		}
		public Byte Audit
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte Signer
		{
			get
			{
				// start: 4  end: 8  Mask: 0000000011110000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 240) >> 4;
				return (Byte)value2;
			}
		}
	}
	#endregion
	#region _KSYSTEM_TIME
 
	public class _KSYSTEM_TIME
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KSYSTEM_TIME(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 12; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KSYSTEM_TIME"": [ 12, {
				 ""LowPart"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""High1Time"": [ 4, [ ""Int32"", ""null"" ]],
				 ""High2Time"": [ 8, [ ""Int32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 LowPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 High1Time { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public Int32 High2Time { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _XSTATE_CONFIGURATION
 
	public class _XSTATE_CONFIGURATION
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _XSTATE_CONFIGURATION(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 536; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_XSTATE_CONFIGURATION"": [ 536, {
				 ""EnabledFeatures"": [ 0, [ ""UInt64"", ""null"" ]],
				 ""EnabledVolatileFeatures"": [ 8, [ ""UInt64"", ""null"" ]],
				 ""Size"": [ 16, [ ""UInt32"", ""null"" ]],
				 ""OptimizedSave"": [ 20, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""Features"": [ 24, [ ""Array"", ""{\""count\"":64,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""\""}}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 EnabledFeatures { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt64 EnabledVolatileFeatures { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
		public UInt32 Size { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public UInt32 OptimizedSave
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 20);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public _XSTATE_FEATURE[] Features
		{
			get
			{
				_XSTATE_FEATURE[] returnValue = new _XSTATE_FEATURE[64];
				int size = returnValue[0].MxStructureSize;
				for(int i=0; i<64; i++ )
					returnValue[i] = new _XSTATE_FEATURE(_StructureData, (i * size) + _BufferOffset + 24);
				return returnValue;
			}
		}
	}
	#endregion
	#region _UNICODE_STRING
 
	public class _UNICODE_STRING
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _UNICODE_STRING(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_UNICODE_STRING"": [ 16, {
				 ""Length"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""MaximumLength"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""Buffer"": [ 8, [ ""Pointer"", ""{\""target\"":\""UInt16\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Length { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 MaximumLength { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public UInt64 Buffer { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _OBJECT_TYPE_INITIALIZER
 
	public class _OBJECT_TYPE_INITIALIZER
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_TYPE_INITIALIZER(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 120; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_TYPE_INITIALIZER"": [ 120, {
				 ""Length"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""ObjectTypeFlags"": [ 2, [ ""Byte"", ""null"" ]],
				 ""CaseInsensitive"": [ 2, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""UnnamedObjectsOnly"": [ 2, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""UseDefaultObject"": [ 2, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""SecurityRequired"": [ 2, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""MaintainHandleCount"": [ 2, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""MaintainTypeList"": [ 2, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""Byte\""}"" ]],
				 ""SupportsObjectCallbacks"": [ 2, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""CacheAligned"": [ 2, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""ObjectTypeCode"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""InvalidAttributes"": [ 8, [ ""UInt32"", ""null"" ]],
				 ""GenericMapping"": [ 12, [ ""_GENERIC_MAPPING"", ""null"" ]],
				 ""ValidAccessMask"": [ 28, [ ""UInt32"", ""null"" ]],
				 ""RetainAccess"": [ 32, [ ""UInt32"", ""null"" ]],
				 ""PoolType"": [ 36, [ ""Enumeration"", ""{\""enum_name\"":\""_POOL_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""DefaultPagedPoolCharge"": [ 40, [ ""UInt32"", ""null"" ]],
				 ""DefaultNonPagedPoolCharge"": [ 44, [ ""UInt32"", ""null"" ]],
				 ""DumpProcedure"": [ 48, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""OpenProcedure"": [ 56, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CloseProcedure"": [ 64, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""DeleteProcedure"": [ 72, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ParseProcedure"": [ 80, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SecurityProcedure"": [ 88, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""QueryNameProcedure"": [ 96, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""OkayToCloseProcedure"": [ 104, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""WaitObjectFlagMask"": [ 112, [ ""UInt32"", ""null"" ]],
				 ""WaitObjectFlagOffset"": [ 116, [ ""UInt16"", ""null"" ]],
				 ""WaitObjectPointerOffset"": [ 118, [ ""UInt16"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Length { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public Byte ObjectTypeFlags{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte CaseInsensitive
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte UnnamedObjectsOnly
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte UseDefaultObject
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte SecurityRequired
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte MaintainHandleCount
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 16) >> 4;
				return (Byte)value2;
			}
		}
		public Byte MaintainTypeList
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 32) >> 5;
				return (Byte)value2;
			}
		}
		public Byte SupportsObjectCallbacks
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte CacheAligned
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public UInt32 ObjectTypeCode { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 InvalidAttributes { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public _GENERIC_MAPPING GenericMapping
		{
			get
			{
				_GENERIC_MAPPING returnValue = new _GENERIC_MAPPING(_StructureData, _BufferOffset + 12);
				return returnValue;
			}
		}
		public UInt32 ValidAccessMask { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 28); } }
		public UInt32 RetainAccess { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 32); } }
		public _POOL_TYPE PoolType { get { return (_POOL_TYPE)BitConverter.ToUInt32(_StructureData, _BufferOffset + 36); } }
		public UInt32 DefaultPagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 40); } }
		public UInt32 DefaultNonPagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 44); } }
		public UInt64 DumpProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 48); } }
		public UInt64 OpenProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 56); } }
		public UInt64 CloseProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 64); } }
		public UInt64 DeleteProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 72); } }
		public UInt64 ParseProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 80); } }
		public UInt64 SecurityProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 88); } }
		public UInt64 QueryNameProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 96); } }
		public UInt64 OkayToCloseProcedure { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 104); } }
		public UInt32 WaitObjectFlagMask { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 112); } }
		public UInt16 WaitObjectFlagOffset { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 116); } }
		public UInt16 WaitObjectPointerOffset { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 118); } }
	}
	#endregion
	#region _QUAD
 
	public class _QUAD
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _QUAD(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_QUAD"": [ 8, {
				 ""UseThisFieldToCopy"": [ 0, [ ""Int64"", ""null"" ]],
				 ""DoNotUseThisField"": [ 0, [ ""Double"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int64 UseThisFieldToCopy { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 0); } }
		public Double DoNotUseThisField { get { return BitConverter.ToDouble(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _OBJECT_HANDLE_COUNT_ENTRY
 
	public class _OBJECT_HANDLE_COUNT_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OBJECT_HANDLE_COUNT_ENTRY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HANDLE_COUNT_ENTRY"": [ 16, {
				 ""Process"": [ 0, [ ""Pointer"", ""{\""target\"":\""_EPROCESS\""}"" ]],
				 ""HandleCount"": [ 8, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""LockCount"": [ 8, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Process { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
		public UInt32 HandleCount
		{
			get
			{
				// start: 0  end: 24  Mask: 111111111111111111111111
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 8);
				var value2 = (value & 16777215) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 LockCount
		{
			get
			{
				// start: 24  end: 32  Mask: 11111111000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 8);
				var value2 = (value & 4278190080) >> 24;
				return (UInt32)value2;
			}
		}
	}
	#endregion
	#region _DISPATCHER_HEADER
 
	public class _DISPATCHER_HEADER
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _DISPATCHER_HEADER(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 24; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_DISPATCHER_HEADER"": [ 24, {
				 ""Lock"": [ 0, [ ""Int32"", ""null"" ]],
				 ""LockNV"": [ 0, [ ""Int32"", ""null"" ]],
				 ""Type"": [ 0, [ ""Byte"", ""null"" ]],
				 ""Signalling"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Size"": [ 2, [ ""Byte"", ""null"" ]],
				 ""Reserved1"": [ 3, [ ""Byte"", ""null"" ]],
				 ""TimerType"": [ 0, [ ""Byte"", ""null"" ]],
				 ""TimerControlFlags"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Absolute"": [ 1, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""Wake"": [ 1, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""EncodedTolerableDelay"": [ 1, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""Hand"": [ 2, [ ""Byte"", ""null"" ]],
				 ""TimerMiscFlags"": [ 3, [ ""Byte"", ""null"" ]],
				 ""Index"": [ 3, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""Inserted"": [ 3, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""Expired"": [ 3, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""Timer2Type"": [ 0, [ ""Byte"", ""null"" ]],
				 ""Timer2Flags"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Timer2Inserted"": [ 1, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""Timer2Expiring"": [ 1, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""Timer2CancelPending"": [ 1, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""Timer2SetPending"": [ 1, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""Timer2Running"": [ 1, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""Timer2Disabled"": [ 1, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""Byte\""}"" ]],
				 ""Timer2ReservedFlags"": [ 1, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""Timer2Reserved1"": [ 2, [ ""Byte"", ""null"" ]],
				 ""Timer2Reserved2"": [ 3, [ ""Byte"", ""null"" ]],
				 ""QueueType"": [ 0, [ ""Byte"", ""null"" ]],
				 ""QueueControlFlags"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Abandoned"": [ 1, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""DisableIncrement"": [ 1, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""QueueReservedControlFlags"": [ 1, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""QueueSize"": [ 2, [ ""Byte"", ""null"" ]],
				 ""QueueReserved"": [ 3, [ ""Byte"", ""null"" ]],
				 ""ThreadType"": [ 0, [ ""Byte"", ""null"" ]],
				 ""ThreadReserved"": [ 1, [ ""Byte"", ""null"" ]],
				 ""ThreadControlFlags"": [ 2, [ ""Byte"", ""null"" ]],
				 ""CycleProfiling"": [ 2, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""CounterProfiling"": [ 2, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""GroupScheduling"": [ 2, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""AffinitySet"": [ 2, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""ThreadReservedControlFlags"": [ 2, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""DebugActive"": [ 3, [ ""Byte"", ""null"" ]],
				 ""ActiveDR7"": [ 3, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""Instrumented"": [ 3, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""Minimal"": [ 3, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""Reserved4"": [ 3, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""UmsScheduled"": [ 3, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""UmsPrimary"": [ 3, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""MutantType"": [ 0, [ ""Byte"", ""null"" ]],
				 ""MutantSize"": [ 1, [ ""Byte"", ""null"" ]],
				 ""DpcActive"": [ 2, [ ""Byte"", ""null"" ]],
				 ""MutantReserved"": [ 3, [ ""Byte"", ""null"" ]],
				 ""SignalState"": [ 4, [ ""Int32"", ""null"" ]],
				 ""WaitListHead"": [ 8, [ ""_LIST_ENTRY"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int32 Lock { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 LockNV { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public Byte Type{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte Signalling{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Size{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte Reserved1{ get { return _StructureData[_BufferOffset +3]; } }
		public Byte TimerType{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte TimerControlFlags{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Absolute
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte Wake
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte EncodedTolerableDelay
		{
			get
			{
				// start: 2  end: 8  Mask: 0000000011111100
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 252) >> 2;
				return (Byte)value2;
			}
		}
		public Byte Hand{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte TimerMiscFlags{ get { return _StructureData[_BufferOffset +3]; } }
		public Byte Index
		{
			get
			{
				// start: 0  end: 6  Mask: 0000000000111111
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 63) >> 0;
				return (Byte)value2;
			}
		}
		public Byte Inserted
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte Expired
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public Byte Timer2Type{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte Timer2Flags{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Timer2Inserted
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte Timer2Expiring
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte Timer2CancelPending
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte Timer2SetPending
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte Timer2Running
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 16) >> 4;
				return (Byte)value2;
			}
		}
		public Byte Timer2Disabled
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 32) >> 5;
				return (Byte)value2;
			}
		}
		public Byte Timer2ReservedFlags
		{
			get
			{
				// start: 6  end: 8  Mask: 0000000011000000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 192) >> 6;
				return (Byte)value2;
			}
		}
		public Byte Timer2Reserved1{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte Timer2Reserved2{ get { return _StructureData[_BufferOffset +3]; } }
		public Byte QueueType{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte QueueControlFlags{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Abandoned
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte DisableIncrement
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte QueueReservedControlFlags
		{
			get
			{
				// start: 2  end: 8  Mask: 0000000011111100
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 252) >> 2;
				return (Byte)value2;
			}
		}
		public Byte QueueSize{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte QueueReserved{ get { return _StructureData[_BufferOffset +3]; } }
		public Byte ThreadType{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte ThreadReserved{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte ThreadControlFlags{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte CycleProfiling
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte CounterProfiling
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte GroupScheduling
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte AffinitySet
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte ThreadReservedControlFlags
		{
			get
			{
				// start: 4  end: 8  Mask: 0000000011110000
				Byte value = _StructureData[_BufferOffset + 2];
				var value2 = (value & 240) >> 4;
				return (Byte)value2;
			}
		}
		public Byte DebugActive{ get { return _StructureData[_BufferOffset +3]; } }
		public Byte ActiveDR7
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte Instrumented
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte Minimal
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte Reserved4
		{
			get
			{
				// start: 3  end: 6  Mask: 0000000000111000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 56) >> 3;
				return (Byte)value2;
			}
		}
		public Byte UmsScheduled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte UmsPrimary
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public Byte MutantType{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte MutantSize{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte DpcActive{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte MutantReserved{ get { return _StructureData[_BufferOffset +3]; } }
		public Int32 SignalState { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public _LIST_ENTRY WaitListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
	}
	#endregion
	#region _KAFFINITY_EX
 
	public class _KAFFINITY_EX
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KAFFINITY_EX(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 168; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KAFFINITY_EX"": [ 168, {
				 ""Count"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""Size"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""Reserved"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""Bitmap"": [ 8, [ ""Array"", ""{\""count\"":20,\""target\"":\""UInt64\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Count { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 Size { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public UInt32 Reserved { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt64[] Bitmap
		{
			get
			{
				UInt64[] returnValue = new UInt64[20];
				for(int i=0; i<20; i++ )
					returnValue[i] = BitConverter.ToUInt64(_StructureData, (i * sizeof(UInt64)) + _BufferOffset + 8);
				return returnValue;
			}
		}
	}
	#endregion
	#region _SINGLE_LIST_ENTRY
 
	public class _SINGLE_LIST_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _SINGLE_LIST_ENTRY(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_SINGLE_LIST_ENTRY"": [ 8, {
				 ""Next"": [ 0, [ ""Pointer"", ""{\""target\"":\""_SINGLE_LIST_ENTRY\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Next { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 0); } }
	}
	#endregion
	#region _KEXECUTE_OPTIONS
 
	public class _KEXECUTE_OPTIONS
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KEXECUTE_OPTIONS(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 1; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KEXECUTE_OPTIONS"": [ 1, {
				 ""ExecuteDisable"": [ 0, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""ExecuteEnable"": [ 0, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""DisableThunkEmulation"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""Permanent"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""ExecuteDispatchEnable"": [ 0, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""ImageDispatchEnable"": [ 0, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""Byte\""}"" ]],
				 ""DisableExceptionChainValidation"": [ 0, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""Spare"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""ExecuteOptions"": [ 0, [ ""Byte"", ""null"" ]],
				 ""ExecuteOptionsNV"": [ 0, [ ""Byte"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Byte ExecuteDisable
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte ExecuteEnable
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte DisableThunkEmulation
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte Permanent
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte ExecuteDispatchEnable
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 16) >> 4;
				return (Byte)value2;
			}
		}
		public Byte ImageDispatchEnable
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 32) >> 5;
				return (Byte)value2;
			}
		}
		public Byte DisableExceptionChainValidation
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte Spare
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public Byte ExecuteOptions{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte ExecuteOptionsNV{ get { return _StructureData[_BufferOffset +0]; } }
	}
	#endregion
	#region _KSTACK_COUNT
 
	public class _KSTACK_COUNT
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KSTACK_COUNT(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KSTACK_COUNT"": [ 4, {
				 ""Value"": [ 0, [ ""Int32"", ""null"" ]],
				 ""State"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""StackCount"": [ 0, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]] }]
				 }
				)";
			}
		}
		public Int32 Value { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 State
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 7) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 StackCount
		{
			get
			{
				// start: 3  end: 32  Mask: 11111111111111111111111111111000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4294967288) >> 3;
				return (UInt32)value2;
			}
		}
	}
	#endregion
	#region _KGDTENTRY64
 
	public class _KGDTENTRY64
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KGDTENTRY64(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KGDTENTRY64"": [ 16, {
				 ""LimitLow"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""BaseLow"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""Bytes"": [ 4, [ ""_UNNAMED_27353"", ""null"" ]],
				 ""Bits"": [ 4, [ ""_UNNAMED_27355"", ""null"" ]],
				 ""BaseUpper"": [ 8, [ ""UInt32"", ""null"" ]],
				 ""MustBeZero"": [ 12, [ ""UInt32"", ""null"" ]],
				 ""DataLow"": [ 0, [ ""Int64"", ""null"" ]],
				 ""DataHigh"": [ 8, [ ""Int64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt16 LimitLow { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 BaseLow { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public _UNNAMED_27353 Bytes
		{
			get
			{
				_UNNAMED_27353 returnValue = new _UNNAMED_27353(_StructureData, _BufferOffset + 4);
				return returnValue;
			}
		}
		public _UNNAMED_27355 Bits
		{
			get
			{
				_UNNAMED_27355 returnValue = new _UNNAMED_27355(_StructureData, _BufferOffset + 4);
				return returnValue;
			}
		}
		public UInt32 BaseUpper { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public UInt32 MustBeZero { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 12); } }
		public Int64 DataLow { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 0); } }
		public Int64 DataHigh { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 8); } }
	}
	#endregion
	#region _UNNAMED_27353
 
	public class _UNNAMED_27353
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _UNNAMED_27353(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_UNNAMED_27353"": [ 4, {
				 ""BaseMiddle"": [ 0, [ ""Byte"", ""null"" ]],
				 ""Flags1"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Flags2"": [ 2, [ ""Byte"", ""null"" ]],
				 ""BaseHigh"": [ 3, [ ""Byte"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Byte BaseMiddle{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte Flags1{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Flags2{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte BaseHigh{ get { return _StructureData[_BufferOffset +3]; } }
	}
	#endregion
	#region _FAST_MUTEX
 
	public class _FAST_MUTEX
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _FAST_MUTEX(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 56; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_FAST_MUTEX"": [ 56, {
				 ""Count"": [ 0, [ ""Int32"", ""null"" ]],
				 ""Owner"": [ 8, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Contention"": [ 16, [ ""UInt32"", ""null"" ]],
				 ""Event"": [ 24, [ ""_KEVENT"", ""null"" ]],
				 ""OldIrql"": [ 48, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int32 Count { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public UInt64 Owner { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 8); } }
		public UInt32 Contention { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public _KEVENT Event
		{
			get
			{
				_KEVENT returnValue = new _KEVENT(_StructureData, _BufferOffset + 24);
				return returnValue;
			}
		}
		public UInt32 OldIrql { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
	}
	#endregion
	#region _UNNAMED_27355
 
	public class _UNNAMED_27355
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _UNNAMED_27355(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_UNNAMED_27355"": [ 4, {
				 ""BaseMiddle"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""Type"": [ 0, [ ""BitField"", ""{\""end_bit\"":13,\""start_bit\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""Dpl"": [ 0, [ ""BitField"", ""{\""end_bit\"":15,\""start_bit\"":13,\""target\"":\""UInt32\""}"" ]],
				 ""Present"": [ 0, [ ""BitField"", ""{\""end_bit\"":16,\""start_bit\"":15,\""target\"":\""UInt32\""}"" ]],
				 ""LimitHigh"": [ 0, [ ""BitField"", ""{\""end_bit\"":20,\""start_bit\"":16,\""target\"":\""UInt32\""}"" ]],
				 ""System"": [ 0, [ ""BitField"", ""{\""end_bit\"":21,\""start_bit\"":20,\""target\"":\""UInt32\""}"" ]],
				 ""LongMode"": [ 0, [ ""BitField"", ""{\""end_bit\"":22,\""start_bit\"":21,\""target\"":\""UInt32\""}"" ]],
				 ""DefaultBig"": [ 0, [ ""BitField"", ""{\""end_bit\"":23,\""start_bit\"":22,\""target\"":\""UInt32\""}"" ]],
				 ""Granularity"": [ 0, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":23,\""target\"":\""UInt32\""}"" ]],
				 ""BaseHigh"": [ 0, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 BaseMiddle
		{
			get
			{
				// start: 0  end: 8  Mask: 0000000011111111
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 255) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 Type
		{
			get
			{
				// start: 8  end: 13  Mask: 0001111100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 7936) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 Dpl
		{
			get
			{
				// start: 13  end: 15  Mask: 0110000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 24576) >> 13;
				return (UInt32)value2;
			}
		}
		public UInt32 Present
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 LimitHigh
		{
			get
			{
				// start: 16  end: 20  Mask: 11110000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 983040) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 System
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 LongMode
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 DefaultBig
		{
			get
			{
				// start: 22  end: 23  Mask: 10000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4194304) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 Granularity
		{
			get
			{
				// start: 23  end: 24  Mask: 100000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 8388608) >> 23;
				return (UInt32)value2;
			}
		}
		public UInt32 BaseHigh
		{
			get
			{
				// start: 24  end: 32  Mask: 11111111000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4278190080) >> 24;
				return (UInt32)value2;
			}
		}
	}
	#endregion
	#region _MMSUPPORT_FLAGS
 
	public class _MMSUPPORT_FLAGS
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _MMSUPPORT_FLAGS(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_MMSUPPORT_FLAGS"": [ 4, {
				 ""WorkingSetType"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""ForceCredits"": [ 0, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""MaximumWorkingSetHard"": [ 0, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]],
				 ""MinimumWorkingSetHard"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""Byte\""}"" ]],
				 ""SessionMaster"": [ 1, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""TrimmerState"": [ 1, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""Reserved"": [ 1, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""PageStealers"": [ 1, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]],
				 ""MemoryPriority"": [ 2, [ ""Byte"", ""null"" ]],
				 ""WsleDeleted"": [ 3, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""Byte\""}"" ]],
				 ""VmExiting"": [ 3, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""Byte\""}"" ]],
				 ""ExpansionFailed"": [ 3, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""Byte\""}"" ]],
				 ""SvmEnabled"": [ 3, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""Byte\""}"" ]],
				 ""Available"": [ 3, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":4,\""target\"":\""Byte\""}"" ]] }]
				 }
				)";
			}
		}
		public Byte WorkingSetType
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 7) >> 0;
				return (Byte)value2;
			}
		}
		public Byte ForceCredits
		{
			get
			{
				// start: 3  end: 6  Mask: 0000000000111000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 56) >> 3;
				return (Byte)value2;
			}
		}
		public Byte MaximumWorkingSetHard
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 64) >> 6;
				return (Byte)value2;
			}
		}
		public Byte MinimumWorkingSetHard
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 128) >> 7;
				return (Byte)value2;
			}
		}
		public Byte SessionMaster
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte TrimmerState
		{
			get
			{
				// start: 1  end: 3  Mask: 0000000000000110
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 6) >> 1;
				return (Byte)value2;
			}
		}
		public Byte Reserved
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte PageStealers
		{
			get
			{
				// start: 4  end: 8  Mask: 0000000011110000
				Byte value = _StructureData[_BufferOffset + 1];
				var value2 = (value & 240) >> 4;
				return (Byte)value2;
			}
		}
		public Byte MemoryPriority{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte WsleDeleted
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 1) >> 0;
				return (Byte)value2;
			}
		}
		public Byte VmExiting
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 2) >> 1;
				return (Byte)value2;
			}
		}
		public Byte ExpansionFailed
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 4) >> 2;
				return (Byte)value2;
			}
		}
		public Byte SvmEnabled
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 8) >> 3;
				return (Byte)value2;
			}
		}
		public Byte Available
		{
			get
			{
				// start: 4  end: 8  Mask: 0000000011110000
				Byte value = _StructureData[_BufferOffset + 3];
				var value2 = (value & 240) >> 4;
				return (Byte)value2;
			}
		}
	}
	#endregion
	#region _XSTATE_FEATURE
 
	public class _XSTATE_FEATURE
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _XSTATE_FEATURE(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_XSTATE_FEATURE"": [ 8, {
				 ""Offset"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""Size"": [ 4, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Offset { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Size { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
	}
	#endregion
	#region _GENERIC_MAPPING
 
	public class _GENERIC_MAPPING
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _GENERIC_MAPPING(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_GENERIC_MAPPING"": [ 16, {
				 ""GenericRead"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""GenericWrite"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""GenericExecute"": [ 8, [ ""UInt32"", ""null"" ]],
				 ""GenericAll"": [ 12, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 GenericRead { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 GenericWrite { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 GenericExecute { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public UInt32 GenericAll { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 12); } }
	}
	#endregion
	#region _KEVENT
 
	public class _KEVENT
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KEVENT(Byte[] Buffer, int PartitionOffset)
		{
			_StructureData = Buffer;
			_BufferOffset = PartitionOffset;
		}
		public int MxStructureSize { get { return 24; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KEVENT"": [ 24, {
				 ""Header"": [ 0, [ ""_DISPATCHER_HEADER"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _DISPATCHER_HEADER Header
		{
			get
			{
				_DISPATCHER_HEADER returnValue = new _DISPATCHER_HEADER(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
	}
	#endregion
}
