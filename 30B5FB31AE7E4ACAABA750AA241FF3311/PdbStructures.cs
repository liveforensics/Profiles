using System;

namespace LiveForensics.Symbols
{
	#region HEADER
	public class CatalogueInformation
	{
		 public Guid Guid { get { return new Guid("30B5FB31-AE7E-4ACA-ABA7-50AA241FF331"); } }
		 public uint Age { get { return 1; } }
		 public string MachineType { get { return @"Unknown"; } }
		 public string SymbolsFileName { get { return @"ntkrnlpa.pdb"; } }
		 public uint Signature { get { return 1208111466; } }
		 public string Contents { get { return @"[""_EPROCESS"",""_KUSER_SHARED_DATA"",""_OBJECT_TYPE"",""_OBJECT_HEADER"",""_OBJECT_DIRECTORY_ENTRY"",""_OBJECT_DIRECTORY"",""_OBJECT_HEADER_CREATOR_INFO"",""_OBJECT_HEADER_NAME_INFO"",""_KPROCESS"",""_EX_PUSH_LOCK"",""_LARGE_INTEGER"",""_EX_RUNDOWN_REF"",""_LIST_ENTRY"",""_EX_FAST_REF"",""_FAST_MUTEX"",""_HARDWARE_PTE"",""_SE_AUDIT_PROCESS_CREATION_INFO"",""_MMSUPPORT"",""_KSYSTEM_TIME"",""_ERESOURCE"",""_UNICODE_STRING"",""_OBJECT_TYPE_INITIALIZER"",""_QUAD"",""_DISPATCHER_HEADER"",""_KGDTENTRY"",""_KIDTENTRY"",""_SINGLE_LIST_ENTRY"",""_KEXECUTE_OPTIONS"",""__unnamed"",""_KEVENT"",""_MMSUPPORT_FLAGS"",""_OWNER_ENTRY"",""_GENERIC_MAPPING""])"; } }
		 public string Created { get { return "16-04-2017T14:05:17"; } }
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
		public int MxStructureSize { get { return 608; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EPROCESS"": [ 608, {
				 ""Pcb"": [ 0, [ ""_KPROCESS"", ""null"" ]],
				 ""ProcessLock"": [ 108, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""CreateTime"": [ 112, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""ExitTime"": [ 120, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""RundownProtect"": [ 128, [ ""_EX_RUNDOWN_REF"", ""null"" ]],
				 ""UniqueProcessId"": [ 132, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ActiveProcessLinks"": [ 136, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""QuotaUsage"": [ 144, [ ""Array"", ""{\""count\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""QuotaPeak"": [ 156, [ ""Array"", ""{\""count\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""CommitCharge"": [ 168, [ ""UInt32"", ""null"" ]],
				 ""PeakVirtualSize"": [ 172, [ ""UInt32"", ""null"" ]],
				 ""VirtualSize"": [ 176, [ ""UInt32"", ""null"" ]],
				 ""SessionProcessLinks"": [ 180, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""DebugPort"": [ 188, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ExceptionPort"": [ 192, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ObjectTable"": [ 196, [ ""Pointer"", ""{\""target\"":\""_HANDLE_TABLE\""}"" ]],
				 ""Token"": [ 200, [ ""_EX_FAST_REF"", ""null"" ]],
				 ""WorkingSetLock"": [ 204, [ ""_FAST_MUTEX"", ""null"" ]],
				 ""WorkingSetPage"": [ 236, [ ""UInt32"", ""null"" ]],
				 ""AddressCreationLock"": [ 240, [ ""_FAST_MUTEX"", ""null"" ]],
				 ""HyperSpaceLock"": [ 272, [ ""UInt32"", ""null"" ]],
				 ""ForkInProgress"": [ 276, [ ""Pointer"", ""{\""target\"":\""_ETHREAD\""}"" ]],
				 ""HardwareTrigger"": [ 280, [ ""UInt32"", ""null"" ]],
				 ""VadRoot"": [ 284, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""VadHint"": [ 288, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CloneRoot"": [ 292, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""NumberOfPrivatePages"": [ 296, [ ""UInt32"", ""null"" ]],
				 ""NumberOfLockedPages"": [ 300, [ ""UInt32"", ""null"" ]],
				 ""Win32Process"": [ 304, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Job"": [ 308, [ ""Pointer"", ""{\""target\"":\""_EJOB\""}"" ]],
				 ""SectionObject"": [ 312, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SectionBaseAddress"": [ 316, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""QuotaBlock"": [ 320, [ ""Pointer"", ""{\""target\"":\""_EPROCESS_QUOTA_BLOCK\""}"" ]],
				 ""WorkingSetWatch"": [ 324, [ ""Pointer"", ""{\""target\"":\""_PAGEFAULT_HISTORY\""}"" ]],
				 ""Win32WindowStation"": [ 328, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""InheritedFromUniqueProcessId"": [ 332, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""LdtInformation"": [ 336, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""VadFreeHint"": [ 340, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""VdmObjects"": [ 344, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""DeviceMap"": [ 348, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""PhysicalVadList"": [ 352, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""PageDirectoryPte"": [ 360, [ ""_HARDWARE_PTE"", ""null"" ]],
				 ""Filler"": [ 360, [ ""UInt64"", ""null"" ]],
				 ""Session"": [ 368, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ImageFileName"": [ 372, [ ""Array"", ""{\""count\"":16,\""target\"":\""Byte\""}"" ]],
				 ""JobLinks"": [ 388, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""LockedPagesList"": [ 396, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ThreadListHead"": [ 400, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""SecurityPort"": [ 408, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""PaeTop"": [ 412, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ActiveThreads"": [ 416, [ ""UInt32"", ""null"" ]],
				 ""GrantedAccess"": [ 420, [ ""UInt32"", ""null"" ]],
				 ""DefaultHardErrorProcessing"": [ 424, [ ""UInt32"", ""null"" ]],
				 ""LastThreadExitStatus"": [ 428, [ ""Int32"", ""null"" ]],
				 ""Peb"": [ 432, [ ""Pointer"", ""{\""target\"":\""_PEB\""}"" ]],
				 ""PrefetchTrace"": [ 436, [ ""_EX_FAST_REF"", ""null"" ]],
				 ""ReadOperationCount"": [ 440, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""WriteOperationCount"": [ 448, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""OtherOperationCount"": [ 456, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""ReadTransferCount"": [ 464, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""WriteTransferCount"": [ 472, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""OtherTransferCount"": [ 480, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""CommitChargeLimit"": [ 488, [ ""UInt32"", ""null"" ]],
				 ""CommitChargePeak"": [ 492, [ ""UInt32"", ""null"" ]],
				 ""AweInfo"": [ 496, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SeAuditProcessCreationInfo"": [ 500, [ ""_SE_AUDIT_PROCESS_CREATION_INFO"", ""null"" ]],
				 ""Vm"": [ 504, [ ""_MMSUPPORT"", ""null"" ]],
				 ""LastFaultCount"": [ 568, [ ""UInt32"", ""null"" ]],
				 ""ModifiedPageCount"": [ 572, [ ""UInt32"", ""null"" ]],
				 ""NumberOfVads"": [ 576, [ ""UInt32"", ""null"" ]],
				 ""JobStatus"": [ 580, [ ""UInt32"", ""null"" ]],
				 ""Flags"": [ 584, [ ""UInt32"", ""null"" ]],
				 ""CreateReported"": [ 584, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""NoDebugInherit"": [ 584, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessExiting"": [ 584, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessDelete"": [ 584, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""Wow64SplitPages"": [ 584, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""VmDeleted"": [ 584, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""OutswapEnabled"": [ 584, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""Outswapped"": [ 584, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""UInt32\""}"" ]],
				 ""ForkFailed"": [ 584, [ ""BitField"", ""{\""end_bit\"":9,\""start_bit\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""HasPhysicalVad"": [ 584, [ ""BitField"", ""{\""end_bit\"":10,\""start_bit\"":9,\""target\"":\""UInt32\""}"" ]],
				 ""AddressSpaceInitialized"": [ 584, [ ""BitField"", ""{\""end_bit\"":12,\""start_bit\"":10,\""target\"":\""UInt32\""}"" ]],
				 ""SetTimerResolution"": [ 584, [ ""BitField"", ""{\""end_bit\"":13,\""start_bit\"":12,\""target\"":\""UInt32\""}"" ]],
				 ""BreakOnTermination"": [ 584, [ ""BitField"", ""{\""end_bit\"":14,\""start_bit\"":13,\""target\"":\""UInt32\""}"" ]],
				 ""SessionCreationUnderway"": [ 584, [ ""BitField"", ""{\""end_bit\"":15,\""start_bit\"":14,\""target\"":\""UInt32\""}"" ]],
				 ""WriteWatch"": [ 584, [ ""BitField"", ""{\""end_bit\"":16,\""start_bit\"":15,\""target\"":\""UInt32\""}"" ]],
				 ""ProcessInSession"": [ 584, [ ""BitField"", ""{\""end_bit\"":17,\""start_bit\"":16,\""target\"":\""UInt32\""}"" ]],
				 ""OverrideAddressSpace"": [ 584, [ ""BitField"", ""{\""end_bit\"":18,\""start_bit\"":17,\""target\"":\""UInt32\""}"" ]],
				 ""HasAddressSpace"": [ 584, [ ""BitField"", ""{\""end_bit\"":19,\""start_bit\"":18,\""target\"":\""UInt32\""}"" ]],
				 ""LaunchPrefetched"": [ 584, [ ""BitField"", ""{\""end_bit\"":20,\""start_bit\"":19,\""target\"":\""UInt32\""}"" ]],
				 ""InjectInpageErrors"": [ 584, [ ""BitField"", ""{\""end_bit\"":21,\""start_bit\"":20,\""target\"":\""UInt32\""}"" ]],
				 ""VmTopDown"": [ 584, [ ""BitField"", ""{\""end_bit\"":22,\""start_bit\"":21,\""target\"":\""UInt32\""}"" ]],
				 ""Unused3"": [ 584, [ ""BitField"", ""{\""end_bit\"":23,\""start_bit\"":22,\""target\"":\""UInt32\""}"" ]],
				 ""Unused4"": [ 584, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":23,\""target\"":\""UInt32\""}"" ]],
				 ""VdmAllowed"": [ 584, [ ""BitField"", ""{\""end_bit\"":25,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]],
				 ""Unused"": [ 584, [ ""BitField"", ""{\""end_bit\"":30,\""start_bit\"":25,\""target\"":\""UInt32\""}"" ]],
				 ""Unused1"": [ 584, [ ""BitField"", ""{\""end_bit\"":31,\""start_bit\"":30,\""target\"":\""UInt32\""}"" ]],
				 ""Unused2"": [ 584, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":31,\""target\"":\""UInt32\""}"" ]],
				 ""ExitStatus"": [ 588, [ ""Int32"", ""null"" ]],
				 ""NextPageColor"": [ 592, [ ""UInt16"", ""null"" ]],
				 ""SubSystemMinorVersion"": [ 594, [ ""Byte"", ""null"" ]],
				 ""SubSystemMajorVersion"": [ 595, [ ""Byte"", ""null"" ]],
				 ""SubSystemVersion"": [ 594, [ ""UInt16"", ""null"" ]],
				 ""PriorityClass"": [ 596, [ ""Byte"", ""null"" ]],
				 ""WorkingSetAcquiredUnsafe"": [ 597, [ ""Byte"", ""null"" ]],
				 ""Cookie"": [ 600, [ ""UInt32"", ""null"" ]] }]
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
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 108);
				return returnValue;
			}
		}
		public _LARGE_INTEGER CreateTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 112);
				return returnValue;
			}
		}
		public _LARGE_INTEGER ExitTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 120);
				return returnValue;
			}
		}
		public _EX_RUNDOWN_REF RundownProtect
		{
			get
			{
				_EX_RUNDOWN_REF returnValue = new _EX_RUNDOWN_REF(_StructureData, _BufferOffset + 128);
				return returnValue;
			}
		}
		public UInt32 UniqueProcessId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 132); } }
		public _LIST_ENTRY ActiveProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 136);
				return returnValue;
			}
		}
		public UInt32[] QuotaUsage
		{
			get
			{
				UInt32[] returnValue = new UInt32[3];
				for(int i=0; i<3; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 144);
				return returnValue;
			}
		}
		public UInt32[] QuotaPeak
		{
			get
			{
				UInt32[] returnValue = new UInt32[3];
				for(int i=0; i<3; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 156);
				return returnValue;
			}
		}
		public UInt32 CommitCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 168); } }
		public UInt32 PeakVirtualSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 172); } }
		public UInt32 VirtualSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 176); } }
		public _LIST_ENTRY SessionProcessLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 180);
				return returnValue;
			}
		}
		public UInt32 DebugPort { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 188); } }
		public UInt32 ExceptionPort { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 192); } }
		public UInt32 ObjectTable { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 196); } }
		public _EX_FAST_REF Token
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 200);
				return returnValue;
			}
		}
		public _FAST_MUTEX WorkingSetLock
		{
			get
			{
				_FAST_MUTEX returnValue = new _FAST_MUTEX(_StructureData, _BufferOffset + 204);
				return returnValue;
			}
		}
		public UInt32 WorkingSetPage { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 236); } }
		public _FAST_MUTEX AddressCreationLock
		{
			get
			{
				_FAST_MUTEX returnValue = new _FAST_MUTEX(_StructureData, _BufferOffset + 240);
				return returnValue;
			}
		}
		public UInt32 HyperSpaceLock { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 272); } }
		public UInt32 ForkInProgress { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 276); } }
		public UInt32 HardwareTrigger { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 280); } }
		public UInt32 VadRoot { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 284); } }
		public UInt32 VadHint { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 288); } }
		public UInt32 CloneRoot { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 292); } }
		public UInt32 NumberOfPrivatePages { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 296); } }
		public UInt32 NumberOfLockedPages { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 300); } }
		public UInt32 Win32Process { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 304); } }
		public UInt32 Job { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 308); } }
		public UInt32 SectionObject { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 312); } }
		public UInt32 SectionBaseAddress { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 316); } }
		public UInt32 QuotaBlock { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 320); } }
		public UInt32 WorkingSetWatch { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 324); } }
		public UInt32 Win32WindowStation { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 328); } }
		public UInt32 InheritedFromUniqueProcessId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 332); } }
		public UInt32 LdtInformation { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 336); } }
		public UInt32 VadFreeHint { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 340); } }
		public UInt32 VdmObjects { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 344); } }
		public UInt32 DeviceMap { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 348); } }
		public _LIST_ENTRY PhysicalVadList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 352);
				return returnValue;
			}
		}
		public _HARDWARE_PTE PageDirectoryPte
		{
			get
			{
				_HARDWARE_PTE returnValue = new _HARDWARE_PTE(_StructureData, _BufferOffset + 360);
				return returnValue;
			}
		}
		public UInt64 Filler { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 360); } }
		public UInt32 Session { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 368); } }
		public Byte[] ImageFileName
		{
			get
			{
				Byte[] returnValue = new Byte[16];
				for(int i=0; i<16; i++ )
					returnValue[i] = _StructureData[i + _BufferOffset + 372];
				return returnValue;
			}
		}
		public _LIST_ENTRY JobLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 388);
				return returnValue;
			}
		}
		public UInt32 LockedPagesList { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 396); } }
		public _LIST_ENTRY ThreadListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 400);
				return returnValue;
			}
		}
		public UInt32 SecurityPort { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 408); } }
		public UInt32 PaeTop { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 412); } }
		public UInt32 ActiveThreads { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 416); } }
		public UInt32 GrantedAccess { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 420); } }
		public UInt32 DefaultHardErrorProcessing { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 424); } }
		public Int32 LastThreadExitStatus { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 428); } }
		public UInt32 Peb { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 432); } }
		public _EX_FAST_REF PrefetchTrace
		{
			get
			{
				_EX_FAST_REF returnValue = new _EX_FAST_REF(_StructureData, _BufferOffset + 436);
				return returnValue;
			}
		}
		public _LARGE_INTEGER ReadOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 440);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 448);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherOperationCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 456);
				return returnValue;
			}
		}
		public _LARGE_INTEGER ReadTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 464);
				return returnValue;
			}
		}
		public _LARGE_INTEGER WriteTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 472);
				return returnValue;
			}
		}
		public _LARGE_INTEGER OtherTransferCount
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 480);
				return returnValue;
			}
		}
		public UInt32 CommitChargeLimit { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 488); } }
		public UInt32 CommitChargePeak { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 492); } }
		public UInt32 AweInfo { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 496); } }
		public _SE_AUDIT_PROCESS_CREATION_INFO SeAuditProcessCreationInfo
		{
			get
			{
				_SE_AUDIT_PROCESS_CREATION_INFO returnValue = new _SE_AUDIT_PROCESS_CREATION_INFO(_StructureData, _BufferOffset + 500);
				return returnValue;
			}
		}
		public _MMSUPPORT Vm
		{
			get
			{
				_MMSUPPORT returnValue = new _MMSUPPORT(_StructureData, _BufferOffset + 504);
				return returnValue;
			}
		}
		public UInt32 LastFaultCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 568); } }
		public UInt32 ModifiedPageCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 572); } }
		public UInt32 NumberOfVads { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 576); } }
		public UInt32 JobStatus { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 580); } }
		public UInt32 Flags { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 584); } }
		public UInt32 CreateReported
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 NoDebugInherit
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessExiting
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessDelete
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 Wow64SplitPages
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 VmDeleted
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 OutswapEnabled
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 64) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 Outswapped
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 128) >> 7;
				return (UInt32)value2;
			}
		}
		public UInt32 ForkFailed
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 256) >> 8;
				return (UInt32)value2;
			}
		}
		public UInt32 HasPhysicalVad
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 512) >> 9;
				return (UInt32)value2;
			}
		}
		public UInt32 AddressSpaceInitialized
		{
			get
			{
				// start: 10  end: 12  Mask: 0000110000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 3072) >> 10;
				return (UInt32)value2;
			}
		}
		public UInt32 SetTimerResolution
		{
			get
			{
				// start: 12  end: 13  Mask: 0001000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 4096) >> 12;
				return (UInt32)value2;
			}
		}
		public UInt32 BreakOnTermination
		{
			get
			{
				// start: 13  end: 14  Mask: 0010000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 8192) >> 13;
				return (UInt32)value2;
			}
		}
		public UInt32 SessionCreationUnderway
		{
			get
			{
				// start: 14  end: 15  Mask: 0100000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 16384) >> 14;
				return (UInt32)value2;
			}
		}
		public UInt32 WriteWatch
		{
			get
			{
				// start: 15  end: 16  Mask: 1000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 32768) >> 15;
				return (UInt32)value2;
			}
		}
		public UInt32 ProcessInSession
		{
			get
			{
				// start: 16  end: 17  Mask: 10000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 65536) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 OverrideAddressSpace
		{
			get
			{
				// start: 17  end: 18  Mask: 100000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 131072) >> 17;
				return (UInt32)value2;
			}
		}
		public UInt32 HasAddressSpace
		{
			get
			{
				// start: 18  end: 19  Mask: 1000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 262144) >> 18;
				return (UInt32)value2;
			}
		}
		public UInt32 LaunchPrefetched
		{
			get
			{
				// start: 19  end: 20  Mask: 10000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 524288) >> 19;
				return (UInt32)value2;
			}
		}
		public UInt32 InjectInpageErrors
		{
			get
			{
				// start: 20  end: 21  Mask: 100000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 1048576) >> 20;
				return (UInt32)value2;
			}
		}
		public UInt32 VmTopDown
		{
			get
			{
				// start: 21  end: 22  Mask: 1000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 2097152) >> 21;
				return (UInt32)value2;
			}
		}
		public UInt32 Unused3
		{
			get
			{
				// start: 22  end: 23  Mask: 10000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 4194304) >> 22;
				return (UInt32)value2;
			}
		}
		public UInt32 Unused4
		{
			get
			{
				// start: 23  end: 24  Mask: 100000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 8388608) >> 23;
				return (UInt32)value2;
			}
		}
		public UInt32 VdmAllowed
		{
			get
			{
				// start: 24  end: 25  Mask: 1000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 16777216) >> 24;
				return (UInt32)value2;
			}
		}
		public UInt32 Unused
		{
			get
			{
				// start: 25  end: 30  Mask: 111110000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 1040187392) >> 25;
				return (UInt32)value2;
			}
		}
		public UInt32 Unused1
		{
			get
			{
				// start: 30  end: 31  Mask: 1000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 1073741824) >> 30;
				return (UInt32)value2;
			}
		}
		public UInt32 Unused2
		{
			get
			{
				// start: 31  end: 32  Mask: 10000000000000000000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 584);
				var value2 = (value & 2147483648) >> 31;
				return (UInt32)value2;
			}
		}
		public Int32 ExitStatus { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 588); } }
		public UInt16 NextPageColor { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 592); } }
		public Byte SubSystemMinorVersion{ get { return _StructureData[_BufferOffset +594]; } }
		public Byte SubSystemMajorVersion{ get { return _StructureData[_BufferOffset +595]; } }
		public UInt16 SubSystemVersion { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 594); } }
		public Byte PriorityClass{ get { return _StructureData[_BufferOffset +596]; } }
		public Byte WorkingSetAcquiredUnsafe{ get { return _StructureData[_BufferOffset +597]; } }
		public UInt32 Cookie { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 600); } }
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
		public int MxStructureSize { get { return 824; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KUSER_SHARED_DATA"": [ 824, {
				 ""TickCountLow"": [ 0, [ ""UInt32"", ""null"" ]],
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
				 ""Reserved2"": [ 580, [ ""Array"", ""{\""count\"":8,\""target\"":\""UInt32\""}"" ]],
				 ""NtProductType"": [ 612, [ ""Enumeration"", ""{\""enum_name\"":\""_NT_PRODUCT_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""ProductTypeIsValid"": [ 616, [ ""Byte"", ""null"" ]],
				 ""NtMajorVersion"": [ 620, [ ""UInt32"", ""null"" ]],
				 ""NtMinorVersion"": [ 624, [ ""UInt32"", ""null"" ]],
				 ""ProcessorFeatures"": [ 628, [ ""Array"", ""{\""count\"":64,\""target\"":\""Byte\""}"" ]],
				 ""Reserved1"": [ 692, [ ""UInt32"", ""null"" ]],
				 ""Reserved3"": [ 696, [ ""UInt32"", ""null"" ]],
				 ""TimeSlip"": [ 700, [ ""UInt32"", ""null"" ]],
				 ""AlternativeArchitecture"": [ 704, [ ""Enumeration"", ""{\""enum_name\"":\""_ALTERNATIVE_ARCHITECTURE_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""SystemExpirationDate"": [ 712, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""SuiteMask"": [ 720, [ ""UInt32"", ""null"" ]],
				 ""KdDebuggerEnabled"": [ 724, [ ""Byte"", ""null"" ]],
				 ""NXSupportPolicy"": [ 725, [ ""Byte"", ""null"" ]],
				 ""ActiveConsoleId"": [ 728, [ ""UInt32"", ""null"" ]],
				 ""DismountCount"": [ 732, [ ""UInt32"", ""null"" ]],
				 ""ComPlusPackage"": [ 736, [ ""UInt32"", ""null"" ]],
				 ""LastSystemRITEventTickCount"": [ 740, [ ""UInt32"", ""null"" ]],
				 ""NumberOfPhysicalPages"": [ 744, [ ""UInt32"", ""null"" ]],
				 ""SafeBootMode"": [ 748, [ ""Byte"", ""null"" ]],
				 ""TraceLogging"": [ 752, [ ""UInt32"", ""null"" ]],
				 ""TestRetInstruction"": [ 760, [ ""UInt64"", ""null"" ]],
				 ""SystemCall"": [ 768, [ ""UInt32"", ""null"" ]],
				 ""SystemCallReturn"": [ 772, [ ""UInt32"", ""null"" ]],
				 ""SystemCallPad"": [ 776, [ ""Array"", ""{\""count\"":3,\""target\"":\""UInt64\""}"" ]],
				 ""TickCount"": [ 800, [ ""_KSYSTEM_TIME"", ""null"" ]],
				 ""TickCountQuad"": [ 800, [ ""UInt64"", ""null"" ]],
				 ""Cookie"": [ 816, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 TickCountLow { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
		public UInt32[] Reserved2
		{
			get
			{
				UInt32[] returnValue = new UInt32[8];
				for(int i=0; i<8; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 580);
				return returnValue;
			}
		}
		public _NT_PRODUCT_TYPE NtProductType { get { return (_NT_PRODUCT_TYPE)BitConverter.ToUInt32(_StructureData, _BufferOffset + 612); } }
		public Byte ProductTypeIsValid{ get { return _StructureData[_BufferOffset +616]; } }
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
		public Byte NXSupportPolicy{ get { return _StructureData[_BufferOffset +725]; } }
		public UInt32 ActiveConsoleId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 728); } }
		public UInt32 DismountCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 732); } }
		public UInt32 ComPlusPackage { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 736); } }
		public UInt32 LastSystemRITEventTickCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 740); } }
		public UInt32 NumberOfPhysicalPages { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 744); } }
		public Byte SafeBootMode{ get { return _StructureData[_BufferOffset +748]; } }
		public UInt32 TraceLogging { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 752); } }
		public UInt64 TestRetInstruction { get { return BitConverter.ToUInt64(_StructureData, _BufferOffset + 760); } }
		public UInt32 SystemCall { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 768); } }
		public UInt32 SystemCallReturn { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 772); } }
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
		public UInt32 Cookie { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 816); } }
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
		public int MxStructureSize { get { return 400; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_TYPE"": [ 400, {
				 ""Mutex"": [ 0, [ ""_ERESOURCE"", ""null"" ]],
				 ""TypeList"": [ 56, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""Name"": [ 64, [ ""_UNICODE_STRING"", ""null"" ]],
				 ""DefaultObject"": [ 72, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Index"": [ 76, [ ""UInt32"", ""null"" ]],
				 ""TotalNumberOfObjects"": [ 80, [ ""UInt32"", ""null"" ]],
				 ""TotalNumberOfHandles"": [ 84, [ ""UInt32"", ""null"" ]],
				 ""HighWaterNumberOfObjects"": [ 88, [ ""UInt32"", ""null"" ]],
				 ""HighWaterNumberOfHandles"": [ 92, [ ""UInt32"", ""null"" ]],
				 ""TypeInfo"": [ 96, [ ""_OBJECT_TYPE_INITIALIZER"", ""null"" ]],
				 ""Key"": [ 172, [ ""UInt32"", ""null"" ]],
				 ""ObjectLocks"": [ 176, [ ""Array"", ""{\""count\"":4,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""\""}}"" ]] }]
				 }
				)";
			}
		}
		public _ERESOURCE Mutex
		{
			get
			{
				_ERESOURCE returnValue = new _ERESOURCE(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _LIST_ENTRY TypeList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 56);
				return returnValue;
			}
		}
		public _UNICODE_STRING Name
		{
			get
			{
				_UNICODE_STRING returnValue = new _UNICODE_STRING(_StructureData, _BufferOffset + 64);
				return returnValue;
			}
		}
		public UInt32 DefaultObject { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 72); } }
		public UInt32 Index { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 76); } }
		public UInt32 TotalNumberOfObjects { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 80); } }
		public UInt32 TotalNumberOfHandles { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 84); } }
		public UInt32 HighWaterNumberOfObjects { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 88); } }
		public UInt32 HighWaterNumberOfHandles { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 92); } }
		public _OBJECT_TYPE_INITIALIZER TypeInfo
		{
			get
			{
				_OBJECT_TYPE_INITIALIZER returnValue = new _OBJECT_TYPE_INITIALIZER(_StructureData, _BufferOffset + 96);
				return returnValue;
			}
		}
		public UInt32 Key { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 172); } }
		public _ERESOURCE[] ObjectLocks
		{
			get
			{
				_ERESOURCE[] returnValue = new _ERESOURCE[4];
				int size = returnValue[0].MxStructureSize;
				for(int i=0; i<4; i++ )
					returnValue[i] = new _ERESOURCE(_StructureData, (i * size) + _BufferOffset + 176);
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
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER"": [ 32, {
				 ""PointerCount"": [ 0, [ ""Int32"", ""null"" ]],
				 ""HandleCount"": [ 4, [ ""Int32"", ""null"" ]],
				 ""NextToFree"": [ 4, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Type"": [ 8, [ ""Pointer"", ""{\""target\"":\""_OBJECT_TYPE\""}"" ]],
				 ""NameInfoOffset"": [ 12, [ ""Byte"", ""null"" ]],
				 ""HandleInfoOffset"": [ 13, [ ""Byte"", ""null"" ]],
				 ""QuotaInfoOffset"": [ 14, [ ""Byte"", ""null"" ]],
				 ""Flags"": [ 15, [ ""Byte"", ""null"" ]],
				 ""ObjectCreateInfo"": [ 16, [ ""Pointer"", ""{\""target\"":\""_OBJECT_CREATE_INFORMATION\""}"" ]],
				 ""QuotaBlockCharged"": [ 16, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SecurityDescriptor"": [ 20, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""Body"": [ 24, [ ""_QUAD"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int32 PointerCount { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 HandleCount { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 NextToFree { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 Type { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public Byte NameInfoOffset{ get { return _StructureData[_BufferOffset +12]; } }
		public Byte HandleInfoOffset{ get { return _StructureData[_BufferOffset +13]; } }
		public Byte QuotaInfoOffset{ get { return _StructureData[_BufferOffset +14]; } }
		public Byte Flags{ get { return _StructureData[_BufferOffset +15]; } }
		public UInt32 ObjectCreateInfo { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public UInt32 QuotaBlockCharged { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public UInt32 SecurityDescriptor { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 20); } }
		public _QUAD Body
		{
			get
			{
				_QUAD returnValue = new _QUAD(_StructureData, _BufferOffset + 24);
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
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_DIRECTORY_ENTRY"": [ 8, {
				 ""ChainLink"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_DIRECTORY_ENTRY\""}"" ]],
				 ""Object"": [ 4, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 ChainLink { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Object { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
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
		public int MxStructureSize { get { return 164; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_DIRECTORY"": [ 164, {
				 ""HashBuckets"": [ 0, [ ""Array"", ""{\""count\"":37,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""_OBJECT_DIRECTORY_ENTRY\""}}"" ]],
				 ""Lock"": [ 148, [ ""_EX_PUSH_LOCK"", ""null"" ]],
				 ""DeviceMap"": [ 152, [ ""Pointer"", ""{\""target\"":\""_DEVICE_MAP\""}"" ]],
				 ""SessionId"": [ 156, [ ""UInt32"", ""null"" ]],
				 ""Reserved"": [ 160, [ ""UInt16"", ""null"" ]],
				 ""SymbolicLinkUsageCount"": [ 162, [ ""UInt16"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32[] HashBuckets
		{
			get
			{
				UInt32[] returnValue = new UInt32[37];
				int size = 4;
				for(int i=0; i<37; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * size) + _BufferOffset + 0);
				return returnValue;
			}
		}
		public _EX_PUSH_LOCK Lock
		{
			get
			{
				_EX_PUSH_LOCK returnValue = new _EX_PUSH_LOCK(_StructureData, _BufferOffset + 148);
				return returnValue;
			}
		}
		public UInt32 DeviceMap { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 152); } }
		public UInt32 SessionId { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 156); } }
		public UInt16 Reserved { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 160); } }
		public UInt16 SymbolicLinkUsageCount { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 162); } }
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
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_CREATOR_INFO"": [ 16, {
				 ""TypeList"": [ 0, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""CreatorUniqueProcess"": [ 8, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CreatorBackTraceIndex"": [ 12, [ ""UInt16"", ""null"" ]],
				 ""Reserved"": [ 14, [ ""UInt16"", ""null"" ]] }]
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
		public UInt32 CreatorUniqueProcess { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public UInt16 CreatorBackTraceIndex { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 12); } }
		public UInt16 Reserved { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 14); } }
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
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_HEADER_NAME_INFO"": [ 16, {
				 ""Directory"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_DIRECTORY\""}"" ]],
				 ""Name"": [ 4, [ ""_UNICODE_STRING"", ""null"" ]],
				 ""QueryReferences"": [ 12, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Directory { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public _UNICODE_STRING Name
		{
			get
			{
				_UNICODE_STRING returnValue = new _UNICODE_STRING(_StructureData, _BufferOffset + 4);
				return returnValue;
			}
		}
		public UInt32 QueryReferences { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 12); } }
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
		public int MxStructureSize { get { return 108; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KPROCESS"": [ 108, {
				 ""Header"": [ 0, [ ""_DISPATCHER_HEADER"", ""null"" ]],
				 ""ProfileListHead"": [ 16, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""DirectoryTableBase"": [ 24, [ ""Array"", ""{\""count\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""LdtDescriptor"": [ 32, [ ""_KGDTENTRY"", ""null"" ]],
				 ""Int21Descriptor"": [ 40, [ ""_KIDTENTRY"", ""null"" ]],
				 ""IopmOffset"": [ 48, [ ""UInt16"", ""null"" ]],
				 ""Iopl"": [ 50, [ ""Byte"", ""null"" ]],
				 ""Unused"": [ 51, [ ""Byte"", ""null"" ]],
				 ""ActiveProcessors"": [ 52, [ ""UInt32"", ""null"" ]],
				 ""KernelTime"": [ 56, [ ""UInt32"", ""null"" ]],
				 ""UserTime"": [ 60, [ ""UInt32"", ""null"" ]],
				 ""ReadyListHead"": [ 64, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""SwapListEntry"": [ 72, [ ""_SINGLE_LIST_ENTRY"", ""null"" ]],
				 ""VdmTrapcHandler"": [ 76, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ThreadListHead"": [ 80, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""ProcessLock"": [ 88, [ ""UInt32"", ""null"" ]],
				 ""Affinity"": [ 92, [ ""UInt32"", ""null"" ]],
				 ""StackCount"": [ 96, [ ""UInt16"", ""null"" ]],
				 ""BasePriority"": [ 98, [ ""Char"", ""null"" ]],
				 ""ThreadQuantum"": [ 99, [ ""Char"", ""null"" ]],
				 ""AutoAlignment"": [ 100, [ ""Byte"", ""null"" ]],
				 ""State"": [ 101, [ ""Byte"", ""null"" ]],
				 ""ThreadSeed"": [ 102, [ ""Byte"", ""null"" ]],
				 ""DisableBoost"": [ 103, [ ""Byte"", ""null"" ]],
				 ""PowerState"": [ 104, [ ""Byte"", ""null"" ]],
				 ""DisableQuantum"": [ 105, [ ""Byte"", ""null"" ]],
				 ""IdealNode"": [ 106, [ ""Byte"", ""null"" ]],
				 ""Flags"": [ 107, [ ""_KEXECUTE_OPTIONS"", ""null"" ]],
				 ""ExecuteOptions"": [ 107, [ ""Byte"", ""null"" ]] }]
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
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 16);
				return returnValue;
			}
		}
		public UInt32[] DirectoryTableBase
		{
			get
			{
				UInt32[] returnValue = new UInt32[2];
				for(int i=0; i<2; i++ )
					returnValue[i] = BitConverter.ToUInt32(_StructureData, (i * sizeof(UInt32)) + _BufferOffset + 24);
				return returnValue;
			}
		}
		public _KGDTENTRY LdtDescriptor
		{
			get
			{
				_KGDTENTRY returnValue = new _KGDTENTRY(_StructureData, _BufferOffset + 32);
				return returnValue;
			}
		}
		public _KIDTENTRY Int21Descriptor
		{
			get
			{
				_KIDTENTRY returnValue = new _KIDTENTRY(_StructureData, _BufferOffset + 40);
				return returnValue;
			}
		}
		public UInt16 IopmOffset { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 48); } }
		public Byte Iopl{ get { return _StructureData[_BufferOffset +50]; } }
		public Byte Unused{ get { return _StructureData[_BufferOffset +51]; } }
		public UInt32 ActiveProcessors { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 52); } }
		public UInt32 KernelTime { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 56); } }
		public UInt32 UserTime { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 60); } }
		public _LIST_ENTRY ReadyListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 64);
				return returnValue;
			}
		}
		public _SINGLE_LIST_ENTRY SwapListEntry
		{
			get
			{
				_SINGLE_LIST_ENTRY returnValue = new _SINGLE_LIST_ENTRY(_StructureData, _BufferOffset + 72);
				return returnValue;
			}
		}
		public UInt32 VdmTrapcHandler { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 76); } }
		public _LIST_ENTRY ThreadListHead
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 80);
				return returnValue;
			}
		}
		public UInt32 ProcessLock { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 88); } }
		public UInt32 Affinity { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 92); } }
		public UInt16 StackCount { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 96); } }
		public Char BasePriority { get { return BitConverter.ToChar(_StructureData, _BufferOffset + 98); } }
		public Char ThreadQuantum { get { return BitConverter.ToChar(_StructureData, _BufferOffset + 99); } }
		public Byte AutoAlignment{ get { return _StructureData[_BufferOffset +100]; } }
		public Byte State{ get { return _StructureData[_BufferOffset +101]; } }
		public Byte ThreadSeed{ get { return _StructureData[_BufferOffset +102]; } }
		public Byte DisableBoost{ get { return _StructureData[_BufferOffset +103]; } }
		public Byte PowerState{ get { return _StructureData[_BufferOffset +104]; } }
		public Byte DisableQuantum{ get { return _StructureData[_BufferOffset +105]; } }
		public Byte IdealNode{ get { return _StructureData[_BufferOffset +106]; } }
		public _KEXECUTE_OPTIONS Flags
		{
			get
			{
				_KEXECUTE_OPTIONS returnValue = new _KEXECUTE_OPTIONS(_StructureData, _BufferOffset + 107);
				return returnValue;
			}
		}
		public Byte ExecuteOptions{ get { return _StructureData[_BufferOffset +107]; } }
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
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_PUSH_LOCK"": [ 4, {
				 ""Waiting"": [ 0, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""Exclusive"": [ 0, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""Shared"": [ 0, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""Value"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""Ptr"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Waiting
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 Exclusive
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 Shared
		{
			get
			{
				// start: 2  end: 32  Mask: 11111111111111111111111111111100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4294967292) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 Value { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Ptr { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
				 ""u"": [ 0, [ ""__unnamed"", ""null"" ]],
				 ""QuadPart"": [ 0, [ ""Int64"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 LowPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 HighPart { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public __unnamed u
		{
			get
			{
				__unnamed returnValue = new __unnamed(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public Int64 QuadPart { get { return BitConverter.ToInt64(_StructureData, _BufferOffset + 0); } }
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
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_RUNDOWN_REF"": [ 4, {
				 ""Count"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""Ptr"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Count { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Ptr { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_LIST_ENTRY"": [ 8, {
				 ""Flink"": [ 0, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]],
				 ""Blink"": [ 4, [ ""Pointer"", ""{\""target\"":\""_LIST_ENTRY\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Flink { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Blink { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
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
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_EX_FAST_REF"": [ 4, {
				 ""Object"": [ 0, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""RefCnt"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""Value"": [ 0, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Object { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 RefCnt
		{
			get
			{
				// start: 0  end: 3  Mask: 0000000000000111
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 7) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 Value { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
		public int MxStructureSize { get { return 32; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_FAST_MUTEX"": [ 32, {
				 ""Count"": [ 0, [ ""Int32"", ""null"" ]],
				 ""Owner"": [ 4, [ ""Pointer"", ""{\""target\"":\""_KTHREAD\""}"" ]],
				 ""Contention"": [ 8, [ ""UInt32"", ""null"" ]],
				 ""Event"": [ 12, [ ""_KEVENT"", ""null"" ]],
				 ""OldIrql"": [ 28, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Int32 Count { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 Owner { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 Contention { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public _KEVENT Event
		{
			get
			{
				_KEVENT returnValue = new _KEVENT(_StructureData, _BufferOffset + 12);
				return returnValue;
			}
		}
		public UInt32 OldIrql { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 28); } }
	}
	#endregion
	#region _HARDWARE_PTE
 
	public class _HARDWARE_PTE
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _HARDWARE_PTE(Byte[] Buffer, int PartitionOffset)
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
				 ""_HARDWARE_PTE"": [ 8, {
				 ""Valid"": [ 0, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt64\""}"" ]],
				 ""Write"": [ 0, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt64\""}"" ]],
				 ""Owner"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt64\""}"" ]],
				 ""WriteThrough"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt64\""}"" ]],
				 ""CacheDisable"": [ 0, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt64\""}"" ]],
				 ""Accessed"": [ 0, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt64\""}"" ]],
				 ""Dirty"": [ 0, [ ""BitField"", ""{\""end_bit\"":7,\""start_bit\"":6,\""target\"":\""UInt64\""}"" ]],
				 ""LargePage"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":7,\""target\"":\""UInt64\""}"" ]],
				 ""Global"": [ 0, [ ""BitField"", ""{\""end_bit\"":9,\""start_bit\"":8,\""target\"":\""UInt64\""}"" ]],
				 ""CopyOnWrite"": [ 0, [ ""BitField"", ""{\""end_bit\"":10,\""start_bit\"":9,\""target\"":\""UInt64\""}"" ]],
				 ""Prototype"": [ 0, [ ""BitField"", ""{\""end_bit\"":11,\""start_bit\"":10,\""target\"":\""UInt64\""}"" ]],
				 ""reserved0"": [ 0, [ ""BitField"", ""{\""end_bit\"":12,\""start_bit\"":11,\""target\"":\""UInt64\""}"" ]],
				 ""PageFrameNumber"": [ 0, [ ""BitField"", ""{\""end_bit\"":38,\""start_bit\"":12,\""target\"":\""UInt64\""}"" ]],
				 ""reserved1"": [ 0, [ ""BitField"", ""{\""end_bit\"":64,\""start_bit\"":38,\""target\"":\""UInt64\""}"" ]],
				 ""LowPart"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""HighPart"": [ 4, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt64 Valid
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1) >> 0;
				return (UInt64)value2;
			}
		}
		public UInt64 Write
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2) >> 1;
				return (UInt64)value2;
			}
		}
		public UInt64 Owner
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4) >> 2;
				return (UInt64)value2;
			}
		}
		public UInt64 WriteThrough
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 8) >> 3;
				return (UInt64)value2;
			}
		}
		public UInt64 CacheDisable
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 16) >> 4;
				return (UInt64)value2;
			}
		}
		public UInt64 Accessed
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 32) >> 5;
				return (UInt64)value2;
			}
		}
		public UInt64 Dirty
		{
			get
			{
				// start: 6  end: 7  Mask: 0000000001000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 64) >> 6;
				return (UInt64)value2;
			}
		}
		public UInt64 LargePage
		{
			get
			{
				// start: 7  end: 8  Mask: 0000000010000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 128) >> 7;
				return (UInt64)value2;
			}
		}
		public UInt64 Global
		{
			get
			{
				// start: 8  end: 9  Mask: 0000000100000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 256) >> 8;
				return (UInt64)value2;
			}
		}
		public UInt64 CopyOnWrite
		{
			get
			{
				// start: 9  end: 10  Mask: 0000001000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 512) >> 9;
				return (UInt64)value2;
			}
		}
		public UInt64 Prototype
		{
			get
			{
				// start: 10  end: 11  Mask: 0000010000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1024) >> 10;
				return (UInt64)value2;
			}
		}
		public UInt64 reserved0
		{
			get
			{
				// start: 11  end: 12  Mask: 0000100000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2048) >> 11;
				return (UInt64)value2;
			}
		}
		public UInt64 PageFrameNumber
		{
			get
			{
				// start: 12  end: 38  Mask: 00000011111111111111111111000000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4294963200) >> 12;
				return (UInt64)value2;
			}
		}
		public UInt64 reserved1
		{
			get
			{
				// start: 38  end: 64  Mask: 0000000000000000000000000000000000000000000000000000000000000000
				var value = BitConverter.ToUInt64(_StructureData, _BufferOffset + 0);
				var value2 = (value & 0) >> 38;
				return (UInt64)value2;
			}
		}
		public UInt32 LowPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public UInt32 HighPart { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
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
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_SE_AUDIT_PROCESS_CREATION_INFO"": [ 4, {
				 ""ImageFileName"": [ 0, [ ""Pointer"", ""{\""target\"":\""_OBJECT_NAME_INFORMATION\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 ImageFileName { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
		public int MxStructureSize { get { return 64; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_MMSUPPORT"": [ 64, {
				 ""LastTrimTime"": [ 0, [ ""_LARGE_INTEGER"", ""null"" ]],
				 ""Flags"": [ 8, [ ""_MMSUPPORT_FLAGS"", ""null"" ]],
				 ""PageFaultCount"": [ 12, [ ""UInt32"", ""null"" ]],
				 ""PeakWorkingSetSize"": [ 16, [ ""UInt32"", ""null"" ]],
				 ""WorkingSetSize"": [ 20, [ ""UInt32"", ""null"" ]],
				 ""MinimumWorkingSetSize"": [ 24, [ ""UInt32"", ""null"" ]],
				 ""MaximumWorkingSetSize"": [ 28, [ ""UInt32"", ""null"" ]],
				 ""VmWorkingSetList"": [ 32, [ ""Pointer"", ""{\""target\"":\""_MMWSL\""}"" ]],
				 ""WorkingSetExpansionLinks"": [ 36, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""Claim"": [ 44, [ ""UInt32"", ""null"" ]],
				 ""NextEstimationSlot"": [ 48, [ ""UInt32"", ""null"" ]],
				 ""NextAgingSlot"": [ 52, [ ""UInt32"", ""null"" ]],
				 ""EstimatedAvailable"": [ 56, [ ""UInt32"", ""null"" ]],
				 ""GrowthSinceLastEstimate"": [ 60, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _LARGE_INTEGER LastTrimTime
		{
			get
			{
				_LARGE_INTEGER returnValue = new _LARGE_INTEGER(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public _MMSUPPORT_FLAGS Flags
		{
			get
			{
				_MMSUPPORT_FLAGS returnValue = new _MMSUPPORT_FLAGS(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
		public UInt32 PageFaultCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 12); } }
		public UInt32 PeakWorkingSetSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public UInt32 WorkingSetSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 20); } }
		public UInt32 MinimumWorkingSetSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 24); } }
		public UInt32 MaximumWorkingSetSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 28); } }
		public UInt32 VmWorkingSetList { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 32); } }
		public _LIST_ENTRY WorkingSetExpansionLinks
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 36);
				return returnValue;
			}
		}
		public UInt32 Claim { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 44); } }
		public UInt32 NextEstimationSlot { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
		public UInt32 NextAgingSlot { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 52); } }
		public UInt32 EstimatedAvailable { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 56); } }
		public UInt32 GrowthSinceLastEstimate { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 60); } }
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
	#region _ERESOURCE
 
	public class _ERESOURCE
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _ERESOURCE(Byte[] Buffer, int PartitionOffset)
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
				 ""_ERESOURCE"": [ 56, {
				 ""SystemResourcesList"": [ 0, [ ""_LIST_ENTRY"", ""null"" ]],
				 ""OwnerTable"": [ 8, [ ""Pointer"", ""{\""target\"":\""_OWNER_ENTRY\""}"" ]],
				 ""ActiveCount"": [ 12, [ ""Int16"", ""null"" ]],
				 ""Flag"": [ 14, [ ""UInt16"", ""null"" ]],
				 ""SharedWaiters"": [ 16, [ ""Pointer"", ""{\""target\"":\""_KSEMAPHORE\""}"" ]],
				 ""ExclusiveWaiters"": [ 20, [ ""Pointer"", ""{\""target\"":\""_KEVENT\""}"" ]],
				 ""OwnerThreads"": [ 24, [ ""Array"", ""{\""count\"":2,\""target\"":\""Pointer\"",\""target_args\"":{\""target\"":\""\""}}"" ]],
				 ""ContentionCount"": [ 40, [ ""UInt32"", ""null"" ]],
				 ""NumberOfSharedWaiters"": [ 44, [ ""UInt16"", ""null"" ]],
				 ""NumberOfExclusiveWaiters"": [ 46, [ ""UInt16"", ""null"" ]],
				 ""Address"": [ 48, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CreatorBackTraceIndex"": [ 48, [ ""UInt32"", ""null"" ]],
				 ""SpinLock"": [ 52, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public _LIST_ENTRY SystemResourcesList
		{
			get
			{
				_LIST_ENTRY returnValue = new _LIST_ENTRY(_StructureData, _BufferOffset + 0);
				return returnValue;
			}
		}
		public UInt32 OwnerTable { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 8); } }
		public Int16 ActiveCount { get { return BitConverter.ToInt16(_StructureData, _BufferOffset + 12); } }
		public UInt16 Flag { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 14); } }
		public UInt32 SharedWaiters { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 16); } }
		public UInt32 ExclusiveWaiters { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 20); } }
		public _OWNER_ENTRY[] OwnerThreads
		{
			get
			{
				_OWNER_ENTRY[] returnValue = new _OWNER_ENTRY[2];
				int size = returnValue[0].MxStructureSize;
				for(int i=0; i<2; i++ )
					returnValue[i] = new _OWNER_ENTRY(_StructureData, (i * size) + _BufferOffset + 24);
				return returnValue;
			}
		}
		public UInt32 ContentionCount { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 40); } }
		public UInt16 NumberOfSharedWaiters { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 44); } }
		public UInt16 NumberOfExclusiveWaiters { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 46); } }
		public UInt32 Address { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
		public UInt32 CreatorBackTraceIndex { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
		public UInt32 SpinLock { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 52); } }
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
		public int MxStructureSize { get { return 8; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_UNICODE_STRING"": [ 8, {
				 ""Length"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""MaximumLength"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""Buffer"": [ 4, [ ""Pointer"", ""{\""target\"":\""UInt16\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Length { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 MaximumLength { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public UInt32 Buffer { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
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
		public int MxStructureSize { get { return 76; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_OBJECT_TYPE_INITIALIZER"": [ 76, {
				 ""Length"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""UseDefaultObject"": [ 2, [ ""Byte"", ""null"" ]],
				 ""CaseInsensitive"": [ 3, [ ""Byte"", ""null"" ]],
				 ""InvalidAttributes"": [ 4, [ ""UInt32"", ""null"" ]],
				 ""GenericMapping"": [ 8, [ ""_GENERIC_MAPPING"", ""null"" ]],
				 ""ValidAccessMask"": [ 24, [ ""UInt32"", ""null"" ]],
				 ""SecurityRequired"": [ 28, [ ""Byte"", ""null"" ]],
				 ""MaintainHandleCount"": [ 29, [ ""Byte"", ""null"" ]],
				 ""MaintainTypeList"": [ 30, [ ""Byte"", ""null"" ]],
				 ""PoolType"": [ 32, [ ""Enumeration"", ""{\""enum_name\"":\""_POOL_TYPE\"",\""target\"":\""UInt32\""}"" ]],
				 ""DefaultPagedPoolCharge"": [ 36, [ ""UInt32"", ""null"" ]],
				 ""DefaultNonPagedPoolCharge"": [ 40, [ ""UInt32"", ""null"" ]],
				 ""DumpProcedure"": [ 44, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""OpenProcedure"": [ 48, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""CloseProcedure"": [ 52, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""DeleteProcedure"": [ 56, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""ParseProcedure"": [ 60, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""SecurityProcedure"": [ 64, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""QueryNameProcedure"": [ 68, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]],
				 ""OkayToCloseProcedure"": [ 72, [ ""Pointer"", ""{\""target\"":\""void\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Length { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public Byte UseDefaultObject{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte CaseInsensitive{ get { return _StructureData[_BufferOffset +3]; } }
		public UInt32 InvalidAttributes { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
		public _GENERIC_MAPPING GenericMapping
		{
			get
			{
				_GENERIC_MAPPING returnValue = new _GENERIC_MAPPING(_StructureData, _BufferOffset + 8);
				return returnValue;
			}
		}
		public UInt32 ValidAccessMask { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 24); } }
		public Byte SecurityRequired{ get { return _StructureData[_BufferOffset +28]; } }
		public Byte MaintainHandleCount{ get { return _StructureData[_BufferOffset +29]; } }
		public Byte MaintainTypeList{ get { return _StructureData[_BufferOffset +30]; } }
		public _POOL_TYPE PoolType { get { return (_POOL_TYPE)BitConverter.ToUInt32(_StructureData, _BufferOffset + 32); } }
		public UInt32 DefaultPagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 36); } }
		public UInt32 DefaultNonPagedPoolCharge { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 40); } }
		public UInt32 DumpProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 44); } }
		public UInt32 OpenProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 48); } }
		public UInt32 CloseProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 52); } }
		public UInt32 DeleteProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 56); } }
		public UInt32 ParseProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 60); } }
		public UInt32 SecurityProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 64); } }
		public UInt32 QueryNameProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 68); } }
		public UInt32 OkayToCloseProcedure { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 72); } }
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
				 ""DoNotUseThisField"": [ 0, [ ""Double"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Double DoNotUseThisField { get { return BitConverter.ToDouble(_StructureData, _BufferOffset + 0); } }
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
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_DISPATCHER_HEADER"": [ 16, {
				 ""Type"": [ 0, [ ""Byte"", ""null"" ]],
				 ""Absolute"": [ 1, [ ""Byte"", ""null"" ]],
				 ""Size"": [ 2, [ ""Byte"", ""null"" ]],
				 ""Inserted"": [ 3, [ ""Byte"", ""null"" ]],
				 ""SignalState"": [ 4, [ ""Int32"", ""null"" ]],
				 ""WaitListHead"": [ 8, [ ""_LIST_ENTRY"", ""null"" ]] }]
				 }
				)";
			}
		}
		public Byte Type{ get { return _StructureData[_BufferOffset +0]; } }
		public Byte Absolute{ get { return _StructureData[_BufferOffset +1]; } }
		public Byte Size{ get { return _StructureData[_BufferOffset +2]; } }
		public Byte Inserted{ get { return _StructureData[_BufferOffset +3]; } }
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
	#region _KGDTENTRY
 
	public class _KGDTENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KGDTENTRY(Byte[] Buffer, int PartitionOffset)
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
				 ""_KGDTENTRY"": [ 8, {
				 ""LimitLow"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""BaseLow"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""HighWord"": [ 4, [ ""__unnamed"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt16 LimitLow { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 BaseLow { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public __unnamed HighWord
		{
			get
			{
				__unnamed returnValue = new __unnamed(_StructureData, _BufferOffset + 4);
				return returnValue;
			}
		}
	}
	#endregion
	#region _KIDTENTRY
 
	public class _KIDTENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _KIDTENTRY(Byte[] Buffer, int PartitionOffset)
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
				 ""_KIDTENTRY"": [ 8, {
				 ""Offset"": [ 0, [ ""UInt16"", ""null"" ]],
				 ""Selector"": [ 2, [ ""UInt16"", ""null"" ]],
				 ""Access"": [ 4, [ ""UInt16"", ""null"" ]],
				 ""ExtendedOffset"": [ 6, [ ""UInt16"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt16 Offset { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 0); } }
		public UInt16 Selector { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 2); } }
		public UInt16 Access { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 4); } }
		public UInt16 ExtendedOffset { get { return BitConverter.ToUInt16(_StructureData, _BufferOffset + 6); } }
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
		public int MxStructureSize { get { return 4; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_SINGLE_LIST_ENTRY"": [ 4, {
				 ""Next"": [ 0, [ ""Pointer"", ""{\""target\"":\""_SINGLE_LIST_ENTRY\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 Next { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
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
				 ""Spare"": [ 0, [ ""BitField"", ""{\""end_bit\"":8,\""start_bit\"":6,\""target\"":\""Byte\""}"" ]] }]
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
		public Byte Spare
		{
			get
			{
				// start: 6  end: 8  Mask: 0000000011000000
				Byte value = _StructureData[_BufferOffset + 0];
				var value2 = (value & 192) >> 6;
				return (Byte)value2;
			}
		}
	}
	#endregion
	#region __unnamed
 
	public class __unnamed
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public __unnamed(Byte[] Buffer, int PartitionOffset)
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
				 ""__unnamed"": [ 8, {
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
		public int MxStructureSize { get { return 16; } }
		public string manifest
		{
			get
			{
				return @"(
				{
				 ""_KEVENT"": [ 16, {
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
				 ""SessionSpace"": [ 0, [ ""BitField"", ""{\""end_bit\"":1,\""start_bit\"":0,\""target\"":\""UInt32\""}"" ]],
				 ""BeingTrimmed"": [ 0, [ ""BitField"", ""{\""end_bit\"":2,\""start_bit\"":1,\""target\"":\""UInt32\""}"" ]],
				 ""SessionLeader"": [ 0, [ ""BitField"", ""{\""end_bit\"":3,\""start_bit\"":2,\""target\"":\""UInt32\""}"" ]],
				 ""TrimHard"": [ 0, [ ""BitField"", ""{\""end_bit\"":4,\""start_bit\"":3,\""target\"":\""UInt32\""}"" ]],
				 ""WorkingSetHard"": [ 0, [ ""BitField"", ""{\""end_bit\"":5,\""start_bit\"":4,\""target\"":\""UInt32\""}"" ]],
				 ""AddressSpaceBeingDeleted"": [ 0, [ ""BitField"", ""{\""end_bit\"":6,\""start_bit\"":5,\""target\"":\""UInt32\""}"" ]],
				 ""Available"": [ 0, [ ""BitField"", ""{\""end_bit\"":16,\""start_bit\"":6,\""target\"":\""UInt32\""}"" ]],
				 ""AllowWorkingSetAdjustment"": [ 0, [ ""BitField"", ""{\""end_bit\"":24,\""start_bit\"":16,\""target\"":\""UInt32\""}"" ]],
				 ""MemoryPriority"": [ 0, [ ""BitField"", ""{\""end_bit\"":32,\""start_bit\"":24,\""target\"":\""UInt32\""}"" ]] }]
				 }
				)";
			}
		}
		public UInt32 SessionSpace
		{
			get
			{
				// start: 0  end: 1  Mask: 0000000000000001
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 1) >> 0;
				return (UInt32)value2;
			}
		}
		public UInt32 BeingTrimmed
		{
			get
			{
				// start: 1  end: 2  Mask: 0000000000000010
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 2) >> 1;
				return (UInt32)value2;
			}
		}
		public UInt32 SessionLeader
		{
			get
			{
				// start: 2  end: 3  Mask: 0000000000000100
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 4) >> 2;
				return (UInt32)value2;
			}
		}
		public UInt32 TrimHard
		{
			get
			{
				// start: 3  end: 4  Mask: 0000000000001000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 8) >> 3;
				return (UInt32)value2;
			}
		}
		public UInt32 WorkingSetHard
		{
			get
			{
				// start: 4  end: 5  Mask: 0000000000010000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 16) >> 4;
				return (UInt32)value2;
			}
		}
		public UInt32 AddressSpaceBeingDeleted
		{
			get
			{
				// start: 5  end: 6  Mask: 0000000000100000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 32) >> 5;
				return (UInt32)value2;
			}
		}
		public UInt32 Available
		{
			get
			{
				// start: 6  end: 16  Mask: 1111111111000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 65472) >> 6;
				return (UInt32)value2;
			}
		}
		public UInt32 AllowWorkingSetAdjustment
		{
			get
			{
				// start: 16  end: 24  Mask: 111111110000000000000000
				var value = BitConverter.ToUInt32(_StructureData, _BufferOffset + 0);
				var value2 = (value & 16711680) >> 16;
				return (UInt32)value2;
			}
		}
		public UInt32 MemoryPriority
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
	#region _OWNER_ENTRY
 
	public class _OWNER_ENTRY
	{
		private Byte[] _StructureData;
		private int _BufferOffset;
		public _OWNER_ENTRY(Byte[] Buffer, int PartitionOffset)
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
				 ""_OWNER_ENTRY"": [ 8, {
				 ""OwnerThread"": [ 0, [ ""UInt32"", ""null"" ]],
				 ""OwnerCount"": [ 4, [ ""Int32"", ""null"" ]],
				 ""TableSize"": [ 4, [ ""UInt32"", ""null"" ]] }]
				 }
				)";
			}
		}
		public UInt32 OwnerThread { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 0); } }
		public Int32 OwnerCount { get { return BitConverter.ToInt32(_StructureData, _BufferOffset + 4); } }
		public UInt32 TableSize { get { return BitConverter.ToUInt32(_StructureData, _BufferOffset + 4); } }
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
}
