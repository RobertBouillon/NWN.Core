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
    public unsafe partial class CNWSSpellScriptData : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int m_nSpellId;

            [FieldOffset(4)]
            internal ushort m_nFeatId;

            [FieldOffset(8)]
            internal uint m_oidCaster;

            [FieldOffset(12)]
            internal uint m_oidTarget;

            [FieldOffset(16)]
            internal uint m_oidItem;

            [FieldOffset(20)]
            internal global::NWN.LowLevel.Vector.__Internal m_vTargetPosition;

            [FieldOffset(32)]
            internal global::NWN.LowLevel.CExoString.__Internal m_sScript;

            [FieldOffset(48)]
            internal uint m_oidArea;

            [FieldOffset(52)]
            internal int m_nItemCastLevel;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CNWSSpellScriptDataC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CNWSSpellScriptDataC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CNWSSpellScriptDataD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CNWSSpellScriptData8SaveDataEP7CResGFFP10CResStruct", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SaveData(__IntPtr __instance, __IntPtr pRes, __IntPtr pStruct);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CNWSSpellScriptData8LoadDataEP7CResGFFP10CResStruct", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadData(__IntPtr __instance, __IntPtr pRes, __IntPtr pStruct);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSSpellScriptData> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSSpellScriptData>();

        protected bool __ownsNativeInstance;

        internal static CNWSSpellScriptData __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSSpellScriptData(native.ToPointer(), skipVTables);
        }

        internal static CNWSSpellScriptData __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSSpellScriptData)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSSpellScriptData __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSSpellScriptData(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CNWSSpellScriptData.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CNWSSpellScriptData(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSSpellScriptData(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSSpellScriptData(global::NWN.LowLevel.CNWSSpellScriptData _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSSpellScriptData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
        }

        public CNWSSpellScriptData()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSSpellScriptData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWSSpellScriptData __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int SaveData(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResStruct pStruct)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = pStruct is null ? __IntPtr.Zero : pStruct.__Instance;
            var __ret = __Internal.SaveData(__Instance, __arg0, __arg1);
            return __ret;
        }

        public int LoadData(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResStruct pStruct)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = pStruct is null ? __IntPtr.Zero : pStruct.__Instance;
            var __ret = __Internal.LoadData(__Instance, __arg0, __arg1);
            return __ret;
        }

        public int MNSpellId
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

        public ushort MNFeatId
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

        public uint MOidCaster
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidCaster;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidCaster = value;
            }
        }

        public uint MOidTarget
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidTarget;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidTarget = value;
            }
        }

        public uint MOidItem
        {
            get
            {
                return ((__Internal*)__Instance)->m_oidItem;
            }

            set
            {
                ((__Internal*)__Instance)->m_oidItem = value;
            }
        }

        public global::NWN.LowLevel.Vector MVTargetPosition
        {
            get
            {
                return global::NWN.LowLevel.Vector.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_vTargetPosition));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_vTargetPosition = *(global::NWN.LowLevel.Vector.__Internal*) value.__Instance;
            }
        }

        public global::NWN.LowLevel.CExoString MSScript
        {
            get
            {
                return global::NWN.LowLevel.CExoString.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_sScript));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_sScript = *(global::NWN.LowLevel.CExoString.__Internal*) value.__Instance;
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

        public int MNItemCastLevel
        {
            get
            {
                return ((__Internal*)__Instance)->m_nItemCastLevel;
            }

            set
            {
                ((__Internal*)__Instance)->m_nItemCastLevel = value;
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
