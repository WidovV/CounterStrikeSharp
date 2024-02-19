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
public partial class CTriggerLook : CTriggerOnce, ICTriggerLook
{
    public CTriggerLook (IntPtr pointer) : base(pointer) {}

	// m_hLookTarget
	[SchemaMember("CTriggerLook", "m_hLookTarget")]
	public CHandle<CBaseEntity> LookTarget => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTriggerLook", "m_hLookTarget");

	// m_flFieldOfView
	[SchemaMember("CTriggerLook", "m_flFieldOfView")]
	public ref float FieldOfView => ref Schema.GetRef<float>(this.Handle, "CTriggerLook", "m_flFieldOfView");

	// m_flLookTime
	[SchemaMember("CTriggerLook", "m_flLookTime")]
	public ref float LookTime => ref Schema.GetRef<float>(this.Handle, "CTriggerLook", "m_flLookTime");

	// m_flLookTimeTotal
	[SchemaMember("CTriggerLook", "m_flLookTimeTotal")]
	public ref float LookTimeTotal => ref Schema.GetRef<float>(this.Handle, "CTriggerLook", "m_flLookTimeTotal");

	// m_flLookTimeLast
	[SchemaMember("CTriggerLook", "m_flLookTimeLast")]
	public ref float LookTimeLast => ref Schema.GetRef<float>(this.Handle, "CTriggerLook", "m_flLookTimeLast");

	// m_flTimeoutDuration
	[SchemaMember("CTriggerLook", "m_flTimeoutDuration")]
	public ref float TimeoutDuration => ref Schema.GetRef<float>(this.Handle, "CTriggerLook", "m_flTimeoutDuration");

	// m_bTimeoutFired
	[SchemaMember("CTriggerLook", "m_bTimeoutFired")]
	public ref bool TimeoutFired => ref Schema.GetRef<bool>(this.Handle, "CTriggerLook", "m_bTimeoutFired");

	// m_bIsLooking
	[SchemaMember("CTriggerLook", "m_bIsLooking")]
	public ref bool IsLooking => ref Schema.GetRef<bool>(this.Handle, "CTriggerLook", "m_bIsLooking");

	// m_b2DFOV
	[SchemaMember("CTriggerLook", "m_b2DFOV")]
	public ref bool B2DFOV => ref Schema.GetRef<bool>(this.Handle, "CTriggerLook", "m_b2DFOV");

	// m_bUseVelocity
	[SchemaMember("CTriggerLook", "m_bUseVelocity")]
	public ref bool UseVelocity => ref Schema.GetRef<bool>(this.Handle, "CTriggerLook", "m_bUseVelocity");

	// m_hActivator
	[SchemaMember("CTriggerLook", "m_hActivator")]
	public CHandle<CBaseEntity> Activator => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CTriggerLook", "m_hActivator");

	// m_bTestOcclusion
	[SchemaMember("CTriggerLook", "m_bTestOcclusion")]
	public ref bool TestOcclusion => ref Schema.GetRef<bool>(this.Handle, "CTriggerLook", "m_bTestOcclusion");

	// m_OnTimeout
	[SchemaMember("CTriggerLook", "m_OnTimeout")]
	public CEntityIOOutput OnTimeout => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerLook", "m_OnTimeout");

	// m_OnStartLook
	[SchemaMember("CTriggerLook", "m_OnStartLook")]
	public CEntityIOOutput OnStartLook => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerLook", "m_OnStartLook");

	// m_OnEndLook
	[SchemaMember("CTriggerLook", "m_OnEndLook")]
	public CEntityIOOutput OnEndLook => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerLook", "m_OnEndLook");

}