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
    namespace NWNXLib
    {
        namespace API
        {
            namespace Constants
            {
                namespace Animation
                {
                    public enum TYPE : uint
                    {
                        Pause = 0,
                        Ready = 1,
                        Walking = 2,
                        WalkingBackwards = 3,
                        Running = 4,
                        KnockdownFront = 5,
                        DeadFront = 6,
                        KnockdownButt = 7,
                        DeadButt = 8,
                        Attack = 9,
                        Throw = 10,
                        Dodge = 11,
                        Parry = 12,
                        Shield = 13,
                        Damage = 14,
                        Conjure1 = 15,
                        Conjure2 = 16,
                        Cast1 = 17,
                        Cast2 = 18,
                        Cast3 = 19,
                        Cast4 = 20,
                        Open = 21,
                        Closed = 22,
                        Spasm = 23,
                        CombatStepFront = 24,
                        CombatStepBack = 25,
                        CombatStepLeft = 26,
                        CombatStepRight = 27,
                        Taunt = 28,
                        OverlayGreeting = 29,
                        OverlayListen = 30,
                        Meditate = 32,
                        Worship = 33,
                        OverlaySalute = 34,
                        Bow = 35,
                        Sitting = 36,
                        Steal = 37,
                        OverlayTalkNormal = 38,
                        OverlayTalkPleading = 39,
                        OverlayTalkForceful = 40,
                        OverlayTalkLaugh = 41,
                        CombatStepDummy = 42,
                        AttackDummy = 43,
                        VictoryFighter = 44,
                        VictoryMage = 45,
                        VictoryThief = 46,
                        SitCrossLegs = 47,
                        LookFar = 48,
                        CombatStepDummyFB = 49,
                        Opened1 = 50,
                        Opened2 = 51,
                        Pause2 = 52,
                        HeadTurnLeft = 53,
                        HeadTurnRight = 54,
                        PauseScratchHead = 55,
                        PauseBored = 56,
                        PauseTired = 57,
                        PauseDrunk = 58,
                        GetLow = 59,
                        GetMid = 60,
                        Cast5 = 61,
                        Flown = 62,
                        Arrived = 63,
                        OverlayDrink = 70,
                        OverlayRead = 71,
                        Destroyed = 72,
                        PlaceableActivated = 73,
                        PlaceableDeactivated = 74,
                        PlaceableOpened = 75,
                        PlaceableClosed = 76,
                        DamageStab = 77,
                        WalkingLeft = 78,
                        WalkingRight = 79,
                        TurnOnSpotRight = 80,
                        TurnOnSpotLeft = 81,
                        CombatTurnRight = 82,
                        CombatTurnLeft = 83,
                        WalkingForwardLeft = 84,
                        WalkingForwardRight = 85,
                        RunningForwardLeft = 86,
                        RunningForwardRight = 87,
                        DialogNoAnim = 88,
                        FakeAttack = 89,
                        FakeDodgeSide = 90,
                        FakeDodgeDuck = 91,
                        Whirlwind = 92,
                        SpasmLooping = 93,
                        Flown2 = 94,
                        Arrived2 = 95,
                        CastCreature = 96,
                        Custom1 = 97,
                        Custom2 = 98,
                        DamageLeft = 99,
                        DamageRight = 100,
                        Custom3 = 101,
                        Custom4 = 102,
                        Custom5 = 103,
                        Custom6 = 104,
                        Custom7 = 105,
                        Custom8 = 106,
                        Custom9 = 107,
                        Custom10 = 108,
                        Custom11 = 109,
                        Custom12 = 110,
                        Custom13 = 111,
                        Custom14 = 112,
                        Custom15 = 113,
                        Custom16 = 114,
                        Custom17 = 115,
                        Custom18 = 116,
                        Custom19 = 117,
                        Custom20 = 118,
                        Mount1 = 119,
                        Dismount1 = 120
                    }

                    public unsafe partial class Animation
                    {
                        public partial struct __Internal
                        {
                            [SuppressUnmanagedCodeSecurity, DllImport("NWNXLib", EntryPoint = "_ZN7NWNXLib3API9Constants9Animation8ToStringEj", CallingConvention = __CallingConvention.Cdecl)]
                            internal static extern __IntPtr ToString(uint value);
                        }

                        public static string ToString(uint value)
                        {
                            var __ret = __Internal.ToString(value);
                            return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, __ret);
                        }

                        public static int MIN { get; } = 0;

                        public static int MAX { get; } = 120;
                    }
                }
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
