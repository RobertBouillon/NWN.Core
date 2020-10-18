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
    public unsafe partial class CNWLevelStats : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 360)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed byte m_pAddedKnownSpellList[160];

            [FieldOffset(160)]
            internal fixed byte m_pRemovedKnownSpellList[160];

            [FieldOffset(320)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstFeats;

            [FieldOffset(336)]
            internal __IntPtr m_lstSkillRanks;

            [FieldOffset(344)]
            internal ushort m_nSkillPointsRemaining;

            [FieldOffset(346)]
            internal byte m_nAbilityGain;

            [FieldOffset(347)]
            internal byte m_nHitDie;

            [FieldOffset(348)]
            internal byte m_nClass;

            [FieldOffset(352)]
            internal int m_bEpic;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStatsC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStatsC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStatsD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStats10ClearFeatsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearFeats(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStats7AddFeatEt", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void AddFeat(__IntPtr __instance, ushort nFeat);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStats18GetSkillRankChangeEt", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern sbyte GetSkillRankChange(__IntPtr __instance, ushort nSkill);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWLevelStats18SetSkillRankChangeEtc", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetSkillRankChange(__IntPtr __instance, ushort nSkill, sbyte nRank);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWLevelStats> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWLevelStats>();

        protected bool __ownsNativeInstance;

        internal static CNWLevelStats __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWLevelStats(native.ToPointer(), skipVTables);
        }

        internal static CNWLevelStats __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWLevelStats)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWLevelStats __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWLevelStats(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWLevelStats.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWLevelStats(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWLevelStats(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWLevelStats()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWLevelStats.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWLevelStats(global::NWN.LowLevel.CNWLevelStats _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWLevelStats.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWLevelStats __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void ClearFeats()
        {
            __Internal.ClearFeats(__Instance);
        }

        public void AddFeat(ushort nFeat)
        {
            __Internal.AddFeat(__Instance, nFeat);
        }

        public sbyte GetSkillRankChange(ushort nSkill)
        {
            var __ret = __Internal.GetSkillRankChange(__Instance, nSkill);
            return __ret;
        }

        public void SetSkillRankChange(ushort nSkill, sbyte nRank)
        {
            __Internal.SetSkillRankChange(__Instance, nSkill, nRank);
        }

        public global::NWN.LowLevel.CExoArrayList<uint>[] MPAddedKnownSpellList
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<uint>[] __value = null;
                if (((__Internal*)__Instance)->m_pAddedKnownSpellList != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<uint>[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<uint>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)&(((__Internal*)__Instance)->m_pAddedKnownSpellList[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 10)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 10; i++)
                        *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*) &((__Internal*)__Instance)->m_pAddedKnownSpellList[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<uint>[] MPRemovedKnownSpellList
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<uint>[] __value = null;
                if (((__Internal*)__Instance)->m_pRemovedKnownSpellList != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<uint>[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<uint>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)&(((__Internal*)__Instance)->m_pRemovedKnownSpellList[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 10)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 10; i++)
                        *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*) &((__Internal*)__Instance)->m_pRemovedKnownSpellList[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<ushort> MLstFeats
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<ushort>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_lstFeats));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_lstFeats = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
            }
        }

        public sbyte* MLstSkillRanks
        {
            get
            {
                return (sbyte*) ((__Internal*)__Instance)->m_lstSkillRanks;
            }

            set
            {
                ((__Internal*)__Instance)->m_lstSkillRanks = (__IntPtr) value;
            }
        }

        public ushort MNSkillPointsRemaining
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSkillPointsRemaining;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSkillPointsRemaining = value;
            }
        }

        public byte MNAbilityGain
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAbilityGain;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAbilityGain = value;
            }
        }

        public byte MNHitDie
        {
            get
            {
                return ((__Internal*)__Instance)->m_nHitDie;
            }

            set
            {
                ((__Internal*)__Instance)->m_nHitDie = value;
            }
        }

        public byte MNClass
        {
            get
            {
                return ((__Internal*)__Instance)->m_nClass;
            }

            set
            {
                ((__Internal*)__Instance)->m_nClass = value;
            }
        }

        public int MBEpic
        {
            get
            {
                return ((__Internal*)__Instance)->m_bEpic;
            }

            set
            {
                ((__Internal*)__Instance)->m_bEpic = value;
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
