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
    public unsafe partial class CNWSpell : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 616)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sLabel;

            [FieldOffset(16)]
            internal int m_strrefName;

            [FieldOffset(20)]
            internal uint m_strrefDesc;

            [FieldOffset(24)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefIcon;

            [FieldOffset(56)]
            internal byte m_nSchool;

            [FieldOffset(64)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sRange;

            [FieldOffset(80)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sComponent;

            [FieldOffset(96)]
            internal ushort m_nTargetType;

            [FieldOffset(104)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sImpactScript;

            [FieldOffset(120)]
            internal byte m_nBardLevel;

            [FieldOffset(121)]
            internal byte m_nClericLevel;

            [FieldOffset(122)]
            internal byte m_nDruidLevel;

            [FieldOffset(123)]
            internal byte m_nPaladinLevel;

            [FieldOffset(124)]
            internal byte m_nRangerLevel;

            [FieldOffset(125)]
            internal byte m_nSorcererLevel;

            [FieldOffset(126)]
            internal byte m_nWizardLevel;

            [FieldOffset(127)]
            internal byte m_nInnateLevel;

            [FieldOffset(128)]
            internal uint m_nConjureTime;

            [FieldOffset(132)]
            internal ushort m_nConjureAnimation;

            [FieldOffset(134)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureHeadVisual;

            [FieldOffset(166)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureHandVisual;

            [FieldOffset(198)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureGroundVisual;

            [FieldOffset(230)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureSoundMale;

            [FieldOffset(262)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureSoundFemale;

            [FieldOffset(294)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefConjureSoundVFX;

            [FieldOffset(326)]
            internal ushort m_nCastAnimation;

            [FieldOffset(328)]
            internal uint m_nCastTime;

            [FieldOffset(332)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefCastHeadVisual;

            [FieldOffset(364)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefCastHandVisual;

            [FieldOffset(396)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefCastGroundVisual;

            [FieldOffset(428)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefCastSound;

            [FieldOffset(460)]
            internal int m_bProjectileSpawn;

            [FieldOffset(464)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefProjectile;

            [FieldOffset(496)]
            internal uint m_nProjectileType;

            [FieldOffset(500)]
            internal byte m_nProjectileSpawnPoint;

            [FieldOffset(501)]
            internal global::NWN.LowLevel.CResRef.__Internal m_resrefProjectileSound;

            [FieldOffset(533)]
            internal byte m_nProjectileOrientationType;

            [FieldOffset(534)]
            internal byte m_nImmunityType;

            [FieldOffset(536)]
            internal int m_bImmunityItem;

            [FieldOffset(540)]
            internal int m_nTalentCategory;

            [FieldOffset(544)]
            internal int m_nTalentMaxCR;

            [FieldOffset(552)]
            internal __IntPtr m_pSubRadialSpell;

            [FieldOffset(560)]
            internal byte m_nSubRadialSpellCount;

            [FieldOffset(564)]
            internal int m_bUseConcentration;

            [FieldOffset(568)]
            internal uint m_nMasterSpell;

            [FieldOffset(572)]
            internal uint m_nCounterSpell1;

            [FieldOffset(576)]
            internal uint m_nCounterSpell2;

            [FieldOffset(580)]
            internal byte m_nUserType;

            [FieldOffset(584)]
            internal int m_bSpontaneouslyCast;

            [FieldOffset(588)]
            internal byte m_nAllowedMetamagic;

            [FieldOffset(592)]
            internal uint m_nAltMessage;

            [FieldOffset(596)]
            internal int m_bHostile;

            [FieldOffset(600)]
            internal int m_nFeatId;

            [FieldOffset(604)]
            internal int m_bHasProjectile;

            [FieldOffset(608)]
            internal uint m_nSpellId;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpellC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpellC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpellD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell13GetSpellLevelEh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern byte GetSpellLevel(__IntPtr __instance, byte nClass);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell17GetSubRadialSpellEh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetSubRadialSpell(__IntPtr __instance, byte nIndex);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell17SetSubRadialSpellEhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetSubRadialSpell(__IntPtr __instance, byte nIndex, uint nSpellID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell22SetSubRadialSpellCountEh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetSubRadialSpellCount(__IntPtr __instance, byte nCount);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell16GetSpellNameTextEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void GetSpellNameText(__IntPtr @return, __IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell26GetSpellHasVerbalComponentEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSpellHasVerbalComponent(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CNWSpell27GetSpellHasSomaticComponentEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSpellHasSomaticComponent(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSpell> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSpell>();

        protected bool __ownsNativeInstance;

        internal static CNWSpell __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSpell(native.ToPointer(), skipVTables);
        }

        internal static CNWSpell __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSpell)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSpell __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSpell(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWSpell.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWSpell(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSpell(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSpell()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSpell.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWSpell(global::NWN.LowLevel.CNWSpell _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSpell.__Internal));
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
            global::NWN.LowLevel.CNWSpell __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte GetSpellLevel(byte nClass)
        {
            var __ret = __Internal.GetSpellLevel(__Instance, nClass);
            return __ret;
        }

        public uint GetSubRadialSpell(byte nIndex)
        {
            var __ret = __Internal.GetSubRadialSpell(__Instance, nIndex);
            return __ret;
        }

        public void SetSubRadialSpell(byte nIndex, uint nSpellID)
        {
            __Internal.SetSubRadialSpell(__Instance, nIndex, nSpellID);
        }

        public void SetSubRadialSpellCount(byte nCount)
        {
            __Internal.SetSubRadialSpellCount(__Instance, nCount);
        }

        public global::NWN.LowLevel.CExoString MSLabel
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sLabel));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sLabel = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public int MStrrefName
        {
            get
            {
                return ((__Internal*)__Instance)->m_strrefName;
            }

            set
            {
                ((__Internal*)__Instance)->m_strrefName = value;
            }
        }

        public uint MStrrefDesc
        {
            get
            {
                return ((__Internal*)__Instance)->m_strrefDesc;
            }

            set
            {
                ((__Internal*)__Instance)->m_strrefDesc = value;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefIcon
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefIcon));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefIcon = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public byte MNSchool
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSchool;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSchool = value;
            }
        }

        public global::NWN.LowLevel.CExoString MSRange
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sRange));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sRange = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSComponent
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sComponent));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sComponent = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public ushort MNTargetType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nTargetType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nTargetType = value;
            }
        }

        public global::NWN.LowLevel.CExoString MSImpactScript
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sImpactScript));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sImpactScript = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public byte MNBardLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nBardLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nBardLevel = value;
            }
        }

        public byte MNClericLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nClericLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nClericLevel = value;
            }
        }

        public byte MNDruidLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nDruidLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nDruidLevel = value;
            }
        }

        public byte MNPaladinLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPaladinLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPaladinLevel = value;
            }
        }

        public byte MNRangerLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nRangerLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nRangerLevel = value;
            }
        }

        public byte MNSorcererLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSorcererLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSorcererLevel = value;
            }
        }

        public byte MNWizardLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nWizardLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nWizardLevel = value;
            }
        }

        public byte MNInnateLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nInnateLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nInnateLevel = value;
            }
        }

        public uint MNConjureTime
        {
            get
            {
                return ((__Internal*)__Instance)->m_nConjureTime;
            }

            set
            {
                ((__Internal*)__Instance)->m_nConjureTime = value;
            }
        }

        public ushort MNConjureAnimation
        {
            get
            {
                return ((__Internal*)__Instance)->m_nConjureAnimation;
            }

            set
            {
                ((__Internal*)__Instance)->m_nConjureAnimation = value;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureHeadVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureHeadVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureHeadVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureHandVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureHandVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureHandVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureGroundVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureGroundVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureGroundVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureSoundMale
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureSoundMale));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureSoundMale = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureSoundFemale
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureSoundFemale));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureSoundFemale = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefConjureSoundVFX
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefConjureSoundVFX));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefConjureSoundVFX = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public ushort MNCastAnimation
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCastAnimation;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCastAnimation = value;
            }
        }

        public uint MNCastTime
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCastTime;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCastTime = value;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefCastHeadVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefCastHeadVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefCastHeadVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefCastHandVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefCastHandVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefCastHandVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefCastGroundVisual
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefCastGroundVisual));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefCastGroundVisual = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefCastSound
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefCastSound));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefCastSound = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public int MBProjectileSpawn
        {
            get
            {
                return ((__Internal*)__Instance)->m_bProjectileSpawn;
            }

            set
            {
                ((__Internal*)__Instance)->m_bProjectileSpawn = value;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefProjectile
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefProjectile));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefProjectile = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public uint MNProjectileType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nProjectileType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nProjectileType = value;
            }
        }

        public byte MNProjectileSpawnPoint
        {
            get
            {
                return ((__Internal*)__Instance)->m_nProjectileSpawnPoint;
            }

            set
            {
                ((__Internal*)__Instance)->m_nProjectileSpawnPoint = value;
            }
        }

        public global::NWN.LowLevel.CResRef MResrefProjectileSound
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_resrefProjectileSound));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_resrefProjectileSound = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
            }
        }

        public byte MNProjectileOrientationType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nProjectileOrientationType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nProjectileOrientationType = value;
            }
        }

        public byte MNImmunityType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nImmunityType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nImmunityType = value;
            }
        }

        public int MBImmunityItem
        {
            get
            {
                return ((__Internal*)__Instance)->m_bImmunityItem;
            }

            set
            {
                ((__Internal*)__Instance)->m_bImmunityItem = value;
            }
        }

        public int MNTalentCategory
        {
            get
            {
                return ((__Internal*)__Instance)->m_nTalentCategory;
            }

            set
            {
                ((__Internal*)__Instance)->m_nTalentCategory = value;
            }
        }

        public int MNTalentMaxCR
        {
            get
            {
                return ((__Internal*)__Instance)->m_nTalentMaxCR;
            }

            set
            {
                ((__Internal*)__Instance)->m_nTalentMaxCR = value;
            }
        }

        public uint* MPSubRadialSpell
        {
            get
            {
                return (uint*) ((__Internal*)__Instance)->m_pSubRadialSpell;
            }

            set
            {
                ((__Internal*)__Instance)->m_pSubRadialSpell = (__IntPtr) value;
            }
        }

        public byte MNSubRadialSpellCount
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSubRadialSpellCount;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSubRadialSpellCount = value;
            }
        }

        public int MBUseConcentration
        {
            get
            {
                return ((__Internal*)__Instance)->m_bUseConcentration;
            }

            set
            {
                ((__Internal*)__Instance)->m_bUseConcentration = value;
            }
        }

        public uint MNMasterSpell
        {
            get
            {
                return ((__Internal*)__Instance)->m_nMasterSpell;
            }

            set
            {
                ((__Internal*)__Instance)->m_nMasterSpell = value;
            }
        }

        public uint MNCounterSpell1
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCounterSpell1;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCounterSpell1 = value;
            }
        }

        public uint MNCounterSpell2
        {
            get
            {
                return ((__Internal*)__Instance)->m_nCounterSpell2;
            }

            set
            {
                ((__Internal*)__Instance)->m_nCounterSpell2 = value;
            }
        }

        public byte MNUserType
        {
            get
            {
                return ((__Internal*)__Instance)->m_nUserType;
            }

            set
            {
                ((__Internal*)__Instance)->m_nUserType = value;
            }
        }

        public int MBSpontaneouslyCast
        {
            get
            {
                return ((__Internal*)__Instance)->m_bSpontaneouslyCast;
            }

            set
            {
                ((__Internal*)__Instance)->m_bSpontaneouslyCast = value;
            }
        }

        public byte MNAllowedMetamagic
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAllowedMetamagic;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAllowedMetamagic = value;
            }
        }

        public uint MNAltMessage
        {
            get
            {
                return ((__Internal*)__Instance)->m_nAltMessage;
            }

            set
            {
                ((__Internal*)__Instance)->m_nAltMessage = value;
            }
        }

        public int MBHostile
        {
            get
            {
                return ((__Internal*)__Instance)->m_bHostile;
            }

            set
            {
                ((__Internal*)__Instance)->m_bHostile = value;
            }
        }

        public int MNFeatId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nFeatId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nFeatId = value;
            }
        }

        public int MBHasProjectile
        {
            get
            {
                return ((__Internal*)__Instance)->m_bHasProjectile;
            }

            set
            {
                ((__Internal*)__Instance)->m_bHasProjectile = value;
            }
        }

        public uint MNSpellId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nSpellId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nSpellId = value;
            }
        }

        public global::NWN.LowLevel.CExoString SpellNameText
        {
            get
            {
                var __ret = new global::NWN.LowLevel.CExoString.__Internal();
                __Internal.GetSpellNameText(new IntPtr(&__ret), __Instance);
                return global::NWN.LowLevel.CExoString.__CreateInstance(__ret);
            }
        }

        public int SpellHasVerbalComponent
        {
            get
            {
                var __ret = __Internal.GetSpellHasVerbalComponent(__Instance);
                return __ret;
            }
        }

        public int SpellHasSomaticComponent
        {
            get
            {
                var __ret = __Internal.GetSpellHasSomaticComponent(__Instance);
                return __ret;
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
