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
    public unsafe partial class CNWSScriptVar : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int m_int;

            [FieldOffset(4)]
            internal float m_float;

            [FieldOffset(8)]
            internal uint m_objectId;

            [FieldOffset(16)]
            internal global::NWN.LowLevel.CExoString.__Internal m_string;

            [FieldOffset(32)]
            internal global::NWN.LowLevel.CScriptLocation.__Internal m_location;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWSScriptVarC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWSScriptVarC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWSScriptVarD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN13CNWSScriptVar5ResetEj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Reset(__IntPtr __instance, uint nVarType);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK13CNWSScriptVar6HasIntEv", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HasInt(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK13CNWSScriptVar8HasFloatEv", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HasFloat(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK13CNWSScriptVar9HasObjectEv", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HasObject(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK13CNWSScriptVar9HasStringEv", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HasString(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK13CNWSScriptVar11HasLocationEv", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HasLocation(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSScriptVar> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSScriptVar>();

        protected bool __ownsNativeInstance;

        internal static CNWSScriptVar __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSScriptVar(native.ToPointer(), skipVTables);
        }

        internal static CNWSScriptVar __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSScriptVar)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSScriptVar __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSScriptVar(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWSScriptVar.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWSScriptVar(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSScriptVar(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSScriptVar()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSScriptVar.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWSScriptVar(global::NWN.LowLevel.CNWSScriptVar _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSScriptVar.__Internal));
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
            global::NWN.LowLevel.CNWSScriptVar __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void Reset(uint nVarType)
        {
            __Internal.Reset(__Instance, nVarType);
        }

        public int MInt
        {
            get
            {
                return ((__Internal*)__Instance)->m_int;
            }

            set
            {
                ((__Internal*)__Instance)->m_int = value;
            }
        }

        public float MFloat
        {
            get
            {
                return ((__Internal*)__Instance)->m_float;
            }

            set
            {
                ((__Internal*)__Instance)->m_float = value;
            }
        }

        public uint MObjectId
        {
            get
            {
                return ((__Internal*)__Instance)->m_objectId;
            }

            set
            {
                ((__Internal*)__Instance)->m_objectId = value;
            }
        }

        public global::NWN.LowLevel.CExoString MString
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_string));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_string = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CScriptLocation MLocation
        {
            get
            {
                return global::NWN.LowLevel.CScriptLocation.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_location));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_location = *(global::NWN.LowLevel.CScriptLocation.__Internal*) value.__Instance;
            }
        }

        public bool HasInt
        {
            get
            {
                var __ret = __Internal.HasInt(__Instance);
                return __ret;
            }
        }

        public bool HasFloat
        {
            get
            {
                var __ret = __Internal.HasFloat(__Instance);
                return __ret;
            }
        }

        public bool HasObject
        {
            get
            {
                var __ret = __Internal.HasObject(__Instance);
                return __ret;
            }
        }

        public bool HasString
        {
            get
            {
                var __ret = __Internal.HasString(__Instance);
                return __ret;
            }
        }

        public bool HasLocation
        {
            get
            {
                var __ret = __Internal.HasLocation(__Instance);
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
