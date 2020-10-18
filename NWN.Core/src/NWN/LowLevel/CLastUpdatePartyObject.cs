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
    public unsafe partial class CLastUpdatePartyObject : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 132)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NWN.LowLevel.CResRef.__Internal m_cPortrait;

            [FieldOffset(32)]
            internal ushort m_nPortraitId;

            [FieldOffset(36)]
            internal int m_bActive;

            [FieldOffset(40)]
            internal uint m_nPlayerId;

            [FieldOffset(44)]
            internal ushort m_nAIState;

            [FieldOffset(46)]
            internal byte m_nAIStateAction;

            [FieldOffset(48)]
            internal ushort m_nAIStateActivities;

            [FieldOffset(52)]
            internal uint m_oidAIStateActee;

            [FieldOffset(56)]
            internal ushort m_nCurrentHitPoints;

            [FieldOffset(58)]
            internal ushort m_nBaseHitPoints;

            [FieldOffset(60)]
            internal ushort m_nTemporaryHitPoints;

            [FieldOffset(62)]
            internal ushort m_nMaxHitPoints;

            [FieldOffset(64)]
            internal byte m_nAIStateReaction;

            [FieldOffset(68)]
            internal int m_bCombatState;

            [FieldOffset(72)]
            internal uint m_oidArea;

            [FieldOffset(76)]
            internal global::NWN.LowLevel.Vector.__Internal m_vPosition;

            [FieldOffset(88)]
            internal int m_bPC;

            [FieldOffset(92)]
            internal int m_bFreeWill;

            [FieldOffset(96)]
            internal int m_bPartyLeader;

            [FieldOffset(100)]
            internal int m_bSingletonParty;

            [FieldOffset(104)]
            internal int m_bInvitedToParty;

            [FieldOffset(108)]
            internal int m_bSummonedFamiliar;

            [FieldOffset(112)]
            internal ushort m_nAssociateType;

            [FieldOffset(116)]
            internal uint m_oidMaster;

            [FieldOffset(120)]
            internal int m_bSummonedAnimalCompanion;

            [FieldOffset(124)]
            internal int m_bPoisoned;

            [FieldOffset(128)]
            internal int m_bDiseased;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CLastUpdatePartyObjectC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN22CLastUpdatePartyObjectC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CLastUpdatePartyObject> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CLastUpdatePartyObject>();

        protected bool __ownsNativeInstance;

        internal static CLastUpdatePartyObject __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CLastUpdatePartyObject(native.ToPointer(), skipVTables);
        }

        internal static CLastUpdatePartyObject __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CLastUpdatePartyObject)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CLastUpdatePartyObject __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CLastUpdatePartyObject(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CLastUpdatePartyObject(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CLastUpdatePartyObject(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CLastUpdatePartyObject()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CLastUpdatePartyObject.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CLastUpdatePartyObject(global::NWN.LowLevel.CLastUpdatePartyObject _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CLastUpdatePartyObject.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CLastUpdatePartyObject.__Internal*) __Instance) = *((global::NWN.LowLevel.CLastUpdatePartyObject.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CLastUpdatePartyObject __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NWN.LowLevel.CResRef MCPortrait
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_cPortrait));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_cPortrait = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public ushort MNPortraitId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPortraitId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPortraitId = value;
            }
        }

        public int MBActive
        {
            get
            {
                return ((__Internal*)__Instance)->m_bActive;
            }

            set
            {
                ((__Internal*)__Instance)->m_bActive = value;
            }
        }

        public uint MNPlayerId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPlayerId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPlayerId = value;
            }
        }

        public ushort MNAIState
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAIState;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAIState = value;
            }
        }

        public byte MNAIStateAction
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAIStateAction;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAIStateAction = value;
            }
        }

        public ushort MNAIStateActivities
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAIStateActivities;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAIStateActivities = value;
            }
        }

        public uint MOidAIStateActee
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidAIStateActee;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidAIStateActee = value;
            }
        }

        public ushort MNCurrentHitPoints
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCurrentHitPoints;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCurrentHitPoints = value;
            }
        }

        public ushort MNBaseHitPoints
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBaseHitPoints;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBaseHitPoints = value;
            }
        }

        public ushort MNTemporaryHitPoints
        {
            get
            {
                return ((__Internal*)__Instance)->m_nTemporaryHitPoints;
            }

            set
            {
                ((__Internal*)__Instance)->m_nTemporaryHitPoints = value;
            }
        }

        public ushort MNMaxHitPoints
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMaxHitPoints;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMaxHitPoints = value;
            }
        }

        public byte MNAIStateReaction
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAIStateReaction;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAIStateReaction = value;
            }
        }

        public int MBCombatState
        {
            get
            {
                return ((__Internal*)__Instance)->m_bCombatState;
            }

            set
            {
                ((__Internal*)__Instance)->m_bCombatState = value;
            }
        }

        public uint MOidArea
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidArea;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidArea = value;
            }
        }

        public global::NWN.LowLevel.Vector MVPosition
        {
            get
            {
                return global::NWN.LowLevel.Vector.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_vPosition));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_vPosition = *(global::NWN.LowLevel.Vector.__Internal*) value.__Instance;
            }
        }

        public int MBPC
        {
            get
            {
                return ((__Internal*)__Instance)->m_bPC;
            }

            set
            {
                ((__Internal*)__Instance)->m_bPC = value;
            }
        }

        public int MBFreeWill
        {
            get
            {
                return ((__Internal*)__Instance)->m_bFreeWill;
            }

            set
            {
                ((__Internal*)__Instance)->m_bFreeWill = value;
            }
        }

        public int MBPartyLeader
        {
            get
            {
                return ((__Internal*)__Instance)->m_bPartyLeader;
            }

            set
            {
                ((__Internal*)__Instance)->m_bPartyLeader = value;
            }
        }

        public int MBSingletonParty
        {
            get
            {
                return ((__Internal*)__Instance)->m_bSingletonParty;
            }

            set
            {
                ((__Internal*)__Instance)->m_bSingletonParty = value;
            }
        }

        public int MBInvitedToParty
        {
            get
            {
                return ((__Internal*)__Instance)->m_bInvitedToParty;
            }

            set
            {
                ((__Internal*)__Instance)->m_bInvitedToParty = value;
            }
        }

        public int MBSummonedFamiliar
        {
            get
            {
                return ((__Internal*)__Instance)->m_bSummonedFamiliar;
            }

            set
            {
                ((__Internal*)__Instance)->m_bSummonedFamiliar = value;
            }
        }

        public ushort MNAssociateType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAssociateType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAssociateType = value;
            }
        }

        public uint MOidMaster
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidMaster;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidMaster = value;
            }
        }

        public int MBSummonedAnimalCompanion
        {
            get
            {
                return ((__Internal*)__Instance)->m_bSummonedAnimalCompanion;
            }

            set
            {
                ((__Internal*)__Instance)->m_bSummonedAnimalCompanion = value;
            }
        }

        public int MBPoisoned
        {
            get
            {
                return ((__Internal*)__Instance)->m_bPoisoned;
            }

            set
            {
                ((__Internal*)__Instance)->m_bPoisoned = value;
            }
        }

        public int MBDiseased
        {
            get
            {
                return ((__Internal*)__Instance)->m_bDiseased;
            }

            set
            {
                ((__Internal*)__Instance)->m_bDiseased = value;
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
