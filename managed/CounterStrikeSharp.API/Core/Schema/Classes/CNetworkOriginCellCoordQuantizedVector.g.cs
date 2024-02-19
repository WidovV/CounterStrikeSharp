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
public partial class CNetworkOriginCellCoordQuantizedVector : NativeObject, ICNetworkOriginCellCoordQuantizedVector
{
    public CNetworkOriginCellCoordQuantizedVector (IntPtr pointer) : base(pointer) {}

	// m_cellX
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_cellX")]
	public ref UInt16 CellX => ref Schema.GetRef<UInt16>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_cellX");

	// m_cellY
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_cellY")]
	public ref UInt16 CellY => ref Schema.GetRef<UInt16>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_cellY");

	// m_cellZ
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_cellZ")]
	public ref UInt16 CellZ => ref Schema.GetRef<UInt16>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_cellZ");

	// m_nOutsideWorld
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_nOutsideWorld")]
	public ref UInt16 OutsideWorld => ref Schema.GetRef<UInt16>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_nOutsideWorld");

	// m_vecX
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_vecX")]
	public float X => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_vecX");

	// m_vecY
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_vecY")]
	public float Y => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_vecY");

	// m_vecZ
	[SchemaMember("CNetworkOriginCellCoordQuantizedVector", "m_vecZ")]
	public float Z => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkOriginCellCoordQuantizedVector", "m_vecZ");

}