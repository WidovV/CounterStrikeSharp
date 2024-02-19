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
public partial class CFuncTankTrain : CFuncTrackTrain, ICFuncTankTrain
{
    public CFuncTankTrain (IntPtr pointer) : base(pointer) {}

	// m_OnDeath
	[SchemaMember("CFuncTankTrain", "m_OnDeath")]
	public CEntityIOOutput OnDeath => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncTankTrain", "m_OnDeath");

}