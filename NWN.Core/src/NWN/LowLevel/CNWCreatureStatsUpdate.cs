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
    public unsafe partial class CNWCreatureStatsUpdate : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 120)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstFeats;

            [FieldOffset(16)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstBonusFeats;

            [FieldOffset(32)]
            internal uint m_oidFeatUpdated;

            [FieldOffset(36)]
            internal uint m_nSkillUpdateFlag;

            [FieldOffset(40)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_aLastUpdateEffectArray;

            [FieldOffset(56)]
            internal byte m_nSTRStat;

            [FieldOffset(57)]
            internal byte m_nDEXStat;

            [FieldOffset(58)]
            internal byte m_nCONStat;

            [FieldOffset(59)]
            internal byte m_nINTStat;

            [FieldOffset(60)]
            internal byte m_nWISStat;

            [FieldOffset(61)]
            internal byte m_nCHAStat;

            [FieldOffset(62)]
            internal byte m_nSTRBase;

            [FieldOffset(63)]
            internal byte m_nDEXBase;

            [FieldOffset(64)]
            internal byte m_nCONBase;

            [FieldOffset(65)]
            internal byte m_nINTBase;

            [FieldOffset(66)]
            internal byte m_nWISBase;

            [FieldOffset(67)]
            internal byte m_nCHABase;

            [FieldOffset(68)]
            internal sbyte m_nSTRBonus;

            [FieldOffset(69)]
            internal sbyte m_nDEXBonus;

            [FieldOffset(70)]
            internal sbyte m_nCONBonus;

            [FieldOffset(71)]
            internal sbyte m_nINTBonus;

            [FieldOffset(72)]
            internal sbyte m_nWISBonus;

            [FieldOffset(73)]
            internal sbyte m_nCHABonus;

            [FieldOffset(74)]
            internal sbyte m_nDEXACModifier;

            [FieldOffset(75)]
            internal sbyte m_nFortSave;

            [FieldOffset(76)]
            internal sbyte m_nWillSave;

            [FieldOffset(77)]
            internal sbyte m_nReflexSave;

            [FieldOffset(78)]
            internal fixed sbyte m_nNegativeLevels[3];

            [FieldOffset(82)]
            internal short m_nCurrentHP;

            [FieldOffset(84)]
            internal short m_nMaxHP;

            [FieldOffset(88)]
            internal uint m_nCurrentXP;

            [FieldOffset(92)]
            internal int m_bUseMonkAttackTable;

            [FieldOffset(96)]
            internal byte m_nBaseAttackBonus;

            [FieldOffset(97)]
            internal sbyte m_nBaseFortSavingThrow;

            [FieldOffset(98)]
            internal sbyte m_nBaseWillSavingThrow;

            [FieldOffset(99)]
            internal sbyte m_nBaseReflexSavingThrow;

            [FieldOffset(100)]
            internal short m_nArmorClass;

            [FieldOffset(104)]
            internal __IntPtr m_pCombatInformation;

            [FieldOffset(112)]
            internal __IntPtr m_lstSkillRanks;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CNWCreatureStatsUpdateC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CNWCreatureStatsUpdateC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CNWCreatureStatsUpdateD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CNWCreatureStatsUpdate20SetCombatInformationEP18CCombatInformation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetCombatInformation(__IntPtr __instance, __IntPtr pData);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CNWCreatureStatsUpdate16ClearEffectIconsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearEffectIcons(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWCreatureStatsUpdate> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWCreatureStatsUpdate>();

        protected bool __ownsNativeInstance;

        internal static CNWCreatureStatsUpdate __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWCreatureStatsUpdate(native.ToPointer(), skipVTables);
        }

        internal static CNWCreatureStatsUpdate __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWCreatureStatsUpdate)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWCreatureStatsUpdate __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWCreatureStatsUpdate(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWCreatureStatsUpdate.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWCreatureStatsUpdate(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWCreatureStatsUpdate(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWCreatureStatsUpdate()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWCreatureStatsUpdate.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWCreatureStatsUpdate(global::NWN.LowLevel.CNWCreatureStatsUpdate _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWCreatureStatsUpdate.__Internal));
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
            global::NWN.LowLevel.CNWCreatureStatsUpdate __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void SetCombatInformation(global::NWN.LowLevel.CCombatInformation pData)
        {
            var __arg0 = pData is null ? __IntPtr.Zero : pData.__Instance;
            __Internal.SetCombatInformation(__Instance, __arg0);
        }

        public void ClearEffectIcons()
        {
            __Internal.ClearEffectIcons(__Instance);
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

        public global::NWN.LowLevel.CExoArrayList<ushort> MLstBonusFeats
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<ushort>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_lstBonusFeats));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_lstBonusFeats = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
            }
        }

        public uint MOidFeatUpdated
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidFeatUpdated;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidFeatUpdated = value;
            }
        }

        public uint MNSkillUpdateFlag
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSkillUpdateFlag;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSkillUpdateFlag = value;
            }
        }

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CEffectIconObject> MALastUpdateEffectArray
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CEffectIconObject>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_aLastUpdateEffectArray));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_aLastUpdateEffectArray = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
            }
        }

        public byte MNSTRStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSTRStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSTRStat = value;
            }
        }

        public byte MNDEXStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nDEXStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nDEXStat = value;
            }
        }

        public byte MNCONStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCONStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCONStat = value;
            }
        }

        public byte MNINTStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nINTStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nINTStat = value;
            }
        }

        public byte MNWISStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nWISStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nWISStat = value;
            }
        }

        public byte MNCHAStat
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCHAStat;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCHAStat = value;
            }
        }

        public byte MNSTRBase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSTRBase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSTRBase = value;
            }
        }

        public byte MNDEXBase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nDEXBase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nDEXBase = value;
            }
        }

        public byte MNCONBase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCONBase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCONBase = value;
            }
        }

        public byte MNINTBase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nINTBase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nINTBase = value;
            }
        }

        public byte MNWISBase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nWISBase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nWISBase = value;
            }
        }

        public byte MNCHABase
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCHABase;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCHABase = value;
            }
        }

        public sbyte MNSTRBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSTRBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSTRBonus = value;
            }
        }

        public sbyte MNDEXBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nDEXBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nDEXBonus = value;
            }
        }

        public sbyte MNCONBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCONBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCONBonus = value;
            }
        }

        public sbyte MNINTBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nINTBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nINTBonus = value;
            }
        }

        public sbyte MNWISBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nWISBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nWISBonus = value;
            }
        }

        public sbyte MNCHABonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCHABonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCHABonus = value;
            }
        }

        public sbyte MNDEXACModifier
        {
            get
            {
                return ((__Internal*)__Instance)->m_nDEXACModifier;
            }

            set
            {
                ((__Internal*)__Instance)->m_nDEXACModifier = value;
            }
        }

        public sbyte MNFortSave
        {
            get
            {
                return ((__Internal*)__Instance)->m_nFortSave;
            }

            set
            {
                ((__Internal*)__Instance)->m_nFortSave = value;
            }
        }

        public sbyte MNWillSave
        {
            get
            {
                return ((__Internal*)__Instance)->m_nWillSave;
            }

            set
            {
                ((__Internal*)__Instance)->m_nWillSave = value;
            }
        }

        public sbyte MNReflexSave
        {
            get
            {
                return ((__Internal*)__Instance)->m_nReflexSave;
            }

            set
            {
                ((__Internal*)__Instance)->m_nReflexSave = value;
            }
        }

        public sbyte[] MNNegativeLevels
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->m_nNegativeLevels, 3);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((__Internal*)__Instance)->m_nNegativeLevels[i] = value[i];
                }
            }
        }

        public short MNCurrentHP
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCurrentHP;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCurrentHP = value;
            }
        }

        public short MNMaxHP
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMaxHP;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMaxHP = value;
            }
        }

        public uint MNCurrentXP
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCurrentXP;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCurrentXP = value;
            }
        }

        public int MBUseMonkAttackTable
        {
            get
            {
                return ((__Internal*)__Instance)->m_bUseMonkAttackTable;
            }

            set
            {
                ((__Internal*)__Instance)->m_bUseMonkAttackTable = value;
            }
        }

        public byte MNBaseAttackBonus
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBaseAttackBonus;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBaseAttackBonus = value;
            }
        }

        public sbyte MNBaseFortSavingThrow
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBaseFortSavingThrow;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBaseFortSavingThrow = value;
            }
        }

        public sbyte MNBaseWillSavingThrow
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBaseWillSavingThrow;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBaseWillSavingThrow = value;
            }
        }

        public sbyte MNBaseReflexSavingThrow
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBaseReflexSavingThrow;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBaseReflexSavingThrow = value;
            }
        }

        public short MNArmorClass
        {
            get
            {
                return ((__Internal*)__Instance)->m_nArmorClass;
            }

            set
            {
                ((__Internal*)__Instance)->m_nArmorClass = value;
            }
        }

        public global::NWN.LowLevel.CCombatInformation MPCombatInformation
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CCombatInformation.__GetOrCreateInstance(((__Internal*)__Instance)->m_pCombatInformation, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pCombatInformation = value is null ? __IntPtr.Zero : value.__Instance;
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
