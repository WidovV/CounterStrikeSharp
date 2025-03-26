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

public partial class CLogicMeasureMovement : CLogicalEntity
{
    public CLogicMeasureMovement (IntPtr pointer) : base(pointer) {}

	// m_strMeasureTarget
	[SchemaMember("CLogicMeasureMovement", "m_strMeasureTarget")]
	public string StrMeasureTarget
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicMeasureMovement", "m_strMeasureTarget"); }
		set { Schema.SetString(this.Handle, "CLogicMeasureMovement", "m_strMeasureTarget", value); }
	}

	// m_strMeasureReference
	[SchemaMember("CLogicMeasureMovement", "m_strMeasureReference")]
	public string StrMeasureReference
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicMeasureMovement", "m_strMeasureReference"); }
		set { Schema.SetString(this.Handle, "CLogicMeasureMovement", "m_strMeasureReference", value); }
	}

	// m_strTargetReference
	[SchemaMember("CLogicMeasureMovement", "m_strTargetReference")]
	public string StrTargetReference
	{
		get { return Schema.GetUtf8String(this.Handle, "CLogicMeasureMovement", "m_strTargetReference"); }
		set { Schema.SetString(this.Handle, "CLogicMeasureMovement", "m_strTargetReference", value); }
	}

	// m_hMeasureTarget
	[SchemaMember("CLogicMeasureMovement", "m_hMeasureTarget")]
	public CHandle<CBaseEntity> MeasureTarget => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CLogicMeasureMovement", "m_hMeasureTarget");

	// m_hMeasureReference
	[SchemaMember("CLogicMeasureMovement", "m_hMeasureReference")]
	public CHandle<CBaseEntity> MeasureReference => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CLogicMeasureMovement", "m_hMeasureReference");

	// m_hTarget
	[SchemaMember("CLogicMeasureMovement", "m_hTarget")]
	public new CHandle<CBaseEntity> Target => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CLogicMeasureMovement", "m_hTarget");

	// m_hTargetReference
	[SchemaMember("CLogicMeasureMovement", "m_hTargetReference")]
	public CHandle<CBaseEntity> TargetReference => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CLogicMeasureMovement", "m_hTargetReference");

	// m_flScale
	[SchemaMember("CLogicMeasureMovement", "m_flScale")]
	public ref float Scale => ref Schema.GetRef<float>(this.Handle, "CLogicMeasureMovement", "m_flScale");

	// m_nMeasureType
	[SchemaMember("CLogicMeasureMovement", "m_nMeasureType")]
	public ref Int32 MeasureType => ref Schema.GetRef<Int32>(this.Handle, "CLogicMeasureMovement", "m_nMeasureType");

}
