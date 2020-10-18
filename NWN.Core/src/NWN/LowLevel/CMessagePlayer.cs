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
    public unsafe partial class CMessagePlayerInternal
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CMessagePlayerInternal> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CMessagePlayerInternal>();

        protected bool __ownsNativeInstance;

        internal static CMessagePlayerInternal __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CMessagePlayerInternal(native.ToPointer(), skipVTables);
        }

        internal static CMessagePlayerInternal __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CMessagePlayerInternal)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CMessagePlayerInternal __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CMessagePlayerInternal(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CMessagePlayerInternal(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CMessagePlayerInternal(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class CMessagePlayer : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal __IntPtr m_pcMessagePlayerInternal;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayerC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayerC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayerD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayer27HandleServerToClientMessageEPhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandleServerToClientMessage(__IntPtr __instance, byte* pBuffer, uint nBufferSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayer25SendClientToServerMessageEhhPhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SendClientToServerMessage(__IntPtr __instance, byte nMajor, byte nMinor, byte* pBuffer, uint nBufferSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayer25SendServerToClientMessageEjhhPhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int SendServerToClientMessage(__IntPtr __instance, uint nPlayerId, byte nMajor, byte nMinor, byte* pBuffer, uint nBufferSize);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN14CMessagePlayer27HandleClientToServerMessageEjPhj", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandleClientToServerMessage(__IntPtr __instance, uint nPlayerId, byte* pBuffer, uint nBufferSize);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CMessagePlayer> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CMessagePlayer>();

        protected bool __ownsNativeInstance;

        internal static CMessagePlayer __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CMessagePlayer(native.ToPointer(), skipVTables);
        }

        internal static CMessagePlayer __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CMessagePlayer)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CMessagePlayer __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CMessagePlayer(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CMessagePlayer(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CMessagePlayer(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CMessagePlayer()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CMessagePlayer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CMessagePlayer(global::NWN.LowLevel.CMessagePlayer _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CMessagePlayer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CMessagePlayer.__Internal*) __Instance) = *((global::NWN.LowLevel.CMessagePlayer.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CMessagePlayer __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int HandleServerToClientMessage(byte* pBuffer, uint nBufferSize)
        {
            var __ret = __Internal.HandleServerToClientMessage(__Instance, pBuffer, nBufferSize);
            return __ret;
        }

        public int SendClientToServerMessage(byte nMajor, byte nMinor, byte* pBuffer, uint nBufferSize)
        {
            var __ret = __Internal.SendClientToServerMessage(__Instance, nMajor, nMinor, pBuffer, nBufferSize);
            return __ret;
        }

        public int SendServerToClientMessage(uint nPlayerId, byte nMajor, byte nMinor, byte* pBuffer, uint nBufferSize)
        {
            var __ret = __Internal.SendServerToClientMessage(__Instance, nPlayerId, nMajor, nMinor, pBuffer, nBufferSize);
            return __ret;
        }

        public int HandleClientToServerMessage(uint nPlayerId, byte* pBuffer, uint nBufferSize)
        {
            var __ret = __Internal.HandleClientToServerMessage(__Instance, nPlayerId, pBuffer, nBufferSize);
            return __ret;
        }

        public global::NWN.LowLevel.CMessagePlayerInternal MPcMessagePlayerInternal
        {
            get
            {
                var __result0 = global::NWN.LowLevel.CMessagePlayerInternal.__GetOrCreateInstance(((__Internal*)__Instance)->m_pcMessagePlayerInternal, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->m_pcMessagePlayerInternal = value is null ? __IntPtr.Zero : value.__Instance;
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
