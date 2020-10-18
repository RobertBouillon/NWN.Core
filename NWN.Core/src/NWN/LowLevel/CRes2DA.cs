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
    public unsafe partial class CRes2DA : global::NWN.LowLevel.CRes, IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public new partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr vptr_CRes;

            [FieldOffset(8)]
            internal ushort m_nDemands;

            [FieldOffset(10)]
            internal ushort m_nRequests;

            [FieldOffset(12)]
            internal global::NWN.LowLevel.RESID.__Internal m_nID;

            [FieldOffset(28)]
            internal uint m_status;

            [FieldOffset(32)]
            internal __IntPtr m_pResource;

            [FieldOffset(40)]
            internal __IntPtr m_pKeyEntry;

            [FieldOffset(48)]
            internal uint m_nSize;

            [FieldOffset(52)]
            internal uint m_nRefs;

            [FieldOffset(56)]
            internal int m_bAllocHeaderData;

            [FieldOffset(60)]
            internal int m_bAllocTrailingData;

            [FieldOffset(64)]
            internal __IntPtr m_pos;

            [FieldOffset(72)]
            internal int m_bAllowCaching;

            [FieldOffset(76)]
            internal int m_bLoaded;

            [FieldOffset(80)]
            internal uint m_n2DANormalSize;

            [FieldOffset(88)]
            internal __IntPtr m_p2DAData;

            [FieldOffset(96)]
            internal __IntPtr m_p2DAHeader;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DAC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DAC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DA13Get2DADataPtrEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern byte* Get2DADataPtr(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DA15Get2DAHeaderPtrEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr Get2DAHeaderPtr(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DA10Get2DASizeEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Get2DASize(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7CRes2DA8IsLoadedEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int IsLoaded(__IntPtr __instance);
        }

        internal static new CRes2DA __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CRes2DA(native.ToPointer(), skipVTables);
        }

        internal static new CRes2DA __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CRes2DA)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static new CRes2DA __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new System.Exception("No managed instance was found");
            var result = (CRes2DA)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static CRes2DA __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CRes2DA(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CRes2DA.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CRes2DA(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CRes2DA(void* native, bool skipVTables = false)
            : base((void*) native)
        {
            if (native == null)
                return;
            if (!skipVTables)
                SetupVTables(true);
        }

        public CRes2DA()
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CRes2DA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CRes2DA");
        }

        public CRes2DA(global::NWN.LowLevel.CRes2DA _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CRes2DA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CRes2DA");
        }

        public override int OnResourceFreed()
        {
            return base.OnResourceFreed();
        }

        public override int OnResourceServiced()
        {
            return base.OnResourceServiced();
        }

        public int MBLoaded
        {
            get
            {
                return ((__Internal*)__Instance)->m_bLoaded;
            }

            set
            {
                ((__Internal*)__Instance)->m_bLoaded = value;
            }
        }

        public uint MN2DANormalSize
        {
            get
            {
                return ((__Internal*)__Instance)->m_n2DANormalSize;
            }

            set
            {
                ((__Internal*)__Instance)->m_n2DANormalSize = value;
            }
        }

        public byte* MP2DAData
        {
            get
            {
                return (byte*) ((__Internal*)__Instance)->m_p2DAData;
            }

            set
            {
                ((__Internal*)__Instance)->m_p2DAData = (__IntPtr) value;
            }
        }

        public global::NWN.LowLevel.EXO2DAHEADER MP2DAHeader
        {
            get
            {
                var __result0 = global::NWN.LowLevel.EXO2DAHEADER.__GetOrCreateInstance(((__Internal*)__Instance)->m_p2DAHeader, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_p2DAHeader = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public byte* Get2DADataPtr
        {
            get
            {
                var __ret = __Internal.Get2DADataPtr(__Instance);
                return __ret;
            }
        }

        public global::NWN.LowLevel.EXO2DAHEADER Get2DAHeaderPtr
        {
            get
            {
                var __ret = __Internal.Get2DAHeaderPtr(__Instance);
                var __result0 = global::NWN.LowLevel.EXO2DAHEADER.__GetOrCreateInstance(__ret, false);
                return __result0;
            }
        }

        public uint Get2DASize
        {
            get
            {
                var __ret = __Internal.Get2DASize(__Instance);
                return __ret;
            }
        }

        public int IsLoaded
        {
            get
            {
                var __ret = __Internal.IsLoaded(__Instance);
                return __ret;
            }
        }

        #region Virtual table interop

        // ~CRes2DA()
        private static global::NWN.LowLevel.Delegates.Action___IntPtr _dtorDelegateInstance;

        private static void _dtorDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CRes2DA.__GetInstance(__instance);
            __target.Dispose(true);
        }

        // int32_t GetFixedResourceSize()
        private static global::NWN.LowLevel.Delegates.Func_int___IntPtr _GetFixedResourceSizeDelegateInstance;

        private static int _GetFixedResourceSizeDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CRes2DA.__GetInstance(__instance);
            return __target.FixedResourceSize;
        }

        // int32_t GetFixedResourceDataOffset()
        private static global::NWN.LowLevel.Delegates.Func_int___IntPtr _GetFixedResourceDataOffsetDelegateInstance;

        private static int _GetFixedResourceDataOffsetDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CRes2DA.__GetInstance(__instance);
            return __target.FixedResourceDataOffset;
        }

        // BOOL OnResourceFreed()
        private static global::NWN.LowLevel.Delegates.Func_int___IntPtr _OnResourceFreedDelegateInstance;

        private static int _OnResourceFreedDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CRes2DA.__GetInstance(__instance);
            return __target.OnResourceFreed();
        }

        // BOOL OnResourceServiced()
        private static global::NWN.LowLevel.Delegates.Func_int___IntPtr _OnResourceServicedDelegateInstance;

        private static int _OnResourceServicedDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CRes2DA.__GetInstance(__instance);
            return __target.OnResourceServiced();
        }

        internal static new class VTableLoader
        {
            private static volatile bool initialized;
            private static readonly IntPtr*[] ManagedVTables = new IntPtr*[1];
            private static readonly IntPtr*[] ManagedVTablesDtorOnly = new IntPtr*[1];
            private static readonly IntPtr[] Thunks = new IntPtr[5];
            private static CppSharp.Runtime.VTables VTables;
            private static readonly global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>
                SafeHandles = new global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>();

            static VTableLoader()
            {
                _dtorDelegateInstance += _dtorDelegateHook;
                _GetFixedResourceSizeDelegateInstance += _GetFixedResourceSizeDelegateHook;
                _GetFixedResourceDataOffsetDelegateInstance += _GetFixedResourceDataOffsetDelegateHook;
                _OnResourceFreedDelegateInstance += _OnResourceFreedDelegateHook;
                _OnResourceServicedDelegateInstance += _OnResourceServicedDelegateHook;
                Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance);
                Thunks[1] = Marshal.GetFunctionPointerForDelegate(_GetFixedResourceSizeDelegateInstance);
                Thunks[2] = Marshal.GetFunctionPointerForDelegate(_GetFixedResourceDataOffsetDelegateInstance);
                Thunks[3] = Marshal.GetFunctionPointerForDelegate(_OnResourceFreedDelegateInstance);
                Thunks[4] = Marshal.GetFunctionPointerForDelegate(_OnResourceServicedDelegateInstance);
            }

            public static CppSharp.Runtime.VTables SetupVTables(IntPtr instance, bool destructorOnly = false)
            {
                if (!initialized)
                {
                    lock (ManagedVTables)
                    {
                        if (!initialized)
                        {
                            initialized = true;
                            VTables.Tables = new IntPtr[] { *(IntPtr*)(instance + 0) };
                            VTables.Methods = new Delegate[1][];
                            ManagedVTablesDtorOnly[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTablesDtorOnly[0][1] = Thunks[0];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTables[0][1] = Thunks[0];
                            ManagedVTables[0][2] = Thunks[1];
                            ManagedVTables[0][3] = Thunks[2];
                            ManagedVTables[0][4] = Thunks[3];
                            ManagedVTables[0][5] = Thunks[4];
                            VTables.Methods[0] = new Delegate[8];
                        }
                    }
                }

                if (destructorOnly)
                {
                    *(IntPtr**)(instance + 0) = ManagedVTablesDtorOnly[0];
                }
                else
                {
                    *(IntPtr**)(instance + 0) = ManagedVTables[0];
                }
                return VTables;
            }
        }

        internal override CppSharp.Runtime.VTables __VTables
        { 
            get {
                if (__vtables.IsEmpty)
                    __vtables.Tables = new IntPtr[] { *(IntPtr*)(__Instance + 0) };
                return __vtables;
            }

            set {        
                __vtables = value;
            }
        }

        internal override void SetupVTables(bool destructorOnly = false)
        {
            if (__VTables.IsTransient)
                __VTables = VTableLoader.SetupVTables(__Instance, destructorOnly);
        }
        #endregion
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
