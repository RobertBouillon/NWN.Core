// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace NWN.LowLevel
{
    public unsafe partial class CExtendedServerInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 120)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int m_bPasswordRequired;

            [FieldOffset(4)]
            internal byte m_nMinLevel;

            [FieldOffset(5)]
            internal byte m_nMaxLevel;

            [FieldOffset(6)]
            internal byte m_nPlayerCount;

            [FieldOffset(7)]
            internal byte m_nMaxPlayers;

            [FieldOffset(8)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sModuleName;

            [FieldOffset(24)]
            internal int m_bAllowLocalVaultChars;

            [FieldOffset(28)]
            internal int m_bPauseAndPlay;

            [FieldOffset(32)]
            internal int m_bMultiplayerEnabled;

            [FieldOffset(36)]
            internal byte m_nPVPSetting;

            [FieldOffset(37)]
            internal byte m_nExpansionPacksRequired;

            [FieldOffset(40)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sServerName;

            [FieldOffset(56)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sModuleDescription;

            [FieldOffset(72)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sGameDetails;

            [FieldOffset(88)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sBuild;

            [FieldOffset(104)]
            internal short m_nGameType;

            [FieldOffset(108)]
            internal int m_bOnePartyOnly;

            [FieldOffset(112)]
            internal int m_bLegalChars;

            [FieldOffset(116)]
            internal int m_bItemRestrict;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CExtendedServerInfoC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CExtendedServerInfoC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CExtendedServerInfoD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExtendedServerInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExtendedServerInfo>();

        protected bool __ownsNativeInstance;

        internal static CExtendedServerInfo __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CExtendedServerInfo(native.ToPointer(), skipVTables);
        }

        internal static CExtendedServerInfo __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CExtendedServerInfo)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CExtendedServerInfo __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CExtendedServerInfo(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CExtendedServerInfo.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CExtendedServerInfo(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CExtendedServerInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CExtendedServerInfo(global::NWN.LowLevel.CExtendedServerInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CExtendedServerInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
        }

        public CExtendedServerInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CExtendedServerInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CExtendedServerInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int MBPasswordRequired
        {
            get
            {
                return ((__Internal*)__Instance)->m_bPasswordRequired;
            }

            set
            {
                ((__Internal*)__Instance)->m_bPasswordRequired = value;
            }
        }

        public byte MNMinLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMinLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMinLevel = value;
            }
        }

        public byte MNMaxLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMaxLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMaxLevel = value;
            }
        }

        public byte MNPlayerCount
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPlayerCount;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPlayerCount = value;
            }
        }

        public byte MNMaxPlayers
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMaxPlayers;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMaxPlayers = value;
            }
        }

        public global::NWN.LowLevel.CExoString MSModuleName
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sModuleName));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sModuleName = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public int MBAllowLocalVaultChars
        {
            get
            {
                return ((__Internal*)__Instance)->m_bAllowLocalVaultChars;
            }

            set
            {
                ((__Internal*)__Instance)->m_bAllowLocalVaultChars = value;
            }
        }

        public int MBPauseAndPlay
        {
            get
            {
                return ((__Internal*)__Instance)->m_bPauseAndPlay;
            }

            set
            {
                ((__Internal*)__Instance)->m_bPauseAndPlay = value;
            }
        }

        public int MBMultiplayerEnabled
        {
            get
            {
                return ((__Internal*)__Instance)->m_bMultiplayerEnabled;
            }

            set
            {
                ((__Internal*)__Instance)->m_bMultiplayerEnabled = value;
            }
        }

        public byte MNPVPSetting
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPVPSetting;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPVPSetting = value;
            }
        }

        public byte MNExpansionPacksRequired
        {
            get
            {
                return ((__Internal*)__Instance)->m_nExpansionPacksRequired;
            }

            set
            {
                ((__Internal*)__Instance)->m_nExpansionPacksRequired = value;
            }
        }

        public global::NWN.LowLevel.CExoString MSServerName
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sServerName));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sServerName = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSModuleDescription
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sModuleDescription));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sModuleDescription = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSGameDetails
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sGameDetails));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sGameDetails = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSBuild
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sBuild));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sBuild = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public short MNGameType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nGameType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nGameType = value;
            }
        }

        public int MBOnePartyOnly
        {
            get
            {
                return ((__Internal*)__Instance)->m_bOnePartyOnly;
            }

            set
            {
                ((__Internal*)__Instance)->m_bOnePartyOnly = value;
            }
        }

        public int MBLegalChars
        {
            get
            {
                return ((__Internal*)__Instance)->m_bLegalChars;
            }

            set
            {
                ((__Internal*)__Instance)->m_bLegalChars = value;
            }
        }

        public int MBItemRestrict
        {
            get
            {
                return ((__Internal*)__Instance)->m_bItemRestrict;
            }

            set
            {
                ((__Internal*)__Instance)->m_bItemRestrict = value;
            }
        }
    }
}

namespace Std
{
    namespace Pair
    {
        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__S_CExoString___S_CNWSScriptVar
        {
            [FieldOffset(0)]
            internal global::NWN.LowLevel.CExoString.__Internal first;

            [FieldOffset(16)]
            internal global::NWN.LowLevel.CNWSScriptVar.__Internal second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___S_CachedRulesetEntry
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_N___cxx11_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::NWN.LowLevel.CachedRulesetEntry.__Internal second;
        }
    }

}
namespace Std
{
    namespace Hashtable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public unsafe partial struct __Internalc__N_std_S__Hashtable____S_CExoString___N_std_S_pair__1S0____S_CNWSScriptVar___N_std_S_allocator__S1____N_std_N___detail_S__Select1st___N_std_S_equal_to__S0____N_std_S_hash__S0____N_std_N___detail_S__Mod_range_hashing___N_std_N___detail_S__Default_ranged_hash___N_std_N___detail_S__Prime_rehash_policy___N_std_N___detail_S__Hashtable_traits__Vb1_Vb0_Vb1
        {
            [FieldOffset(0)]
            internal __IntPtr _M_buckets;

            [FieldOffset(8)]
            internal ulong _M_bucket_count;

            [FieldOffset(16)]
            internal global::Std.Detail.HashNodeBase.__Internal _M_before_begin;

            [FieldOffset(24)]
            internal ulong _M_element_count;

            [FieldOffset(32)]
            internal global::Std.Detail.PrimeRehashPolicy.__Internal _M_rehash_policy;

            [FieldOffset(48)]
            internal __IntPtr _M_single_bucket;
        }
    }
}
