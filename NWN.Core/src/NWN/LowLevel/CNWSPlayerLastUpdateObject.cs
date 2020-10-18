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
    public unsafe partial class CNWSPlayerLastUpdateObject : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 1608)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint m_nGold;

            [FieldOffset(4)]
            internal short m_nArmorClass;

            [FieldOffset(6)]
            internal short m_nHenchmanArmorClass;

            [FieldOffset(8)]
            internal short m_nTotalWeightCarried;

            [FieldOffset(10)]
            internal short m_nHenchmanTotalWeightCarried;

            [FieldOffset(12)]
            internal int m_bCanLevelUp;

            [FieldOffset(16)]
            internal int m_nLevel;

            [FieldOffset(20)]
            internal uint m_nGuiSkills;

            [FieldOffset(24)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstFeats;

            [FieldOffset(40)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstBonusFeats;

            [FieldOffset(56)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstFeatUses;

            [FieldOffset(72)]
            internal uint m_nPlayerState;

            [FieldOffset(76)]
            internal int m_nPolymorphSpellId1;

            [FieldOffset(80)]
            internal int m_nPolymorphSpellId2;

            [FieldOffset(84)]
            internal int m_nPolymorphSpellId3;

            [FieldOffset(88)]
            internal fixed byte m_pActionQueueList[280];

            [FieldOffset(368)]
            internal __IntPtr m_pAutoMapTileData;

            [FieldOffset(376)]
            internal uint m_oidAutoMapArea;

            [FieldOffset(384)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_lstVisibilityList;

            [FieldOffset(400)]
            internal fixed byte m_pKnownSpellList[30];

            [FieldOffset(880)]
            internal fixed byte m_pMemorizedSpellList[30];

            [FieldOffset(1360)]
            internal fixed byte m_lstKnownSpellsToDelete[48];

            [FieldOffset(1408)]
            internal fixed byte m_lstKnownSpellsToAdd[48];

            [FieldOffset(1456)]
            internal fixed byte m_lstMemorizedSpellsToDelete[48];

            [FieldOffset(1504)]
            internal fixed byte m_lstMemorizedSpellsToAdd[48];

            [FieldOffset(1552)]
            internal fixed byte m_pKnownSpellUsesLeft[30];

            [FieldOffset(1584)]
            internal global::NWN.LowLevel.CExoArrayList.__Internal m_aEffectIcons;

            [FieldOffset(1600)]
            internal __IntPtr m_pSpellLikeAbilityList;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObjectC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObjectC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObjectD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject21SetMemorizedSpellSlotEhhhjih", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetMemorizedSpellSlot(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot, uint nSpellId, int bDomainSpell, byte nMetaType);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject13AddKnownSpellEhhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void AddKnownSpell(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, uint nSpellId);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16ClearKnownSpellsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearKnownSpells(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject20ClearMemorizedSpellsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearMemorizedSpells(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject13GetKnownSpellEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetKnownSpell(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject17GetMemorizedSpellEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetMemorizedSpell(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject24GetMemorizedSpellReadiedEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetMemorizedSpellReadied(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject24SetMemorizedSpellReadiedEhhhi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetMemorizedSpellReadied(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot, int bReadied);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject25GetMemorizedSpellMetaTypeEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern byte GetMemorizedSpellMetaType(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16GetIsDomainSpellEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetIsDomainSpell(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nSpellSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject28SetNumberMemorizedSpellSlotsEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetNumberMemorizedSpellSlots(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nNumSlots);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject24ClearSpellAddDeleteListsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearSpellAddDeleteLists(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject23ClearKnownSpellUsesLeftEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearKnownSpellUsesLeft(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject21GetKnownSpellUsesLeftEhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern byte GetKnownSpellUsesLeft(__IntPtr __instance, byte nMultiClass, byte nSpellLevel);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject21SetKnownSpellUsesLeftEhhh", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetKnownSpellUsesLeft(__IntPtr __instance, byte nMultiClass, byte nSpellLevel, byte nUses);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject19ClearVisibilityListEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearVisibilityList(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16ClearActionQueueEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearActionQueue(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16ClearAutoMapDataEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearAutoMapData(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16ResetAutoMapDataEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ResetAutoMapData(__IntPtr __instance, uint oidArea);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject21InitializeAutoMapDataEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int InitializeAutoMapData(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWSPlayerLastUpdateObject16ClearEffectIconsEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearEffectIcons(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSPlayerLastUpdateObject> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSPlayerLastUpdateObject>();

        protected bool __ownsNativeInstance;

        internal static CNWSPlayerLastUpdateObject __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSPlayerLastUpdateObject(native.ToPointer(), skipVTables);
        }

        internal static CNWSPlayerLastUpdateObject __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSPlayerLastUpdateObject)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSPlayerLastUpdateObject __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSPlayerLastUpdateObject(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWSPlayerLastUpdateObject.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWSPlayerLastUpdateObject(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSPlayerLastUpdateObject(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSPlayerLastUpdateObject()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSPlayerLastUpdateObject.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWSPlayerLastUpdateObject(global::NWN.LowLevel.CNWSPlayerLastUpdateObject _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSPlayerLastUpdateObject.__Internal));
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
            global::NWN.LowLevel.CNWSPlayerLastUpdateObject __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void SetMemorizedSpellSlot(byte nMultiClass, byte nSpellLevel, byte nSpellSlot, uint nSpellId, int bDomainSpell, byte nMetaType)
        {
            __Internal.SetMemorizedSpellSlot(__Instance, nMultiClass, nSpellLevel, nSpellSlot, nSpellId, bDomainSpell, nMetaType);
        }

        public void AddKnownSpell(byte nMultiClass, byte nSpellLevel, uint nSpellId)
        {
            __Internal.AddKnownSpell(__Instance, nMultiClass, nSpellLevel, nSpellId);
        }

        public void ClearKnownSpells()
        {
            __Internal.ClearKnownSpells(__Instance);
        }

        public void ClearMemorizedSpells()
        {
            __Internal.ClearMemorizedSpells(__Instance);
        }

        public uint GetKnownSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot)
        {
            var __ret = __Internal.GetKnownSpell(__Instance, nMultiClass, nSpellLevel, nSpellSlot);
            return __ret;
        }

        public uint GetMemorizedSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot)
        {
            var __ret = __Internal.GetMemorizedSpell(__Instance, nMultiClass, nSpellLevel, nSpellSlot);
            return __ret;
        }

        public int GetMemorizedSpellReadied(byte nMultiClass, byte nSpellLevel, byte nSpellSlot)
        {
            var __ret = __Internal.GetMemorizedSpellReadied(__Instance, nMultiClass, nSpellLevel, nSpellSlot);
            return __ret;
        }

        public void SetMemorizedSpellReadied(byte nMultiClass, byte nSpellLevel, byte nSpellSlot, int bReadied)
        {
            __Internal.SetMemorizedSpellReadied(__Instance, nMultiClass, nSpellLevel, nSpellSlot, bReadied);
        }

        public byte GetMemorizedSpellMetaType(byte nMultiClass, byte nSpellLevel, byte nSpellSlot)
        {
            var __ret = __Internal.GetMemorizedSpellMetaType(__Instance, nMultiClass, nSpellLevel, nSpellSlot);
            return __ret;
        }

        public int GetIsDomainSpell(byte nMultiClass, byte nSpellLevel, byte nSpellSlot)
        {
            var __ret = __Internal.GetIsDomainSpell(__Instance, nMultiClass, nSpellLevel, nSpellSlot);
            return __ret;
        }

        public void SetNumberMemorizedSpellSlots(byte nMultiClass, byte nSpellLevel, byte nNumSlots)
        {
            __Internal.SetNumberMemorizedSpellSlots(__Instance, nMultiClass, nSpellLevel, nNumSlots);
        }

        public void ClearSpellAddDeleteLists()
        {
            __Internal.ClearSpellAddDeleteLists(__Instance);
        }

        public void ClearKnownSpellUsesLeft()
        {
            __Internal.ClearKnownSpellUsesLeft(__Instance);
        }

        public byte GetKnownSpellUsesLeft(byte nMultiClass, byte nSpellLevel)
        {
            var __ret = __Internal.GetKnownSpellUsesLeft(__Instance, nMultiClass, nSpellLevel);
            return __ret;
        }

        public void SetKnownSpellUsesLeft(byte nMultiClass, byte nSpellLevel, byte nUses)
        {
            __Internal.SetKnownSpellUsesLeft(__Instance, nMultiClass, nSpellLevel, nUses);
        }

        public void ClearVisibilityList()
        {
            __Internal.ClearVisibilityList(__Instance);
        }

        public void ClearActionQueue()
        {
            __Internal.ClearActionQueue(__Instance);
        }

        public void ClearAutoMapData()
        {
            __Internal.ClearAutoMapData(__Instance);
        }

        public void ResetAutoMapData(uint oidArea)
        {
            __Internal.ResetAutoMapData(__Instance, oidArea);
        }

        public int InitializeAutoMapData()
        {
            var __ret = __Internal.InitializeAutoMapData(__Instance);
            return __ret;
        }

        public void ClearEffectIcons()
        {
            __Internal.ClearEffectIcons(__Instance);
        }

        public uint MNGold
        {
            get
            {
                return ((__Internal*)__Instance)->m_nGold;
            }

            set
            {
                ((__Internal*)__Instance)->m_nGold = value;
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

        public short MNHenchmanArmorClass
        {
            get
            {
                return ((__Internal*)__Instance)->m_nHenchmanArmorClass;
            }

            set
            {
                ((__Internal*)__Instance)->m_nHenchmanArmorClass = value;
            }
        }

        public short MNTotalWeightCarried
        {
            get
            {
                return ((__Internal*)__Instance)->m_nTotalWeightCarried;
            }

            set
            {
                ((__Internal*)__Instance)->m_nTotalWeightCarried = value;
            }
        }

        public short MNHenchmanTotalWeightCarried
        {
            get
            {
                return ((__Internal*)__Instance)->m_nHenchmanTotalWeightCarried;
            }

            set
            {
                ((__Internal*)__Instance)->m_nHenchmanTotalWeightCarried = value;
            }
        }

        public int MBCanLevelUp
        {
            get
            {
                return ((__Internal*)__Instance)->m_bCanLevelUp;
            }

            set
            {
                ((__Internal*)__Instance)->m_bCanLevelUp = value;
            }
        }

        public int MNLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nLevel = value;
            }
        }

        public uint MNGuiSkills
        {
            get
            {
                return ((__Internal*)__Instance)->m_nGuiSkills;
            }

            set
            {
                ((__Internal*)__Instance)->m_nGuiSkills = value;
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

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CFeatUseListEntry> MLstFeatUses
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CFeatUseListEntry>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_lstFeatUses));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_lstFeatUses = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
            }
        }

        public uint MNPlayerState
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPlayerState;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPlayerState = value;
            }
        }

        public int MNPolymorphSpellId1
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPolymorphSpellId1;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPolymorphSpellId1 = value;
            }
        }

        public int MNPolymorphSpellId2
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPolymorphSpellId2;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPolymorphSpellId2 = value;
            }
        }

        public int MNPolymorphSpellId3
        {
            get
            {
                return ((__Internal*)__Instance)->m_nPolymorphSpellId3;
            }

            set
            {
                ((__Internal*)__Instance)->m_nPolymorphSpellId3 = value;
            }
        }

        public global::NWN.LowLevel.CNWActionNode[] MPActionQueueList
        {
            get
            {
                global::NWN.LowLevel.CNWActionNode[] __value = null;
                if (((__Internal*)__Instance)->m_pActionQueueList != null)
                {
                    __value = new global::NWN.LowLevel.CNWActionNode[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = global::NWN.LowLevel.CNWActionNode.__CreateInstance(*((global::NWN.LowLevel.CNWActionNode.__Internal*)&(((__Internal*)__Instance)->m_pActionQueueList[i * sizeof(global::NWN.LowLevel.CNWActionNode.__Internal)])));
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
                        *(global::NWN.LowLevel.CNWActionNode.__Internal*) &((__Internal*)__Instance)->m_pActionQueueList[i * sizeof(global::NWN.LowLevel.CNWActionNode.__Internal)] = *(global::NWN.LowLevel.CNWActionNode.__Internal*)value[i].__Instance;
                }
            }
        }

        public byte* MPAutoMapTileData
        {
            get
            {
                return (byte*) ((__Internal*)__Instance)->m_pAutoMapTileData;
            }

            set
            {
                ((__Internal*)__Instance)->m_pAutoMapTileData = (__IntPtr) value;
            }
        }

        public uint MOidAutoMapArea
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidAutoMapArea;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidAutoMapArea = value;
            }
        }

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CNWVisibilityNode> MLstVisibilityList
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CNWVisibilityNode>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_lstVisibilityList));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_lstVisibilityList = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoArrayList<uint>[] MLstKnownSpellsToDelete
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<uint>[] __value = null;
                if (((__Internal*)__Instance)->m_lstKnownSpellsToDelete != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<uint>[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<uint>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)&(((__Internal*)__Instance)->m_lstKnownSpellsToDelete[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 3)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 3; i++)
                        *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*) &((__Internal*)__Instance)->m_lstKnownSpellsToDelete[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<uint>[] MLstKnownSpellsToAdd
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<uint>[] __value = null;
                if (((__Internal*)__Instance)->m_lstKnownSpellsToAdd != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<uint>[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<uint>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)&(((__Internal*)__Instance)->m_lstKnownSpellsToAdd[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 3)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 3; i++)
                        *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*) &((__Internal*)__Instance)->m_lstKnownSpellsToAdd[i * sizeof(global::NWN.LowLevel.CExoArrayList<uint>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<uint>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>[] MLstMemorizedSpellsToDelete
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>[] __value = null;
                if (((__Internal*)__Instance)->m_lstMemorizedSpellsToDelete != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__Internal*)&(((__Internal*)__Instance)->m_lstMemorizedSpellsToDelete[i * sizeof(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 3)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 3; i++)
                        *(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__Internal*) &((__Internal*)__Instance)->m_lstMemorizedSpellsToDelete[i * sizeof(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellDelete>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>[] MLstMemorizedSpellsToAdd
        {
            get
            {
                global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>[] __value = null;
                if (((__Internal*)__Instance)->m_lstMemorizedSpellsToAdd != null)
                {
                    __value = new global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__CreateInstance(*((global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__Internal*)&(((__Internal*)__Instance)->m_lstMemorizedSpellsToAdd[i * sizeof(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__Internal)])));
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 3)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 3; i++)
                        *(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__Internal*) &((__Internal*)__Instance)->m_lstMemorizedSpellsToAdd[i * sizeof(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__Internal)] = *(global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CSpellAdd>.__Internal*)value[i].__Instance;
                }
            }
        }

        public global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CEffectIconObject> MAEffectIcons
        {
            get
            {
                return global::NWN.LowLevel.CExoArrayList<global::NWN.LowLevel.CEffectIconObject>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_aEffectIcons));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_aEffectIcons = *(global::NWN.LowLevel.CExoArrayList.__Internal*) value.__Instance;
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
