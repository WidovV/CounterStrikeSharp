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
public partial class CPhysicsWire : CBaseEntity, ICPhysicsWire
{
    public CPhysicsWire (IntPtr pointer) : base(pointer) {}

	// m_nDensity
	[SchemaMember("CPhysicsWire", "m_nDensity")]
	public ref Int32 Density => ref Schema.GetRef<Int32>(this.Handle, "CPhysicsWire", "m_nDensity");

}