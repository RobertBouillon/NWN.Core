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
    public unsafe partial class CNWSAreaInterTileSuccessors : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int nTileGridX;

            [FieldOffset(4)]
            internal int nTileGridY;

            [FieldOffset(8)]
            internal int nTileRegion;

            [FieldOffset(12)]
            internal float fTileExitX;

            [FieldOffset(16)]
            internal float fTileExitY;

            [FieldOffset(20)]
            internal float fDotProduct;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN27CNWSAreaInterTileSuccessorsC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSAreaInterTileSuccessors> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSAreaInterTileSuccessors>();

        protected bool __ownsNativeInstance;

        internal static CNWSAreaInterTileSuccessors __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSAreaInterTileSuccessors(native.ToPointer(), skipVTables);
        }

        internal static CNWSAreaInterTileSuccessors __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSAreaInterTileSuccessors)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSAreaInterTileSuccessors __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSAreaInterTileSuccessors(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CNWSAreaInterTileSuccessors(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSAreaInterTileSuccessors(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSAreaInterTileSuccessors()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSAreaInterTileSuccessors.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CNWSAreaInterTileSuccessors(global::NWN.LowLevel.CNWSAreaInterTileSuccessors _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSAreaInterTileSuccessors.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CNWSAreaInterTileSuccessors.__Internal*) __Instance) = *((global::NWN.LowLevel.CNWSAreaInterTileSuccessors.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWSAreaInterTileSuccessors __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int NTileGridX
        {
            get
            {
                return ((__Internal*)__Instance)->nTileGridX;
            }

            set
            {
                ((__Internal*)__Instance)->nTileGridX = value;
            }
        }

        public int NTileGridY
        {
            get
            {
                return ((__Internal*)__Instance)->nTileGridY;
            }

            set
            {
                ((__Internal*)__Instance)->nTileGridY = value;
            }
        }

        public int NTileRegion
        {
            get
            {
                return ((__Internal*)__Instance)->nTileRegion;
            }

            set
            {
                ((__Internal*)__Instance)->nTileRegion = value;
            }
        }

        public float FTileExitX
        {
            get
            {
                return ((__Internal*)__Instance)->fTileExitX;
            }

            set
            {
                ((__Internal*)__Instance)->fTileExitX = value;
            }
        }

        public float FTileExitY
        {
            get
            {
                return ((__Internal*)__Instance)->fTileExitY;
            }

            set
            {
                ((__Internal*)__Instance)->fTileExitY = value;
            }
        }

        public float FDotProduct
        {
            get
            {
                return ((__Internal*)__Instance)->fDotProduct;
            }

            set
            {
                ((__Internal*)__Instance)->fDotProduct = value;
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
