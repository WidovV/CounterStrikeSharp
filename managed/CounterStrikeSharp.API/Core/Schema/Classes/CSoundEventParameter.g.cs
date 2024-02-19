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
public partial class CSoundEventParameter : CBaseEntity, ICSoundEventParameter
{
    public CSoundEventParameter (IntPtr pointer) : base(pointer) {}

	// m_iszParamName
	[SchemaMember("CSoundEventParameter", "m_iszParamName")]
	public string ParamName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundEventParameter", "m_iszParamName"); }
		set { Schema.SetString(this.Handle, "CSoundEventParameter", "m_iszParamName", value); }
	}

	// m_flFloatValue
	[SchemaMember("CSoundEventParameter", "m_flFloatValue")]
	public ref float FloatValue => ref Schema.GetRef<float>(this.Handle, "CSoundEventParameter", "m_flFloatValue");

}