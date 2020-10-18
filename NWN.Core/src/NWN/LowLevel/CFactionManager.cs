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
    public unsafe partial class CFactionManager : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr m_pDefaultFactionDefender;

            [FieldOffset(8)]
            internal __IntPtr m_pDefaultFactionCommoner;

            [FieldOffset(16)]
            internal __IntPtr m_pDefaultFactionMerchant;

            [FieldOffset(24)]
            internal __IntPtr m_pDefaultFactionHostile;

            [FieldOffset(32)]
            internal __IntPtr m_pDefaultFactionPC;

            [FieldOffset(40)]
            internal int m_nNPCFactionCount;

            [FieldOffset(48)]
            internal __IntPtr m_pNPCReputations;

            [FieldOffset(56)]
            internal __IntPtr m_pFactionList;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManagerC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManagerC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManagerD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager10GetFactionEi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetFaction(__IntPtr __instance, int nFactionId);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager15GetIsNPCFactionEi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetIsNPCFaction(__IntPtr __instance, int nFactionId);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager23GetNPCFactionReputationEii", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetNPCFactionReputation(__IntPtr __instance, int nFactionId, int nSubjectFactionId);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager23SetNPCFactionReputationEiii", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetNPCFactionReputation(__IntPtr __instance, int nFactionId, int nSubjectFactionId, int nReputation);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager13DeleteFactionEi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void DeleteFaction(__IntPtr __instance, int nFactionId);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager18GetFactionIdByNameERK10CExoString", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetFactionIdByName(__IntPtr __instance, __IntPtr name);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager12LoadFactionsEP7CResGFFP8CResList", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadFactions(__IntPtr __instance, __IntPtr pRes, __IntPtr cFactionList);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager15LoadReputationsEP7CResGFFP8CResList", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadReputations(__IntPtr __instance, __IntPtr pRes, __IntPtr cReputationList);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager21CreateDefaultFactionsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void CreateDefaultFactions(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager12SaveFactionsEP7CResGFFP8CResList", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SaveFactions(__IntPtr __instance, __IntPtr pRes, __IntPtr pList);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager15SaveReputationsEP7CResGFFP8CResList", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SaveReputations(__IntPtr __instance, __IntPtr pRes, __IntPtr pList);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN15CFactionManager22GetDefaultPCReputationEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetDefaultPCReputation(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CFactionManager> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CFactionManager>();

        protected bool __ownsNativeInstance;

        internal static CFactionManager __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CFactionManager(native.ToPointer(), skipVTables);
        }

        internal static CFactionManager __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CFactionManager)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CFactionManager __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CFactionManager(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CFactionManager(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CFactionManager(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CFactionManager()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CFactionManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CFactionManager(global::NWN.LowLevel.CFactionManager _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CFactionManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CFactionManager.__Internal*) __Instance) = *((global::NWN.LowLevel.CFactionManager.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CFactionManager __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NWN.LowLevel.CNWSFaction GetFaction(int nFactionId)
        {
            var __ret = __Internal.GetFaction(__Instance, nFactionId);
            var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(__ret, false);
            return __result0;
        }

        public int GetIsNPCFaction(int nFactionId)
        {
            var __ret = __Internal.GetIsNPCFaction(__Instance, nFactionId);
            return __ret;
        }

        public int GetNPCFactionReputation(int nFactionId, int nSubjectFactionId)
        {
            var __ret = __Internal.GetNPCFactionReputation(__Instance, nFactionId, nSubjectFactionId);
            return __ret;
        }

        public void SetNPCFactionReputation(int nFactionId, int nSubjectFactionId, int nReputation)
        {
            __Internal.SetNPCFactionReputation(__Instance, nFactionId, nSubjectFactionId, nReputation);
        }

        public void DeleteFaction(int nFactionId)
        {
            __Internal.DeleteFaction(__Instance, nFactionId);
        }

        public int GetFactionIdByName(global::NWN.LowLevel.CExoString name)
        {
            if (ReferenceEquals(name, null))
                throw new global::System.ArgumentNullException("name", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = name.__Instance;
            var __ret = __Internal.GetFactionIdByName(__Instance, __arg0);
            return __ret;
        }

        public int LoadFactions(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResList cFactionList)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = cFactionList is null ? __IntPtr.Zero : cFactionList.__Instance;
            var __ret = __Internal.LoadFactions(__Instance, __arg0, __arg1);
            return __ret;
        }

        public int LoadReputations(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResList cReputationList)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = cReputationList is null ? __IntPtr.Zero : cReputationList.__Instance;
            var __ret = __Internal.LoadReputations(__Instance, __arg0, __arg1);
            return __ret;
        }

        public void CreateDefaultFactions()
        {
            __Internal.CreateDefaultFactions(__Instance);
        }

        public int SaveFactions(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResList pList)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = pList is null ? __IntPtr.Zero : pList.__Instance;
            var __ret = __Internal.SaveFactions(__Instance, __arg0, __arg1);
            return __ret;
        }

        public int SaveReputations(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResList pList)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = pList is null ? __IntPtr.Zero : pList.__Instance;
            var __ret = __Internal.SaveReputations(__Instance, __arg0, __arg1);
            return __ret;
        }

        public global::NWN.LowLevel.CNWSFaction MPDefaultFactionDefender
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(((__Internal*)__Instance)->m_pDefaultFactionDefender, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pDefaultFactionDefender = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CNWSFaction MPDefaultFactionCommoner
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(((__Internal*)__Instance)->m_pDefaultFactionCommoner, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pDefaultFactionCommoner = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CNWSFaction MPDefaultFactionMerchant
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(((__Internal*)__Instance)->m_pDefaultFactionMerchant, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pDefaultFactionMerchant = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CNWSFaction MPDefaultFactionHostile
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(((__Internal*)__Instance)->m_pDefaultFactionHostile, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pDefaultFactionHostile = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CNWSFaction MPDefaultFactionPC
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWSFaction.__GetOrCreateInstance(((__Internal*)__Instance)->m_pDefaultFactionPC, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pDefaultFactionPC = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public int MNNPCFactionCount
        {
            get
            {
                return ((__Internal*)__Instance)->m_nNPCFactionCount;
            }

            set
            {
                ((__Internal*)__Instance)->m_nNPCFactionCount = value;
            }
        }

        public global::NWN.LowLevel.CExoArrayList<int> MPNPCReputations
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoArrayList<int>.__GetOrCreateInstance(((__Internal*)__Instance)->m_pNPCReputations, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pNPCReputations = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoArrayList<int> DefaultPCReputation
        {
            get
            {
                var __ret = __Internal.GetDefaultPCReputation(__Instance);
                var __result0 = global::NWN.LowLevel.CExoArrayList<int>.__GetOrCreateInstance(__ret, false);
                return __result0;
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
