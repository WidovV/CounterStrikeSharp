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
public partial class CFuncPlatRot : CFuncPlat, ICFuncPlatRot
{
    public CFuncPlatRot (IntPtr pointer) : base(pointer) {}

	// m_end
	[SchemaMember("CFuncPlatRot", "m_end")]
	public QAngle End => Schema.GetDeclaredClass<QAngle>(this.Handle, "CFuncPlatRot", "m_end");

	// m_start
	[SchemaMember("CFuncPlatRot", "m_start")]
	public QAngle Start => Schema.GetDeclaredClass<QAngle>(this.Handle, "CFuncPlatRot", "m_start");

}