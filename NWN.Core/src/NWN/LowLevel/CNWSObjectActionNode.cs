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
    public unsafe partial class CNWSObjectActionNode : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 160)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint m_nActionId;

            [FieldOffset(4)]
            internal fixed uint m_nParamType[12];

            [FieldOffset(56)]
            internal fixed long m_pParameter[12];

            [FieldOffset(152)]
            internal ushort m_nGroupActionId;

            [FieldOffset(154)]
            internal ushort m_nParameters;

            [FieldOffset(156)]
            internal int m_bInterruptable;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN20CNWSObjectActionNodeC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN20CNWSObjectActionNodeC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN20CNWSObjectActionNodeD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSObjectActionNode> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSObjectActionNode>();

        protected bool __ownsNativeInstance;

        internal static CNWSObjectActionNode __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSObjectActionNode(native.ToPointer(), skipVTables);
        }

        internal static CNWSObjectActionNode __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSObjectActionNode)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSObjectActionNode __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSObjectActionNode(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CNWSObjectActionNode(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSObjectActionNode(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSObjectActionNode()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSObjectActionNode.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWSObjectActionNode(global::NWN.LowLevel.CNWSObjectActionNode _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSObjectActionNode.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CNWSObjectActionNode.__Internal*) __Instance) = *((global::NWN.LowLevel.CNWSObjectActionNode.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWSObjectActionNode __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint MNActionId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nActionId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nActionId = value;
            }
        }

        public uint[] MNParamType
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->m_nParamType, 12);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 12; i++)
                        ((__Internal*)__Instance)->m_nParamType[i] = value[i];
                }
            }
        }

        public long[] MPParameter
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<long>(((__Internal*)__Instance)->m_pParameter, 12);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 12; i++)
                        ((__Internal*)__Instance)->m_pParameter[i] = value[i];
                }
            }
        }

        public ushort MNGroupActionId
        {
            get
            {
                return ((__Internal*)__Instance)->m_nGroupActionId;
            }

            set
            {
                ((__Internal*)__Instance)->m_nGroupActionId = value;
            }
        }

        public ushort MNParameters
        {
            get
            {
                return ((__Internal*)__Instance)->m_nParameters;
            }

            set
            {
                ((__Internal*)__Instance)->m_nParameters = value;
            }
        }

        public int MBInterruptable
        {
            get
            {
                return ((__Internal*)__Instance)->m_bInterruptable;
            }

            set
            {
                ((__Internal*)__Instance)->m_bInterruptable = value;
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
