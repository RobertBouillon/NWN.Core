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
    public unsafe partial class CObjectLookupTable : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr m_pdwObjectTable;

            [FieldOffset(8)]
            internal uint m_dwStart;

            [FieldOffset(12)]
            internal uint m_dwEnd;

            [FieldOffset(16)]
            internal int m_bUpdateRequired;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTableC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTableC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTableD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable5AddIDEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint AddID(__IntPtr __instance, uint dwID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable14GetIDFromIndexEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetIDFromIndex(__IntPtr __instance, uint dwSlot);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable9GetUpdateEPhPj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void GetUpdate(__IntPtr __instance, byte* pData, uint* dwSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable6UpdateEPhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Update(__IntPtr __instance, byte* pData, uint dwSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable14GetIndexFromIDEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetIndexFromID(__IntPtr __instance, uint dwID);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18CObjectLookupTable5TouchEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Touch(__IntPtr __instance, uint dwSlot);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CObjectLookupTable> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CObjectLookupTable>();

        protected bool __ownsNativeInstance;

        internal static CObjectLookupTable __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CObjectLookupTable(native.ToPointer(), skipVTables);
        }

        internal static CObjectLookupTable __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CObjectLookupTable)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CObjectLookupTable __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CObjectLookupTable(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CObjectLookupTable(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CObjectLookupTable(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CObjectLookupTable()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CObjectLookupTable.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CObjectLookupTable(global::NWN.LowLevel.CObjectLookupTable _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CObjectLookupTable.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CObjectLookupTable.__Internal*) __Instance) = *((global::NWN.LowLevel.CObjectLookupTable.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CObjectLookupTable __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint AddID(uint dwID)
        {
            var __ret = __Internal.AddID(__Instance, dwID);
            return __ret;
        }

        public uint GetIDFromIndex(uint dwSlot)
        {
            var __ret = __Internal.GetIDFromIndex(__Instance, dwSlot);
            return __ret;
        }

        public void GetUpdate(byte* pData, ref uint dwSize)
        {
            fixed (uint* __dwSize1 = &dwSize)
            {
                var __arg1 = __dwSize1;
                __Internal.GetUpdate(__Instance, pData, __arg1);
            }
        }

        public void Update(byte* pData, uint dwSize)
        {
            __Internal.Update(__Instance, pData, dwSize);
        }

        public uint GetIndexFromID(uint dwID)
        {
            var __ret = __Internal.GetIndexFromID(__Instance, dwID);
            return __ret;
        }

        public void Touch(uint dwSlot)
        {
            __Internal.Touch(__Instance, dwSlot);
        }

        public uint* MPdwObjectTable
        {
            get
            {
                return (uint*) ((__Internal*)__Instance)->m_pdwObjectTable;
            }

            set
            {
                ((__Internal*)__Instance)->m_pdwObjectTable = (__IntPtr) value;
            }
        }

        public uint MDwStart
        {
            get
            {
                return ((__Internal*)__Instance)->m_dwStart;
            }

            set
            {
                ((__Internal*)__Instance)->m_dwStart = value;
            }
        }

        public uint MDwEnd
        {
            get
            {
                return ((__Internal*)__Instance)->m_dwEnd;
            }

            set
            {
                ((__Internal*)__Instance)->m_dwEnd = value;
            }
        }

        public int MBUpdateRequired
        {
            get
            {
                return ((__Internal*)__Instance)->m_bUpdateRequired;
            }

            set
            {
                ((__Internal*)__Instance)->m_bUpdateRequired = value;
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
