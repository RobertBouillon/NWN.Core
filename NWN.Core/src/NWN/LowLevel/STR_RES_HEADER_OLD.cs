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
    public unsafe partial class STR_RES_HEADER_OLD : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 36)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint wFlags;

            [FieldOffset(4)]
            internal fixed byte sndResRef[16];

            [FieldOffset(20)]
            internal uint volumeVariance;

            [FieldOffset(24)]
            internal uint pitchVariance;

            [FieldOffset(28)]
            internal uint offsetToStr;

            [FieldOffset(32)]
            internal uint strSize;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN18STR_RES_HEADER_OLDC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.STR_RES_HEADER_OLD> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.STR_RES_HEADER_OLD>();

        protected bool __ownsNativeInstance;

        internal static STR_RES_HEADER_OLD __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new STR_RES_HEADER_OLD(native.ToPointer(), skipVTables);
        }

        internal static STR_RES_HEADER_OLD __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (STR_RES_HEADER_OLD)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static STR_RES_HEADER_OLD __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new STR_RES_HEADER_OLD(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private STR_RES_HEADER_OLD(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected STR_RES_HEADER_OLD(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public STR_RES_HEADER_OLD()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.STR_RES_HEADER_OLD.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public STR_RES_HEADER_OLD(global::NWN.LowLevel.STR_RES_HEADER_OLD _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.STR_RES_HEADER_OLD.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.STR_RES_HEADER_OLD.__Internal*) __Instance) = *((global::NWN.LowLevel.STR_RES_HEADER_OLD.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.STR_RES_HEADER_OLD __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint WFlags
        {
            get
            {
                return ((__Internal*)__Instance)->wFlags;
            }

            set
            {
                ((__Internal*)__Instance)->wFlags = value;
            }
        }

        public byte[] SndResRef
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->sndResRef, 16);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 16; i++)
                        ((__Internal*)__Instance)->sndResRef[i] = value[i];
                }
            }
        }

        public uint VolumeVariance
        {
            get
            {
                return ((__Internal*)__Instance)->volumeVariance;
            }

            set
            {
                ((__Internal*)__Instance)->volumeVariance = value;
            }
        }

        public uint PitchVariance
        {
            get
            {
                return ((__Internal*)__Instance)->pitchVariance;
            }

            set
            {
                ((__Internal*)__Instance)->pitchVariance = value;
            }
        }

        public uint OffsetToStr
        {
            get
            {
                return ((__Internal*)__Instance)->offsetToStr;
            }

            set
            {
                ((__Internal*)__Instance)->offsetToStr = value;
            }
        }

        public uint StrSize
        {
            get
            {
                return ((__Internal*)__Instance)->strSize;
            }

            set
            {
                ((__Internal*)__Instance)->strSize = value;
            }
        }
    }

    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_uint___IntPtr(__IntPtr __instance, uint arg1, __IntPtr arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_uint___IntPtr_int(__IntPtr __instance, uint arg1, __IntPtr arg2, int arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_uint_int_int(__IntPtr __instance, uint arg1, int arg2, int arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_uint_bytePtr_uint_int(__IntPtr __instance, uint arg1, byte* arg2, uint arg3, int arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate float Func_float___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate __IntPtr Func___IntPtr___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int___IntPtr_int(__IntPtr __instance, int arg1, __IntPtr arg2, int arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate uint Func_uint___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int(__IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr___IntPtr___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2, __IntPtr arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr___IntPtr_int(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2, __IntPtr arg3, int arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_bytePtr_uint(__IntPtr __instance, byte* arg1, uint arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate uint Func_uint___IntPtr_NWN_LowLevel_RESID___Internal(__IntPtr __instance, global::NWN.LowLevel.RESID.__Internal arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_bytePtr(__IntPtr __instance, byte* arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate uint Func_uint___IntPtr_NWN_LowLevel_RESID___Internal___IntPtr_uint_uint(__IntPtr __instance, global::NWN.LowLevel.RESID.__Internal arg1, __IntPtr arg2, uint arg3, uint arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_NWN_LowLevel_RESID___Internal___IntPtr_uint_uint(__IntPtr __instance, global::NWN.LowLevel.RESID.__Internal arg1, __IntPtr arg2, uint arg3, uint arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_byte(__IntPtr __instance, byte arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate __IntPtr Func___IntPtr___IntPtr_NWN_LowLevel_RESID___Internal(__IntPtr __instance, global::NWN.LowLevel.RESID.__Internal arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr_int(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2, int arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_uint(__IntPtr __instance, uint arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_uint_uint(__IntPtr __instance, uint arg1, uint arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr___IntPtr_uint_int(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2, __IntPtr arg3, uint arg4, int arg5);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr___IntPtr___IntPtr_uint(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2, __IntPtr arg3, uint arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_float_float_float_float___IntPtr_int_int_uintPtr_int(__IntPtr __instance, float arg1, float arg2, float arg3, float arg4, __IntPtr arg5, int arg6, int arg7, uint* arg8, int arg9);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_float_float_float_float_float_float_float_uint_uintPtr_int___IntPtr_int(__IntPtr __instance, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, uint arg8, uint* arg9, int arg10, __IntPtr arg11, int arg12);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_uint_float_float_float_float_float_float_float_uint_int(__IntPtr __instance, uint arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, uint arg9, int arg10);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int_NWN_LowLevel_Vector___Internal(__IntPtr __instance, int arg1, global::NWN.LowLevel.Vector.__Internal arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int(__IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_uint_uint___IntPtr_uint_uint(__IntPtr __instance, uint arg1, uint arg2, __IntPtr arg3, uint arg4, uint arg5);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr_int(__IntPtr __instance, __IntPtr arg1, int arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate byte Func_byte___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate short Func_short___IntPtr_int(__IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr_int_byte_int_int(__IntPtr __instance, __IntPtr arg1, int arg2, byte arg3, int arg4, int arg5);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr_int_ushort_int_int_int(__IntPtr __instance, __IntPtr arg1, int arg2, ushort arg3, int arg4, int arg5, int arg6);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_ushort_intPtr(__IntPtr __instance, ushort arg1, int* arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr___IntPtr_int_ushort_int_int(__IntPtr __instance, __IntPtr arg1, int arg2, ushort arg3, int arg4, int arg5);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate sbyte Func_sbyte___IntPtr_byte(__IntPtr __instance, byte arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate sbyte Func_sbyte___IntPtr_ushort(__IntPtr __instance, ushort arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_NWN_LowLevel_CResRef___Internal(__IntPtr __instance, global::NWN.LowLevel.CResRef.__Internal arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate ushort Func_ushort___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_ushort(__IntPtr __instance, ushort arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal unsafe delegate bool Func_bool___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr___IntPtr_int(__IntPtr __instance, __IntPtr arg1, int arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_byte_byte(__IntPtr __instance, byte arg1, byte arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int_int(__IntPtr __instance, int arg1, int arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate __IntPtr Func___IntPtr___IntPtr_int___IntPtr(__IntPtr __instance, int arg1, __IntPtr arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int___IntPtr___IntPtr(__IntPtr __instance, int arg1, __IntPtr arg2, __IntPtr arg3);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int___IntPtr(__IntPtr __instance, int arg1, __IntPtr arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate __IntPtr Func___IntPtr___IntPtr_int(__IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int___IntPtr___IntPtr___IntPtr(__IntPtr __instance, int arg1, __IntPtr arg2, __IntPtr arg3, __IntPtr arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_int_voidPtrPtr___IntPtr___IntPtr(__IntPtr __instance, int arg1, void** arg2, __IntPtr arg3, __IntPtr arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int___IntPtr_intPtr___IntPtr___IntPtr(__IntPtr __instance, int arg1, __IntPtr arg2, int* arg3, __IntPtr arg4, __IntPtr arg5);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_uint_intPtr___IntPtr___IntPtr(__IntPtr __instance, uint arg1, int* arg2, __IntPtr arg3, __IntPtr arg4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_sbytePtr_int(__IntPtr __instance, sbyte* arg1, int arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_sbytePtrPtr_intPtr(__IntPtr __instance, sbyte** arg1, int* arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1, __IntPtr arg2);
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
