// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;

namespace CsBindgen
{
    public static unsafe partial class UPLCNativeMethods
    {
        const string __DllName = "cardanosharp_uplc";

        [DllImport(__DllName, EntryPoint = "apply_params_to_plutus_script", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern PlutusScriptResult apply_params_to_plutus_script(byte* @params, byte* plutus_script, nuint params_length, nuint plutus_script_length);

        [DllImport(__DllName, EntryPoint = "get_ex_units", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ExUnitsResult get_ex_units(byte* tx, byte** inputs, byte** outputs, byte* cost_mdls, ulong initial_budget_mem, ulong initial_budget_step, ulong slot_config_zero_time, ulong slot_config_zero_slot, uint slot_config_slot_length, nuint tx_length, nuint inputs_outputs_length, nuint* inputs_length, nuint* outputs_length, nuint cost_mdls_length);

        [DllImport(__DllName, EntryPoint = "free_rust_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_rust_string(byte* s);


    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PlutusScriptResult
    {
        [MarshalAs(UnmanagedType.U1)] public bool success;
        public byte* value;
        public nuint length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct ExUnitsResult
    {
        [MarshalAs(UnmanagedType.U1)] public bool success;
        public byte** value;
        public nuint length;
        public nuint* length_value;
        public byte* error;
        public nuint error_length;
    }



}
    