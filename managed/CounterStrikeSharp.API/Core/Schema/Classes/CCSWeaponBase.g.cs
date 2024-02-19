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
public partial class CCSWeaponBase : CBasePlayerWeapon, ICCSWeaponBase
{
    public CCSWeaponBase (IntPtr pointer) : base(pointer) {}

	// m_bRemoveable
	[SchemaMember("CCSWeaponBase", "m_bRemoveable")]
	public ref bool Removeable => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bRemoveable");

	// m_flFireSequenceStartTime
	[SchemaMember("CCSWeaponBase", "m_flFireSequenceStartTime")]
	public ref float FireSequenceStartTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flFireSequenceStartTime");

	// m_nFireSequenceStartTimeChange
	[SchemaMember("CCSWeaponBase", "m_nFireSequenceStartTimeChange")]
	public ref Int32 FireSequenceStartTimeChange => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nFireSequenceStartTimeChange");

	// m_nFireSequenceStartTimeAck
	[SchemaMember("CCSWeaponBase", "m_nFireSequenceStartTimeAck")]
	public ref Int32 FireSequenceStartTimeAck => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nFireSequenceStartTimeAck");

	// m_ePlayerFireEvent
	[SchemaMember("CCSWeaponBase", "m_ePlayerFireEvent")]
	public ref PlayerAnimEvent_t PlayerFireEvent => ref Schema.GetRef<PlayerAnimEvent_t>(this.Handle, "CCSWeaponBase", "m_ePlayerFireEvent");

	// m_ePlayerFireEventAttackType
	[SchemaMember("CCSWeaponBase", "m_ePlayerFireEventAttackType")]
	public ref WeaponAttackType_t PlayerFireEventAttackType => ref Schema.GetRef<WeaponAttackType_t>(this.Handle, "CCSWeaponBase", "m_ePlayerFireEventAttackType");

	// m_seqIdle
	[SchemaMember("CCSWeaponBase", "m_seqIdle")]
	public ref Int32 SeqIdle => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_seqIdle");

	// m_seqFirePrimary
	[SchemaMember("CCSWeaponBase", "m_seqFirePrimary")]
	public ref Int32 SeqFirePrimary => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_seqFirePrimary");

	// m_seqFireSecondary
	[SchemaMember("CCSWeaponBase", "m_seqFireSecondary")]
	public ref Int32 SeqFireSecondary => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_seqFireSecondary");

	// m_thirdPersonFireSequences
	[SchemaMember("CCSWeaponBase", "m_thirdPersonFireSequences")]
	public NetworkedVector<Int32> ThirdPersonFireSequences => Schema.GetDeclaredClass<NetworkedVector<Int32>>(this.Handle, "CCSWeaponBase", "m_thirdPersonFireSequences");

	// m_hCurrentThirdPersonSequence
	[SchemaMember("CCSWeaponBase", "m_hCurrentThirdPersonSequence")]
	public ref Int32 CurrentThirdPersonSequence => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_hCurrentThirdPersonSequence");

	// m_nSilencerBoneIndex
	[SchemaMember("CCSWeaponBase", "m_nSilencerBoneIndex")]
	public ref Int32 SilencerBoneIndex => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nSilencerBoneIndex");

	// m_thirdPersonSequences
	[SchemaMember("CCSWeaponBase", "m_thirdPersonSequences")]
	public Span<Int32> ThirdPersonSequences => Schema.GetFixedArray<Int32>(this.Handle, "CCSWeaponBase", "m_thirdPersonSequences", 7);

	// m_bPlayerAmmoStockOnPickup
	[SchemaMember("CCSWeaponBase", "m_bPlayerAmmoStockOnPickup")]
	public ref bool PlayerAmmoStockOnPickup => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bPlayerAmmoStockOnPickup");

	// m_bRequireUseToTouch
	[SchemaMember("CCSWeaponBase", "m_bRequireUseToTouch")]
	public ref bool RequireUseToTouch => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bRequireUseToTouch");

	// m_iState
	[SchemaMember("CCSWeaponBase", "m_iState")]
	public ref CSWeaponState_t State => ref Schema.GetRef<CSWeaponState_t>(this.Handle, "CCSWeaponBase", "m_iState");

	// m_flLastTimeInAir
	[SchemaMember("CCSWeaponBase", "m_flLastTimeInAir")]
	public ref float LastTimeInAir => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flLastTimeInAir");

	// m_flLastDeployTime
	[SchemaMember("CCSWeaponBase", "m_flLastDeployTime")]
	public ref float LastDeployTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flLastDeployTime");

	// m_nLastEmptySoundCmdNum
	[SchemaMember("CCSWeaponBase", "m_nLastEmptySoundCmdNum")]
	public ref Int32 LastEmptySoundCmdNum => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nLastEmptySoundCmdNum");

	// m_nViewModelIndex
	[SchemaMember("CCSWeaponBase", "m_nViewModelIndex")]
	public ref UInt32 ViewModelIndex => ref Schema.GetRef<UInt32>(this.Handle, "CCSWeaponBase", "m_nViewModelIndex");

	// m_bReloadsWithClips
	[SchemaMember("CCSWeaponBase", "m_bReloadsWithClips")]
	public ref bool ReloadsWithClips => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bReloadsWithClips");

	// m_flTimeWeaponIdle
	[SchemaMember("CCSWeaponBase", "m_flTimeWeaponIdle")]
	public ref float TimeWeaponIdle => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flTimeWeaponIdle");

	// m_bFireOnEmpty
	[SchemaMember("CCSWeaponBase", "m_bFireOnEmpty")]
	public ref bool FireOnEmpty => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bFireOnEmpty");

	// m_OnPlayerPickup
	[SchemaMember("CCSWeaponBase", "m_OnPlayerPickup")]
	public CEntityIOOutput OnPlayerPickup => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CCSWeaponBase", "m_OnPlayerPickup");

	// m_weaponMode
	[SchemaMember("CCSWeaponBase", "m_weaponMode")]
	public ref CSWeaponMode WeaponMode => ref Schema.GetRef<CSWeaponMode>(this.Handle, "CCSWeaponBase", "m_weaponMode");

	// m_flTurningInaccuracyDelta
	[SchemaMember("CCSWeaponBase", "m_flTurningInaccuracyDelta")]
	public ref float TurningInaccuracyDelta => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flTurningInaccuracyDelta");

	// m_vecTurningInaccuracyEyeDirLast
	[SchemaMember("CCSWeaponBase", "m_vecTurningInaccuracyEyeDirLast")]
	public Vector TurningInaccuracyEyeDirLast => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSWeaponBase", "m_vecTurningInaccuracyEyeDirLast");

	// m_flTurningInaccuracy
	[SchemaMember("CCSWeaponBase", "m_flTurningInaccuracy")]
	public ref float TurningInaccuracy => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flTurningInaccuracy");

	// m_fAccuracyPenalty
	[SchemaMember("CCSWeaponBase", "m_fAccuracyPenalty")]
	public ref float AccuracyPenalty => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_fAccuracyPenalty");

	// m_flLastAccuracyUpdateTime
	[SchemaMember("CCSWeaponBase", "m_flLastAccuracyUpdateTime")]
	public ref float LastAccuracyUpdateTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flLastAccuracyUpdateTime");

	// m_fAccuracySmoothedForZoom
	[SchemaMember("CCSWeaponBase", "m_fAccuracySmoothedForZoom")]
	public ref float AccuracySmoothedForZoom => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_fAccuracySmoothedForZoom");

	// m_fScopeZoomEndTime
	[SchemaMember("CCSWeaponBase", "m_fScopeZoomEndTime")]
	public ref float ScopeZoomEndTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_fScopeZoomEndTime");

	// m_iRecoilIndex
	[SchemaMember("CCSWeaponBase", "m_iRecoilIndex")]
	public ref Int32 IRecoilIndex => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_iRecoilIndex");

	// m_flRecoilIndex
	[SchemaMember("CCSWeaponBase", "m_flRecoilIndex")]
	public ref float FlRecoilIndex => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flRecoilIndex");

	// m_bBurstMode
	[SchemaMember("CCSWeaponBase", "m_bBurstMode")]
	public ref bool BurstMode => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bBurstMode");

	// m_nPostponeFireReadyTicks
	[SchemaMember("CCSWeaponBase", "m_nPostponeFireReadyTicks")]
	public ref Int32 PostponeFireReadyTicks => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nPostponeFireReadyTicks");

	// m_flPostponeFireReadyFrac
	[SchemaMember("CCSWeaponBase", "m_flPostponeFireReadyFrac")]
	public ref float PostponeFireReadyFrac => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flPostponeFireReadyFrac");

	// m_bInReload
	[SchemaMember("CCSWeaponBase", "m_bInReload")]
	public ref bool InReload => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bInReload");

	// m_bReloadVisuallyComplete
	[SchemaMember("CCSWeaponBase", "m_bReloadVisuallyComplete")]
	public ref bool ReloadVisuallyComplete => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bReloadVisuallyComplete");

	// m_flDroppedAtTime
	[SchemaMember("CCSWeaponBase", "m_flDroppedAtTime")]
	public ref float DroppedAtTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flDroppedAtTime");

	// m_bIsHauledBack
	[SchemaMember("CCSWeaponBase", "m_bIsHauledBack")]
	public ref bool IsHauledBack => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bIsHauledBack");

	// m_bSilencerOn
	[SchemaMember("CCSWeaponBase", "m_bSilencerOn")]
	public ref bool SilencerOn => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bSilencerOn");

	// m_flTimeSilencerSwitchComplete
	[SchemaMember("CCSWeaponBase", "m_flTimeSilencerSwitchComplete")]
	public ref float TimeSilencerSwitchComplete => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flTimeSilencerSwitchComplete");

	// m_iOriginalTeamNumber
	[SchemaMember("CCSWeaponBase", "m_iOriginalTeamNumber")]
	public ref Int32 OriginalTeamNumber => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_iOriginalTeamNumber");

	// m_flNextAttackRenderTimeOffset
	[SchemaMember("CCSWeaponBase", "m_flNextAttackRenderTimeOffset")]
	public ref float NextAttackRenderTimeOffset => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flNextAttackRenderTimeOffset");

	// m_bCanBePickedUp
	[SchemaMember("CCSWeaponBase", "m_bCanBePickedUp")]
	public ref bool CanBePickedUp => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bCanBePickedUp");

	// m_bUseCanOverrideNextOwnerTouchTime
	[SchemaMember("CCSWeaponBase", "m_bUseCanOverrideNextOwnerTouchTime")]
	public ref bool UseCanOverrideNextOwnerTouchTime => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bUseCanOverrideNextOwnerTouchTime");

	// m_nextOwnerTouchTime
	[SchemaMember("CCSWeaponBase", "m_nextOwnerTouchTime")]
	public ref float NextOwnerTouchTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_nextOwnerTouchTime");

	// m_nextPrevOwnerTouchTime
	[SchemaMember("CCSWeaponBase", "m_nextPrevOwnerTouchTime")]
	public ref float NextPrevOwnerTouchTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_nextPrevOwnerTouchTime");

	// m_hPrevOwner
	[SchemaMember("CCSWeaponBase", "m_hPrevOwner")]
	public CHandle<CCSPlayerPawn> PrevOwner => Schema.GetDeclaredClass<CHandle<CCSPlayerPawn>>(this.Handle, "CCSWeaponBase", "m_hPrevOwner");

	// m_nDropTick
	[SchemaMember("CCSWeaponBase", "m_nDropTick")]
	public ref Int32 DropTick => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_nDropTick");

	// m_donated
	[SchemaMember("CCSWeaponBase", "m_donated")]
	public ref bool Donated => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_donated");

	// m_fLastShotTime
	[SchemaMember("CCSWeaponBase", "m_fLastShotTime")]
	public ref float LastShotTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_fLastShotTime");

	// m_bWasOwnedByCT
	[SchemaMember("CCSWeaponBase", "m_bWasOwnedByCT")]
	public ref bool WasOwnedByCT => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bWasOwnedByCT");

	// m_bWasOwnedByTerrorist
	[SchemaMember("CCSWeaponBase", "m_bWasOwnedByTerrorist")]
	public ref bool WasOwnedByTerrorist => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bWasOwnedByTerrorist");

	// m_bFiredOutOfAmmoEvent
	[SchemaMember("CCSWeaponBase", "m_bFiredOutOfAmmoEvent")]
	public ref bool FiredOutOfAmmoEvent => ref Schema.GetRef<bool>(this.Handle, "CCSWeaponBase", "m_bFiredOutOfAmmoEvent");

	// m_numRemoveUnownedWeaponThink
	[SchemaMember("CCSWeaponBase", "m_numRemoveUnownedWeaponThink")]
	public ref Int32 NumRemoveUnownedWeaponThink => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_numRemoveUnownedWeaponThink");

	// m_IronSightController
	[SchemaMember("CCSWeaponBase", "m_IronSightController")]
	public CIronSightController IronSightController => Schema.GetDeclaredClass<CIronSightController>(this.Handle, "CCSWeaponBase", "m_IronSightController");

	// m_iIronSightMode
	[SchemaMember("CCSWeaponBase", "m_iIronSightMode")]
	public ref Int32 IronSightMode => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_iIronSightMode");

	// m_flLastLOSTraceFailureTime
	[SchemaMember("CCSWeaponBase", "m_flLastLOSTraceFailureTime")]
	public ref float LastLOSTraceFailureTime => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flLastLOSTraceFailureTime");

	// m_iNumEmptyAttacks
	[SchemaMember("CCSWeaponBase", "m_iNumEmptyAttacks")]
	public ref Int32 NumEmptyAttacks => ref Schema.GetRef<Int32>(this.Handle, "CCSWeaponBase", "m_iNumEmptyAttacks");

	// m_flWatTickOffset
	[SchemaMember("CCSWeaponBase", "m_flWatTickOffset")]
	public ref float WatTickOffset => ref Schema.GetRef<float>(this.Handle, "CCSWeaponBase", "m_flWatTickOffset");

}