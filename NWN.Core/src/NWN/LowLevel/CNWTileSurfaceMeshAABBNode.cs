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
    public unsafe partial class CNWTileSurfaceMeshAABBNode : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NWN.LowLevel.Vector.__Internal vBoundBoxMin;

            [FieldOffset(12)]
            internal global::NWN.LowLevel.Vector.__Internal vBoundBoxMax;

            [FieldOffset(24)]
            internal int nTriangleId;

            [FieldOffset(28)]
            internal int nTriangleList;

            [FieldOffset(32)]
            internal int nDirection;

            [FieldOffset(40)]
            internal __IntPtr pLeft;

            [FieldOffset(48)]
            internal __IntPtr pRight;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN26CNWTileSurfaceMeshAABBNodeC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode>();

        protected bool __ownsNativeInstance;

        internal static CNWTileSurfaceMeshAABBNode __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWTileSurfaceMeshAABBNode(native.ToPointer(), skipVTables);
        }

        internal static CNWTileSurfaceMeshAABBNode __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWTileSurfaceMeshAABBNode)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWTileSurfaceMeshAABBNode __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWTileSurfaceMeshAABBNode(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CNWTileSurfaceMeshAABBNode(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWTileSurfaceMeshAABBNode(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWTileSurfaceMeshAABBNode()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CNWTileSurfaceMeshAABBNode(global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__Internal*) __Instance) = *((global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NWN.LowLevel.Vector VBoundBoxMin
        {
            get
            {
                return global::NWN.LowLevel.Vector.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->vBoundBoxMin));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->vBoundBoxMin = *(global::NWN.LowLevel.Vector.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.Vector VBoundBoxMax
        {
            get
            {
                return global::NWN.LowLevel.Vector.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->vBoundBoxMax));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->vBoundBoxMax = *(global::NWN.LowLevel.Vector.__Internal*) value.__Instance;
            }
        }

        public int NTriangleId
        {
            get
            {
                return ((__Internal*)__Instance)->nTriangleId;
            }

            set
            {
                ((__Internal*)__Instance)->nTriangleId = value;
            }
        }

        public int NTriangleList
        {
            get
            {
                return ((__Internal*)__Instance)->nTriangleList;
            }

            set
            {
                ((__Internal*)__Instance)->nTriangleList = value;
            }
        }

        public int NDirection
        {
            get
            {
                return ((__Internal*)__Instance)->nDirection;
            }

            set
            {
                ((__Internal*)__Instance)->nDirection = value;
            }
        }

        public global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode PLeft
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__GetOrCreateInstance(((__Internal*)__Instance)->pLeft, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->pLeft = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode PRight
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CNWTileSurfaceMeshAABBNode.__GetOrCreateInstance(((__Internal*)__Instance)->pRight, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->pRight = value is null ? __IntPtr.Zero : value.__Instance;
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
