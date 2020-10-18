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
    public unsafe partial class CExoConfig
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExoConfig> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExoConfig>();

        protected bool __ownsNativeInstance;

        internal static CExoConfig __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CExoConfig(native.ToPointer(), skipVTables);
        }

        internal static CExoConfig __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CExoConfig)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CExoConfig __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CExoConfig(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CExoConfig(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CExoConfig(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class CExoBase : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 88)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr m_pcExoConfig;

            [FieldOffset(8)]
            internal __IntPtr m_pcExoIni;

            [FieldOffset(16)]
            internal __IntPtr m_pcExoTimers;

            [FieldOffset(24)]
            internal __IntPtr m_pcExoDebug;

            [FieldOffset(32)]
            internal __IntPtr m_pcExoAliasList;

            [FieldOffset(40)]
            internal __IntPtr m_pcExoRand;

            [FieldOffset(48)]
            internal __IntPtr m_pcExoIdentity;

            [FieldOffset(56)]
            internal uint m_nExpansionPacks;

            [FieldOffset(64)]
            internal __IntPtr m_pcExoBaseInternal;

            [FieldOffset(72)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sUserDirectory;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBaseC2E10CExoString", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance, __IntPtr sUserDirectory);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBaseC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor_1(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBaseD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase16GetDirectoryListEP13CExoArrayListI10CExoStringES1_tii", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetDirectoryList(__IntPtr __instance, __IntPtr lstFilename, __IntPtr sAlias, ushort nResType, int bGetDirectories, int bSort);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase27GetDirectoryAndWorkshopListEP13CExoArrayListI10CExoStringES1_tii", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetDirectoryAndWorkshopList(__IntPtr __instance, __IntPtr lstFilename, __IntPtr sAlias, ushort nResType, int bGetDirectories, int bSort);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase25GetAugmentedDirectoryListEP13CExoArrayListI9CFileInfoE10CExoStringti", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetAugmentedDirectoryList(__IntPtr __instance, __IntPtr lstFileInfo, __IntPtr sAlias, ushort nResType, int bSort);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase20GetResourceExtensionEt", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetResourceExtension(__IntPtr __instance, ushort nType);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase23GetResTypeFromExtensionERK10CExoString", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ushort GetResTypeFromExtension(__IntPtr __instance, __IntPtr sExtension);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase11LoadAliasesEi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void LoadAliases(__IntPtr __instance, int idxIniFile);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase8ShutDownEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ShutDown(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase24SpawnExternalApplicationERK10CExoStringS2_i", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SpawnExternalApplication(__IntPtr __instance, __IntPtr sAppName, __IntPtr sParams, int bShutDownNWN);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoBase10CheckForCDEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int CheckForCD(__IntPtr __instance, uint nLanguage);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExoBase> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CExoBase>();

        protected bool __ownsNativeInstance;

        internal static CExoBase __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CExoBase(native.ToPointer(), skipVTables);
        }

        internal static CExoBase __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CExoBase)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CExoBase __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CExoBase(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CExoBase.__Internal.cctor_1(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CExoBase(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CExoBase(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CExoBase(global::NWN.LowLevel.CExoString sUserDirectory)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CExoBase.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(sUserDirectory, null))
                throw new global::System.ArgumentNullException("sUserDirectory", "Cannot be null because it is passed by value.");
            var __arg0 = sUserDirectory.__Instance;
            __Internal.ctor(__Instance, __arg0);
        }

        public CExoBase(global::NWN.LowLevel.CExoBase _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CExoBase.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor_1(__Instance, __arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CExoBase __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int GetDirectoryList(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CExoString> lstFilename, global::NWN.LowLevel.CExoString sAlias, ushort nResType, int bGetDirectories, int bSort)
        {
            var __arg0 = lstFilename is null ? __IntPtr.Zero : lstFilename.__Instance;
            if (ReferenceEquals(sAlias, null))
                throw new global::System.ArgumentNullException("sAlias", "Cannot be null because it is passed by value.");
            var __arg1 = sAlias.__Instance;
            var __ret = __Internal.GetDirectoryList(__Instance, __arg0, __arg1, nResType, bGetDirectories, bSort);
            return __ret;
        }

        public int GetDirectoryAndWorkshopList(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CExoString> lstFilename, global::NWN.LowLevel.CExoString sAlias, ushort nResType, int bGetDirectories, int bSort)
        {
            var __arg0 = lstFilename is null ? __IntPtr.Zero : lstFilename.__Instance;
            if (ReferenceEquals(sAlias, null))
                throw new global::System.ArgumentNullException("sAlias", "Cannot be null because it is passed by value.");
            var __arg1 = sAlias.__Instance;
            var __ret = __Internal.GetDirectoryAndWorkshopList(__Instance, __arg0, __arg1, nResType, bGetDirectories, bSort);
            return __ret;
        }

        public int GetAugmentedDirectoryList(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CFileInfo> lstFileInfo, global::NWN.LowLevel.CExoString sAlias, ushort nResType, int bSort)
        {
            var __arg0 = lstFileInfo is null ? __IntPtr.Zero : lstFileInfo.__Instance;
            if (ReferenceEquals(sAlias, null))
                throw new global::System.ArgumentNullException("sAlias", "Cannot be null because it is passed by value.");
            var __arg1 = sAlias.__Instance;
            var __ret = __Internal.GetAugmentedDirectoryList(__Instance, __arg0, __arg1, nResType, bSort);
            return __ret;
        }

        public global::NWN.LowLevel.CExoString GetResourceExtension(ushort nType)
        {
            var __ret = __Internal.GetResourceExtension(__Instance, nType);
            var __result0 = global::NWN.LowLevel.CExoString.__GetOrCreateInstance(__ret, false);
            return __result0;
        }

        public ushort GetResTypeFromExtension(global::NWN.LowLevel.CExoString sExtension)
        {
            if (ReferenceEquals(sExtension, null))
                throw new global::System.ArgumentNullException("sExtension", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = sExtension.__Instance;
            var __ret = __Internal.GetResTypeFromExtension(__Instance, __arg0);
            return __ret;
        }

        public void LoadAliases(int idxIniFile)
        {
            __Internal.LoadAliases(__Instance, idxIniFile);
        }

        public void ShutDown()
        {
            __Internal.ShutDown(__Instance);
        }

        public void SpawnExternalApplication(global::NWN.LowLevel.CExoString sAppName, global::NWN.LowLevel.CExoString sParams, int bShutDownNWN)
        {
            if (ReferenceEquals(sAppName, null))
                throw new global::System.ArgumentNullException("sAppName", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = sAppName.__Instance;
            if (ReferenceEquals(sParams, null))
                throw new global::System.ArgumentNullException("sParams", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = sParams.__Instance;
            __Internal.SpawnExternalApplication(__Instance, __arg0, __arg1, bShutDownNWN);
        }

        public int CheckForCD(uint nLanguage)
        {
            var __ret = __Internal.CheckForCD(__Instance, nLanguage);
            return __ret;
        }

        public static implicit operator global::NWN.LowLevel.CExoBase(global::NWN.LowLevel.CExoString sUserDirectory)
        {
            return new global::NWN.LowLevel.CExoBase(sUserDirectory);
        }

        public global::NWN.LowLevel.CExoConfig MPcExoConfig
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoConfig.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoConfig, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoConfig = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoIni MPcExoIni
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoIni.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoIni, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoIni = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoTimers MPcExoTimers
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoTimers.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoTimers, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoTimers = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoDebug MPcExoDebug
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoDebug.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoDebug, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoDebug = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoAliasList MPcExoAliasList
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoAliasList.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoAliasList, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoAliasList = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoRand MPcExoRand
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoRand.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoRand, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoRand = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoIdentity MPcExoIdentity
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoIdentity.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoIdentity, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoIdentity = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public uint MNExpansionPacks
        {
            get
            {
                return ((__Internal*)__Instance)->m_nExpansionPacks;
            }

            set
            {
                ((__Internal*)__Instance)->m_nExpansionPacks = value;
            }
        }

        public global::NWN.LowLevel.CExoBaseInternal MPcExoBaseInternal
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoBaseInternal.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoBaseInternal, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoBaseInternal = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSUserDirectory
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sUserDirectory));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sUserDirectory = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
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
