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
    public unsafe partial class CObjectTableManager : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2048)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed long m_pObjectTableArray[255];

            [FieldOffset(2040)]
            internal uint m_dwMaxPlayerID;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManagerC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManagerC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManagerD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager5AddIDEjPjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddID(__IntPtr __instance, uint oidID, uint* dwSlot, uint dwPlayerID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager14GetIDFromIndexEjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetIDFromIndex(__IntPtr __instance, uint dwIndex, uint dwPlayerID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager14GetIndexFromIDEjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetIndexFromID(__IntPtr __instance, uint oidID, uint dwPlayerID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager5TouchEjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int Touch(__IntPtr __instance, uint dwIndex, uint dwPlayerID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager12RemovePlayerEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int RemovePlayer(__IntPtr __instance, uint dwPlayerID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager8ClearAllEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearAll(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CObjectTableManager15CreateNewPlayerEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int CreateNewPlayer(__IntPtr __instance, uint dwPlayerID);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CObjectTableManager> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CObjectTableManager>();

        protected bool __ownsNativeInstance;

        internal static CObjectTableManager __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CObjectTableManager(native.ToPointer(), skipVTables);
        }

        internal static CObjectTableManager __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CObjectTableManager)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CObjectTableManager __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CObjectTableManager(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CObjectTableManager(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CObjectTableManager(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CObjectTableManager()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CObjectTableManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CObjectTableManager(global::NWN.LowLevel.CObjectTableManager _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CObjectTableManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CObjectTableManager.__Internal*) __Instance) = *((global::NWN.LowLevel.CObjectTableManager.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CObjectTableManager __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int AddID(uint oidID, ref uint dwSlot, uint dwPlayerID)
        {
            fixed (uint* __dwSlot1 = &dwSlot)
            {
                var __arg1 = __dwSlot1;
                var __ret = __Internal.AddID(__Instance, oidID, __arg1, dwPlayerID);
                return __ret;
            }
        }

        public uint GetIDFromIndex(uint dwIndex, uint dwPlayerID)
        {
            var __ret = __Internal.GetIDFromIndex(__Instance, dwIndex, dwPlayerID);
            return __ret;
        }

        public uint GetIndexFromID(uint oidID, uint dwPlayerID)
        {
            var __ret = __Internal.GetIndexFromID(__Instance, oidID, dwPlayerID);
            return __ret;
        }

        public int Touch(uint dwIndex, uint dwPlayerID)
        {
            var __ret = __Internal.Touch(__Instance, dwIndex, dwPlayerID);
            return __ret;
        }

        public int RemovePlayer(uint dwPlayerID)
        {
            var __ret = __Internal.RemovePlayer(__Instance, dwPlayerID);
            return __ret;
        }

        public void ClearAll()
        {
            __Internal.ClearAll(__Instance);
        }

        public int CreateNewPlayer(uint dwPlayerID)
        {
            var __ret = __Internal.CreateNewPlayer(__Instance, dwPlayerID);
            return __ret;
        }

        public global::NWN.LowLevel.CObjectLookupTable[] MPObjectTableArray
        {
            get
            {
                global::NWN.LowLevel.CObjectLookupTable[] __value = null;
                if (((__Internal*)__Instance)->m_pObjectTableArray != null)
                {
                    __value = new global::NWN.LowLevel.CObjectLookupTable[255];
                    for (int i = 0; i < 255; i++)
                        __value[i] = global::NWN.LowLevel.CObjectLookupTable.__CreateInstance((__IntPtr) ((__Internal*)__Instance)->m_pObjectTableArray[i]);
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 255)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 255; i++)
                        ((__Internal*)__Instance)->m_pObjectTableArray[i] = (long) value[i].__Instance;
                }
            }
        }

        public uint MDwMaxPlayerID
        {
            get
            {
                return ((__Internal*)__Instance)->m_dwMaxPlayerID;
            }

            set
            {
                ((__Internal*)__Instance)->m_dwMaxPlayerID = value;
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
