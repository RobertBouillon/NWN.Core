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
    public unsafe partial class CTlkResFile : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 96)]
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

            [FieldOffset(56)]
            internal __IntPtr vptr_CExoFile;

            [FieldOffset(64)]
            internal __IntPtr m_pcExoFileInternal;

            [FieldOffset(72)]
            internal global::NWN.LowLevel.TLK_FILE_HEADER.__Internal m_header;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN11CTlkResFileC2ERK7CResRef", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance, __IntPtr pResRef);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN11CTlkResFileC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor_1(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CTlkFile10ReadHeaderEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ReadHeader(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile15SetMemoryBufferEPKvi", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetMemoryBuffer(__IntPtr __instance, __IntPtr pMemoryBuffer, int nSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile4ReadEPvjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Read(__IntPtr __instance, __IntPtr ptr, uint size, uint number);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile4ReadER10CExoStringj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Read(__IntPtr __instance, __IntPtr @string, uint length);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile9ReadAsyncEPvjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ReadAsync(__IntPtr __instance, __IntPtr ptr, uint size, uint number);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile17ReadAsyncCompleteEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ReadAsyncComplete(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile18ReadAsyncBytesReadEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint ReadAsyncBytesRead(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile5WriteEPKvjj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Write(__IntPtr __instance, __IntPtr ptr, uint size, uint number);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile5WriteEPKc", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Write(__IntPtr __instance, [MarshalAs(UnmanagedType.LPUTF8Str)] string @string);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile5WriteERK10CExoString", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint Write(__IntPtr __instance, __IntPtr @string);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile4SeekEii", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int Seek(__IntPtr __instance, int offset, int whence);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK8CExoFile14IsMemoryBackedEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int IsMemoryBacked(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile3EofEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int Eof(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile10FileOpenedEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int FileOpened(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile5FlushEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int Flush(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile9GetOffsetEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern uint GetOffset(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile7GetSizeEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetSize(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile13SeekBeginningEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SeekBeginning(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN8CExoFile7SeekEndEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SeekEnd(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZNK8CExoFile9IsMMappedEv", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int IsMMapped(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CTlkResFile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CTlkResFile>();

        protected bool __ownsNativeInstance;

        internal static CTlkResFile __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CTlkResFile(native.ToPointer(), skipVTables);
        }

        internal static CTlkResFile __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CTlkResFile)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CTlkResFile __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new System.Exception("No managed instance was found");
            var result = (CTlkResFile)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static CTlkResFile __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CTlkResFile(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::NWN.LowLevel.CTlkResFile.__Internal.cctor_1(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private CTlkResFile(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CTlkResFile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
            if (!skipVTables)
                SetupVTables(true);
        }

        public CTlkResFile(global::NWN.LowLevel.CResRef pResRef)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CTlkResFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(pResRef, null))
                throw new global::System.ArgumentNullException("pResRef", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = pResRef.__Instance;
            __Internal.ctor(__Instance + 56, __arg0);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CTlkResFile");
        }

        public CTlkResFile(global::NWN.LowLevel.CTlkResFile _0)
            : this((void*) null)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CTlkResFile.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor_1(__Instance + 56, __arg0);
            SetupVTables(GetType().FullName == "NWN.LowLevel.CTlkResFile");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CTlkResFile __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            ((global::NWN.LowLevel.CTlkResFile.__Internal*) __Instance)->vptr_CResHelper = __VTables.Tables[0];
            if (disposing)
            {
                var ___dtorDelegate = __VTables.GetMethodDelegate<global::NWN.LowLevel.Delegates.Action___IntPtr>(0, 0);
                ___dtorDelegate(__Instance + 56);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static implicit operator global::NWN.LowLevel.CTlkResFile(global::NWN.LowLevel.CResRef pResRef)
        {
            return new global::NWN.LowLevel.CTlkResFile(pResRef);
        }

        public int ReadHeader()
        {
            var __ret = __Internal.ReadHeader(__Instance + 56);
            return __ret;
        }

        public void SetMemoryBuffer(__IntPtr pMemoryBuffer, int nSize)
        {
            __Internal.SetMemoryBuffer(__Instance + 56, pMemoryBuffer, nSize);
        }

        public uint Read(__IntPtr ptr, uint size, uint number)
        {
            var __ret = __Internal.Read(__Instance + 56, ptr, size, number);
            return __ret;
        }

        public uint Read(global::NWN.LowLevel.CExoString @string, uint length)
        {
            if (ReferenceEquals(@string, null))
                throw new global::System.ArgumentNullException("@string", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = @string.__Instance;
            var __ret = __Internal.Read(__Instance + 56, __arg0, length);
            return __ret;
        }

        public void ReadAsync(__IntPtr ptr, uint size, uint number)
        {
            __Internal.ReadAsync(__Instance + 56, ptr, size, number);
        }

        public int ReadAsyncComplete()
        {
            var __ret = __Internal.ReadAsyncComplete(__Instance + 56);
            return __ret;
        }

        public uint ReadAsyncBytesRead()
        {
            var __ret = __Internal.ReadAsyncBytesRead(__Instance + 56);
            return __ret;
        }

        public uint Write(__IntPtr ptr, uint size, uint number)
        {
            var __ret = __Internal.Write(__Instance + 56, ptr, size, number);
            return __ret;
        }

        public uint Write(string @string)
        {
            var __ret = __Internal.Write(__Instance + 56, @string);
            return __ret;
        }

        public uint Write(global::NWN.LowLevel.CExoString @string)
        {
            if (ReferenceEquals(@string, null))
                throw new global::System.ArgumentNullException("@string", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = @string.__Instance;
            var __ret = __Internal.Write(__Instance + 56, __arg0);
            return __ret;
        }

        public int Seek(int offset, int whence)
        {
            var __ret = __Internal.Seek(__Instance + 56, offset, whence);
            return __ret;
        }

        public global::NWN.LowLevel.TLK_FILE_HEADER MHeader
        {
            get
            {
                return global::NWN.LowLevel.TLK_FILE_HEADER.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_header));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_header = *(global::NWN.LowLevel.TLK_FILE_HEADER.__Internal*) value.__Instance;
            }
        }

        public __IntPtr __PointerToCTlkFile
        {
            get
            {
                return __Instance + 56;
            }
        }

        public global::NWN.LowLevel.CExoFileInternal MPcExoFileInternal
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CExoFileInternal.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcExoFileInternal, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcExoFileInternal = value is null ? __IntPtr.Zero : value.__Instance;
            }
        }

        public __IntPtr __PointerToCExoFile
        {
            get
            {
                return __Instance + 56;
            }
        }

        public int IsMemoryBacked
        {
            get
            {
                var __ret = __Internal.IsMemoryBacked(__Instance + 56);
                return __ret;
            }
        }

        public int Eof
        {
            get
            {
                var __ret = __Internal.Eof(__Instance + 56);
                return __ret;
            }
        }

        public int FileOpened
        {
            get
            {
                var __ret = __Internal.FileOpened(__Instance + 56);
                return __ret;
            }
        }

        public int Flush
        {
            get
            {
                var __ret = __Internal.Flush(__Instance + 56);
                return __ret;
            }
        }

        public uint Offset
        {
            get
            {
                var __ret = __Internal.GetOffset(__Instance + 56);
                return __ret;
            }
        }

        public int Size
        {
            get
            {
                var __ret = __Internal.GetSize(__Instance + 56);
                return __ret;
            }
        }

        public int SeekBeginning
        {
            get
            {
                var __ret = __Internal.SeekBeginning(__Instance + 56);
                return __ret;
            }
        }

        public int SeekEnd
        {
            get
            {
                var __ret = __Internal.SeekEnd(__Instance + 56);
                return __ret;
            }
        }

        public int IsMMapped
        {
            get
            {
                var __ret = __Internal.IsMMapped(__Instance + 56);
                return __ret;
            }
        }

        #region Virtual table interop

        // virtual ~CTlkResFile()
        private static global::NWN.LowLevel.Delegates.Action___IntPtr _dtorDelegateInstance;

        private static void _dtorDelegateHook(__IntPtr __instance)
        {
            var __target = global::NWN.LowLevel.CTlkResFile.__GetInstance(__instance);
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
                            ManagedVTablesDtorOnly[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTablesDtorOnly[0][1] = Thunks[0];
                            ManagedVTablesDtorOnly[0][5] = Thunks[0];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTables[0][1] = Thunks[0];
                            ManagedVTables[0][5] = Thunks[0];
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
