// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

[GenerateAutomaticInterface]
public partial class CMathRemap : CLogicalEntity, ICMathRemap
{
    public CMathRemap (IntPtr pointer) : base(pointer) {}

	// m_flInMin
	[SchemaMember("CMathRemap", "m_flInMin")]
	public ref float InMin => ref Schema.GetRef<float>(this.Handle, "CMathRemap", "m_flInMin");

	// m_flInMax
	[SchemaMember("CMathRemap", "m_flInMax")]
	public ref float InMax => ref Schema.GetRef<float>(this.Handle, "CMathRemap", "m_flInMax");

	// m_flOut1
	[SchemaMember("CMathRemap", "m_flOut1")]
	public ref float Out1 => ref Schema.GetRef<float>(this.Handle, "CMathRemap", "m_flOut1");

	// m_flOut2
	[SchemaMember("CMathRemap", "m_flOut2")]
	public ref float Out2 => ref Schema.GetRef<float>(this.Handle, "CMathRemap", "m_flOut2");

	// m_flOldInValue
	[SchemaMember("CMathRemap", "m_flOldInValue")]
	public ref float OldInValue => ref Schema.GetRef<float>(this.Handle, "CMathRemap", "m_flOldInValue");

	// m_bEnabled
	[SchemaMember("CMathRemap", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CMathRemap", "m_bEnabled");

	// m_OnRoseAboveMin
	[SchemaMember("CMathRemap", "m_OnRoseAboveMin")]
	public CEntityIOOutput OnRoseAboveMin => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMathRemap", "m_OnRoseAboveMin");

	// m_OnRoseAboveMax
	[SchemaMember("CMathRemap", "m_OnRoseAboveMax")]
	public CEntityIOOutput OnRoseAboveMax => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMathRemap", "m_OnRoseAboveMax");

	// m_OnFellBelowMin
	[SchemaMember("CMathRemap", "m_OnFellBelowMin")]
	public CEntityIOOutput OnFellBelowMin => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMathRemap", "m_OnFellBelowMin");

	// m_OnFellBelowMax
	[SchemaMember("CMathRemap", "m_OnFellBelowMax")]
	public CEntityIOOutput OnFellBelowMax => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMathRemap", "m_OnFellBelowMax");

}