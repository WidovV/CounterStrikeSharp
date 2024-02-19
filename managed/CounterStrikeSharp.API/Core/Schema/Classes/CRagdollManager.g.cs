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
public partial class CRagdollManager : CBaseEntity, ICRagdollManager
{
    public CRagdollManager (IntPtr pointer) : base(pointer) {}

	// m_iCurrentMaxRagdollCount
	[SchemaMember("CRagdollManager", "m_iCurrentMaxRagdollCount")]
	public ref sbyte CurrentMaxRagdollCount => ref Schema.GetRef<sbyte>(this.Handle, "CRagdollManager", "m_iCurrentMaxRagdollCount");

	// m_iMaxRagdollCount
	[SchemaMember("CRagdollManager", "m_iMaxRagdollCount")]
	public ref Int32 MaxRagdollCount => ref Schema.GetRef<Int32>(this.Handle, "CRagdollManager", "m_iMaxRagdollCount");

	// m_bSaveImportant
	[SchemaMember("CRagdollManager", "m_bSaveImportant")]
	public ref bool SaveImportant => ref Schema.GetRef<bool>(this.Handle, "CRagdollManager", "m_bSaveImportant");

}