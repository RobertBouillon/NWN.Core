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
    public unsafe partial class CVirtualMachineFile : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr vptr_CResHelper;

            [FieldOffset(8)]
            internal int m_bAutoRequest;

            [FieldOffset(16)]
            internal __IntPtr m_pRes;

            [FieldOffset(24)]
            internal global::NWN.LowLevel.CResRef.__Internal m_cResRef;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CVirtualMachineFileC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CVirtualMachineFileC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CVirtualMachineFile8LoadFileERK10CExoString", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadFile(__IntPtr __instance, __IntPtr sFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CVirtualMachineFile10UnloadFileEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void UnloadFile(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN19CVirtualMachineFile7GetDataEPPcRj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void GetData(__IntPtr __instance, sbyte** pData, uint* nSize);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CVirtualMachineFile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CVirtualMachineFile>();

        protected bool __ownsNativeInstance;

        internal static CVirtualMachineFile __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CVirtualMachineFile(native.ToPointer(), skipVTables);
        }

        internal static CVirtualMachineFile __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CVirtualMachineFile)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CVirtualMachineFile __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new System.Exception("No managed instance was found");
            var result = (CVirtualMachineFile)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static CVirtualMachineFile __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CVirtualMachineFile(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CVirtualMachineFile.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CVirtualMachineFile(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CVirtualMachineFile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
            if (!skipVTables)
                SetupVTables(true);
        }

        public CVirtualMachineFile()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CVirtualMachineFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CVirtualMachineFile");
        }

        public CVirtualMachineFile(global::NWN.LowLevel.CVirtualMachineFile _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CVirtualMachineFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CVirtualMachineFile");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CVirtualMachineFile __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::NWN.LowLevel.CVirtualMachineFile.__Internal*) __Instance)->vptr_CResHelper = __VTables.Tables[0];
            if (disposing)
            {
                var ___dtorDelegate = __VTables.GetMethodDelegate<global::NWN.LowLevel.Delegates.Action___IntPtr>(0, 0);
                ___dtorDelegate(__Instance);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int LoadFile(global::NWN.LowLevel.CExoString sFileName)
        {
            if (ReferenceEquals(sFileName, null))
                throw new global::System.ArgumentNullException("sFileName", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = sFileName.__Instance;
            var __ret = __Internal.LoadFile(__Instance, __arg0);
            return __ret;
        }

        public void UnloadFile()
        {
            __Internal.UnloadFile(__Instance);
        }

        public void GetData(sbyte** pData, ref uint nSize)
        {
            fixed (uint* __nSize1 = &nSize)
            {
                var __arg1 = __nSize1;
                __Internal.GetData(__Instance, pData, __arg1);
            }
        }

        #region Virtual table interop

        // ~CVirtualMachineFile()
        private static global::NWN.LowLevel.Delegates.Action___IntPtr _dtorDelegateInstance;

        private static void _dtorDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CVirtualMachineFile.__GetInstance(__instance);
            __target.Dispose(true);
        }

        internal static class VTableLoader
        {
            private static volatile bool initialized;
            private static readonly IntPtr*[] ManagedVTables = new IntPtr*[1];
            private static readonly IntPtr*[] ManagedVTablesDtorOnly = new IntPtr*[1];
            private static readonly IntPtr[] Thunks = new IntPtr[1];
            private static CppSharp.Runtime.VTables VTables;
            private static readonly global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>
                SafeHandles = new global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>();

            static VTableLoader()
            {
                _dtorDelegateInstance += _dtorDelegateHook;
                Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance);
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
                            ManagedVTablesDtorOnly[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 4);
                            ManagedVTablesDtorOnly[0][1] = Thunks[0];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 4);
                            ManagedVTables[0][1] = Thunks[0];
                            VTables.Methods[0] = new Delegate[4];
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

        protected CppSharp.Runtime.VTables __vtables;
        internal virtual CppSharp.Runtime.VTables __VTables
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

        internal virtual void SetupVTables(bool destructorOnly = false)
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
