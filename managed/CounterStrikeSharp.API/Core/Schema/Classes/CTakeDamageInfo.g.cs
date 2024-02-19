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
public partial class CTakeDamageInfo : NativeObject, ICTakeDamageInfo
{
    public CTakeDamageInfo (IntPtr pointer) : base(pointer) {}

	// m_vecDamageForce
	[SchemaMember("CTakeDamageInfo", "m_vecDamageForce")]
	public Vector DamageForce => Schema.GetDeclaredClass<Vector>(this.Handle, "CTakeDamageInfo", "m_vecDamageForce");

	// m_vecDamagePosition
	[SchemaMember("CTakeDamageInfo", "m_vecDamagePosition")]
	public Vector DamagePosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CTakeDamageInfo", "m_vecDamagePosition");

	// m_vecReportedPosition
	[SchemaMember("CTakeDamageInfo", "m_vecReportedPosition")]
	public Vector ReportedPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CTakeDamageInfo", "m_vecReportedPosition");

	// m_vecDamageDirection
	[SchemaMember("CTakeDamageInfo", "m_vecDamageDirection")]
	public Vector DamageDirection => Schema.GetDeclaredClass<Vector>(this.Handle, "CTakeDamageInfo", "m_vecDamageDirection");

	// m_hInflictor
	[SchemaMember("CTakeDamageInfo", "m_hInflictor")]
	public CHandle<CBaseEntity> Inflictor => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTakeDamageInfo", "m_hInflictor");

	// m_hAttacker
	[SchemaMember("CTakeDamageInfo", "m_hAttacker")]
	public CHandle<CBaseEntity> Attacker => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTakeDamageInfo", "m_hAttacker");

	// m_hAbility
	[SchemaMember("CTakeDamageInfo", "m_hAbility")]
	public CHandle<CBaseEntity> Ability => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTakeDamageInfo", "m_hAbility");

	// m_flDamage
	[SchemaMember("CTakeDamageInfo", "m_flDamage")]
	public ref float Damage => ref Schema.GetRef<float>(this.Handle, "CTakeDamageInfo", "m_flDamage");

	// m_bitsDamageType
	[SchemaMember("CTakeDamageInfo", "m_bitsDamageType")]
	public ref Int32 BitsDamageType => ref Schema.GetRef<Int32>(this.Handle, "CTakeDamageInfo", "m_bitsDamageType");

	// m_iDamageCustom
	[SchemaMember("CTakeDamageInfo", "m_iDamageCustom")]
	public ref Int32 DamageCustom => ref Schema.GetRef<Int32>(this.Handle, "CTakeDamageInfo", "m_iDamageCustom");

	// m_iAmmoType
	[SchemaMember("CTakeDamageInfo", "m_iAmmoType")]
	public ref byte AmmoType => ref Schema.GetRef<byte>(this.Handle, "CTakeDamageInfo", "m_iAmmoType");

	// m_flOriginalDamage
	[SchemaMember("CTakeDamageInfo", "m_flOriginalDamage")]
	public ref float OriginalDamage => ref Schema.GetRef<float>(this.Handle, "CTakeDamageInfo", "m_flOriginalDamage");

	// m_bShouldBleed
	[SchemaMember("CTakeDamageInfo", "m_bShouldBleed")]
	public ref bool ShouldBleed => ref Schema.GetRef<bool>(this.Handle, "CTakeDamageInfo", "m_bShouldBleed");

	// m_bShouldSpark
	[SchemaMember("CTakeDamageInfo", "m_bShouldSpark")]
	public ref bool ShouldSpark => ref Schema.GetRef<bool>(this.Handle, "CTakeDamageInfo", "m_bShouldSpark");

	// m_nDamageFlags
	[SchemaMember("CTakeDamageInfo", "m_nDamageFlags")]
	public ref TakeDamageFlags_t DamageFlags => ref Schema.GetRef<TakeDamageFlags_t>(this.Handle, "CTakeDamageInfo", "m_nDamageFlags");

	// m_nNumObjectsPenetrated
	[SchemaMember("CTakeDamageInfo", "m_nNumObjectsPenetrated")]
	public ref Int32 NumObjectsPenetrated => ref Schema.GetRef<Int32>(this.Handle, "CTakeDamageInfo", "m_nNumObjectsPenetrated");

	// m_bInTakeDamageFlow
	[SchemaMember("CTakeDamageInfo", "m_bInTakeDamageFlow")]
	public ref bool InTakeDamageFlow => ref Schema.GetRef<bool>(this.Handle, "CTakeDamageInfo", "m_bInTakeDamageFlow");

}