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
    public unsafe partial class CNWSSound : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float m_fX;

            [FieldOffset(4)]
            internal float m_fY;

            [FieldOffset(8)]
            internal float m_fZ;

            [FieldOffset(12)]
            internal int m_bMute;

            [FieldOffset(16)]
            internal float m_fMinDistance;

            [FieldOffset(20)]
            internal float m_fMaxDistance;

            [FieldOffset(24)]
            internal float m_fGain;

            [FieldOffset(28)]
            internal float m_fElevation;

            [FieldOffset(32)]
            internal global::NWN.LowLevel.CResRef.__Internal m_cResRef;

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSoundC2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSoundC2ERKS_", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSoundD2Ev", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSound16LoadFromTemplateE7CResRef", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadFromTemplate(__IntPtr __instance, global::NWN.LowLevel.CResRef.__Internal cResRef);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSound9LoadSoundEP7CResGFFP10CResStruct", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LoadSound(__IntPtr __instance, __IntPtr pRes, __IntPtr cSoundStruct);

            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN9CNWSSound15LoadDataFromGffEP7CResGFFP10CResStruct", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void LoadDataFromGff(__IntPtr __instance, __IntPtr pRes, __IntPtr pSoundStruct);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSSound> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NWN.LowLevel.CNWSSound>();

        protected bool __ownsNativeInstance;

        internal static CNWSSound __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CNWSSound(native.ToPointer(), skipVTables);
        }

        internal static CNWSSound __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CNWSSound)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CNWSSound __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CNWSSound(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private CNWSSound(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CNWSSound(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public CNWSSound()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSSound.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public CNWSSound(global::NWN.LowLevel.CNWSSound _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::NWN.LowLevel.CNWSSound.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::NWN.LowLevel.CNWSSound.__Internal*) __Instance) = *((global::NWN.LowLevel.CNWSSound.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NWN.LowLevel.CNWSSound __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int LoadFromTemplate(global::NWN.LowLevel.CResRef cResRef)
        {
            if (ReferenceEquals(cResRef, null))
                throw new global::System.ArgumentNullException("cResRef", "Cannot be null because it is passed by value.");
            var __arg0 = cResRef.__Instance;
            var __ret = __Internal.LoadFromTemplate(__Instance, *(global::NWN.LowLevel.CResRef.__Internal*) __arg0);
            return __ret;
        }

        public int LoadSound(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResStruct cSoundStruct)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = cSoundStruct is null ? __IntPtr.Zero : cSoundStruct.__Instance;
            var __ret = __Internal.LoadSound(__Instance, __arg0, __arg1);
            return __ret;
        }

        public void LoadDataFromGff(global::NWN.LowLevel.CResGFF pRes, global::NWN.LowLevel.CResStruct pSoundStruct)
        {
            var __arg0 = pRes is null ? __IntPtr.Zero : pRes.__Instance;
            var __arg1 = pSoundStruct is null ? __IntPtr.Zero : pSoundStruct.__Instance;
            __Internal.LoadDataFromGff(__Instance, __arg0, __arg1);
        }

        public float MFX
        {
            get
            {
                return ((__Internal*)__Instance)->m_fX;
            }

            set
            {
                ((__Internal*)__Instance)->m_fX = value;
            }
        }

        public float MFY
        {
            get
            {
                return ((__Internal*)__Instance)->m_fY;
            }

            set
            {
                ((__Internal*)__Instance)->m_fY = value;
            }
        }

        public float MFZ
        {
            get
            {
                return ((__Internal*)__Instance)->m_fZ;
            }

            set
            {
                ((__Internal*)__Instance)->m_fZ = value;
            }
        }

        public int MBMute
        {
            get
            {
                return ((__Internal*)__Instance)->m_bMute;
            }

            set
            {
                ((__Internal*)__Instance)->m_bMute = value;
            }
        }

        public float MFMinDistance
        {
            get
            {
                return ((__Internal*)__Instance)->m_fMinDistance;
            }

            set
            {
                ((__Internal*)__Instance)->m_fMinDistance = value;
            }
        }

        public float MFMaxDistance
        {
            get
            {
                return ((__Internal*)__Instance)->m_fMaxDistance;
            }

            set
            {
                ((__Internal*)__Instance)->m_fMaxDistance = value;
            }
        }

        public float MFGain
        {
            get
            {
                return ((__Internal*)__Instance)->m_fGain;
            }

            set
            {
                ((__Internal*)__Instance)->m_fGain = value;
            }
        }

        public float MFElevation
        {
            get
            {
                return ((__Internal*)__Instance)->m_fElevation;
            }

            set
            {
                ((__Internal*)__Instance)->m_fElevation = value;
            }
        }

        public global::NWN.LowLevel.CResRef MCResRef
        {
            get
            {
                return global::NWN.LowLevel.CResRef.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_cResRef));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->m_cResRef = *(global::NWN.LowLevel.CResRef.__Internal*) value.__Instance;
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
