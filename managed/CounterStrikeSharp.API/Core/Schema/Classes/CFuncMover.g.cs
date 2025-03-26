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

public partial class CFuncMover : CBaseModelEntity
{
    public CFuncMover (IntPtr pointer) : base(pointer) {}

	// m_bCreateMovableNavMesh
	[SchemaMember("CFuncMover", "m_bCreateMovableNavMesh")]
	public ref bool CreateMovableNavMesh => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bCreateMovableNavMesh");

	// m_iszPathName
	[SchemaMember("CFuncMover", "m_iszPathName")]
	public string PathName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszPathName"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszPathName", value); }
	}

	// m_hPathMover
	[SchemaMember("CFuncMover", "m_hPathMover")]
	public CHandle<CPathMover> PathMover => Schema.GetDeclaredClass<CHandle<CPathMover>>(this.Handle, "CFuncMover", "m_hPathMover");

	// m_iszPathNodeStart
	[SchemaMember("CFuncMover", "m_iszPathNodeStart")]
	public string PathNodeStart
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszPathNodeStart"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszPathNodeStart", value); }
	}

	// m_eMoveType
	[SchemaMember("CFuncMover", "m_eMoveType")]
	public new ref CFuncMoverMove_t MoveType => ref Schema.GetRef<CFuncMoverMove_t>(this.Handle, "CFuncMover", "m_eMoveType");

	// m_bIsReversing
	[SchemaMember("CFuncMover", "m_bIsReversing")]
	public ref bool IsReversing => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bIsReversing");

	// m_vTarget
	[SchemaMember("CFuncMover", "m_vTarget")]
	public new Vector Target => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncMover", "m_vTarget");

	// m_flStartSpeed
	[SchemaMember("CFuncMover", "m_flStartSpeed")]
	public ref float StartSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flStartSpeed");

	// m_flPathLocation
	[SchemaMember("CFuncMover", "m_flPathLocation")]
	public ref float PathLocation => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flPathLocation");

	// m_flT
	[SchemaMember("CFuncMover", "m_flT")]
	public ref float T => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flT");

	// m_nCurrentNodeIndex
	[SchemaMember("CFuncMover", "m_nCurrentNodeIndex")]
	public ref Int32 CurrentNodeIndex => ref Schema.GetRef<Int32>(this.Handle, "CFuncMover", "m_nCurrentNodeIndex");

	// m_nPreviousNodeIndex
	[SchemaMember("CFuncMover", "m_nPreviousNodeIndex")]
	public ref Int32 PreviousNodeIndex => ref Schema.GetRef<Int32>(this.Handle, "CFuncMover", "m_nPreviousNodeIndex");

	// m_bFixedOrientation
	[SchemaMember("CFuncMover", "m_bFixedOrientation")]
	public ref bool FixedOrientation => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bFixedOrientation");

	// m_bFixedPitch
	[SchemaMember("CFuncMover", "m_bFixedPitch")]
	public ref bool FixedPitch => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bFixedPitch");

	// m_eSolidType
	[SchemaMember("CFuncMover", "m_eSolidType")]
	public ref SolidType_t SolidType => ref Schema.GetRef<SolidType_t>(this.Handle, "CFuncMover", "m_eSolidType");

	// m_bIsMoving
	[SchemaMember("CFuncMover", "m_bIsMoving")]
	public ref bool IsMoving => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bIsMoving");

	// m_flTimeToReachMaxSpeed
	[SchemaMember("CFuncMover", "m_flTimeToReachMaxSpeed")]
	public ref float TimeToReachMaxSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeToReachMaxSpeed");

	// m_flDistanceToReachMaxSpeed
	[SchemaMember("CFuncMover", "m_flDistanceToReachMaxSpeed")]
	public ref float DistanceToReachMaxSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flDistanceToReachMaxSpeed");

	// m_flTimeToReachZeroSpeed
	[SchemaMember("CFuncMover", "m_flTimeToReachZeroSpeed")]
	public ref float TimeToReachZeroSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeToReachZeroSpeed");

	// m_flDistanceToReachZeroSpeed
	[SchemaMember("CFuncMover", "m_flDistanceToReachZeroSpeed")]
	public ref float DistanceToReachZeroSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flDistanceToReachZeroSpeed");

	// m_flTimeMovementStart
	[SchemaMember("CFuncMover", "m_flTimeMovementStart")]
	public ref float TimeMovementStart => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeMovementStart");

	// m_flTimeMovementStop
	[SchemaMember("CFuncMover", "m_flTimeMovementStop")]
	public ref float TimeMovementStop => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeMovementStop");

	// m_hStopAtNode
	[SchemaMember("CFuncMover", "m_hStopAtNode")]
	public CHandle<CMoverPathNode> StopAtNode => Schema.GetDeclaredClass<CHandle<CMoverPathNode>>(this.Handle, "CFuncMover", "m_hStopAtNode");

	// m_flPathLocationToBeginStop
	[SchemaMember("CFuncMover", "m_flPathLocationToBeginStop")]
	public ref float PathLocationToBeginStop => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flPathLocationToBeginStop");

	// m_iszStartForwardSound
	[SchemaMember("CFuncMover", "m_iszStartForwardSound")]
	public string StartForwardSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszStartForwardSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszStartForwardSound", value); }
	}

	// m_iszLoopForwardSound
	[SchemaMember("CFuncMover", "m_iszLoopForwardSound")]
	public string LoopForwardSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszLoopForwardSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszLoopForwardSound", value); }
	}

	// m_iszStopForwardSound
	[SchemaMember("CFuncMover", "m_iszStopForwardSound")]
	public string StopForwardSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszStopForwardSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszStopForwardSound", value); }
	}

	// m_iszStartReverseSound
	[SchemaMember("CFuncMover", "m_iszStartReverseSound")]
	public string StartReverseSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszStartReverseSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszStartReverseSound", value); }
	}

	// m_iszLoopReverseSound
	[SchemaMember("CFuncMover", "m_iszLoopReverseSound")]
	public string LoopReverseSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszLoopReverseSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszLoopReverseSound", value); }
	}

	// m_iszStopReverseSound
	[SchemaMember("CFuncMover", "m_iszStopReverseSound")]
	public string StopReverseSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszStopReverseSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszStopReverseSound", value); }
	}

	// m_iszArriveAtDestinationSound
	[SchemaMember("CFuncMover", "m_iszArriveAtDestinationSound")]
	public string ArriveAtDestinationSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMover", "m_iszArriveAtDestinationSound"); }
		set { Schema.SetString(this.Handle, "CFuncMover", "m_iszArriveAtDestinationSound", value); }
	}

	// m_OnMovementEnd
	[SchemaMember("CFuncMover", "m_OnMovementEnd")]
	public CEntityIOOutput OnMovementEnd => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncMover", "m_OnMovementEnd");

	// m_bStartAtEnd
	[SchemaMember("CFuncMover", "m_bStartAtEnd")]
	public ref bool StartAtEnd => ref Schema.GetRef<bool>(this.Handle, "CFuncMover", "m_bStartAtEnd");

	// m_eOrientationUpdate
	[SchemaMember("CFuncMover", "m_eOrientationUpdate")]
	public ref CFuncMoverOrientationUpdate_t OrientationUpdate => ref Schema.GetRef<CFuncMoverOrientationUpdate_t>(this.Handle, "CFuncMover", "m_eOrientationUpdate");

	// m_flTimeStartOrientationChange
	[SchemaMember("CFuncMover", "m_flTimeStartOrientationChange")]
	public ref float TimeStartOrientationChange => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeStartOrientationChange");

	// m_flTimeToBlendToNewOrientation
	[SchemaMember("CFuncMover", "m_flTimeToBlendToNewOrientation")]
	public ref float TimeToBlendToNewOrientation => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flTimeToBlendToNewOrientation");

	// m_flDurationBlendToNewOrientationRan
	[SchemaMember("CFuncMover", "m_flDurationBlendToNewOrientationRan")]
	public ref float DurationBlendToNewOrientationRan => ref Schema.GetRef<float>(this.Handle, "CFuncMover", "m_flDurationBlendToNewOrientationRan");

	// m_qOriginalOrientation
	[SchemaMember("CFuncMover", "m_qOriginalOrientation")]
	public Quaternion OriginalOrientation => Schema.GetDeclaredClass<Quaternion>(this.Handle, "CFuncMover", "m_qOriginalOrientation");

}
