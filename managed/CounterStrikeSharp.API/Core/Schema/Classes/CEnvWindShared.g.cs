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
public partial class CEnvWindShared : NativeObject, ICEnvWindShared
{
    public CEnvWindShared (IntPtr pointer) : base(pointer) {}

	// m_flStartTime
	[SchemaMember("CEnvWindShared", "m_flStartTime")]
	public ref float StartTime => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flStartTime");

	// m_iWindSeed
	[SchemaMember("CEnvWindShared", "m_iWindSeed")]
	public ref UInt32 WindSeed => ref Schema.GetRef<UInt32>(this.Handle, "CEnvWindShared", "m_iWindSeed");

	// m_iMinWind
	[SchemaMember("CEnvWindShared", "m_iMinWind")]
	public ref UInt16 MinWind => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iMinWind");

	// m_iMaxWind
	[SchemaMember("CEnvWindShared", "m_iMaxWind")]
	public ref UInt16 MaxWind => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iMaxWind");

	// m_windRadius
	[SchemaMember("CEnvWindShared", "m_windRadius")]
	public ref Int32 WindRadius => ref Schema.GetRef<Int32>(this.Handle, "CEnvWindShared", "m_windRadius");

	// m_iMinGust
	[SchemaMember("CEnvWindShared", "m_iMinGust")]
	public ref UInt16 MinGust => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iMinGust");

	// m_iMaxGust
	[SchemaMember("CEnvWindShared", "m_iMaxGust")]
	public ref UInt16 MaxGust => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iMaxGust");

	// m_flMinGustDelay
	[SchemaMember("CEnvWindShared", "m_flMinGustDelay")]
	public ref float MinGustDelay => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flMinGustDelay");

	// m_flMaxGustDelay
	[SchemaMember("CEnvWindShared", "m_flMaxGustDelay")]
	public ref float MaxGustDelay => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flMaxGustDelay");

	// m_flGustDuration
	[SchemaMember("CEnvWindShared", "m_flGustDuration")]
	public ref float GustDuration => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flGustDuration");

	// m_iGustDirChange
	[SchemaMember("CEnvWindShared", "m_iGustDirChange")]
	public ref UInt16 GustDirChange => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iGustDirChange");

	// m_location
	[SchemaMember("CEnvWindShared", "m_location")]
	public Vector Location => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvWindShared", "m_location");

	// m_iszGustSound
	[SchemaMember("CEnvWindShared", "m_iszGustSound")]
	public ref Int32 GustSound => ref Schema.GetRef<Int32>(this.Handle, "CEnvWindShared", "m_iszGustSound");

	// m_iWindDir
	[SchemaMember("CEnvWindShared", "m_iWindDir")]
	public ref Int32 WindDir => ref Schema.GetRef<Int32>(this.Handle, "CEnvWindShared", "m_iWindDir");

	// m_flWindSpeed
	[SchemaMember("CEnvWindShared", "m_flWindSpeed")]
	public ref float WindSpeed => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flWindSpeed");

	// m_currentWindVector
	[SchemaMember("CEnvWindShared", "m_currentWindVector")]
	public Vector CurrentWindVector => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvWindShared", "m_currentWindVector");

	// m_CurrentSwayVector
	[SchemaMember("CEnvWindShared", "m_CurrentSwayVector")]
	public Vector CurrentSwayVector => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvWindShared", "m_CurrentSwayVector");

	// m_PrevSwayVector
	[SchemaMember("CEnvWindShared", "m_PrevSwayVector")]
	public Vector PrevSwayVector => Schema.GetDeclaredClass<Vector>(this.Handle, "CEnvWindShared", "m_PrevSwayVector");

	// m_iInitialWindDir
	[SchemaMember("CEnvWindShared", "m_iInitialWindDir")]
	public ref UInt16 InitialWindDir => ref Schema.GetRef<UInt16>(this.Handle, "CEnvWindShared", "m_iInitialWindDir");

	// m_flInitialWindSpeed
	[SchemaMember("CEnvWindShared", "m_flInitialWindSpeed")]
	public ref float InitialWindSpeed => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flInitialWindSpeed");

	// m_OnGustStart
	[SchemaMember("CEnvWindShared", "m_OnGustStart")]
	public CEntityIOOutput OnGustStart => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CEnvWindShared", "m_OnGustStart");

	// m_OnGustEnd
	[SchemaMember("CEnvWindShared", "m_OnGustEnd")]
	public CEntityIOOutput OnGustEnd => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CEnvWindShared", "m_OnGustEnd");

	// m_flVariationTime
	[SchemaMember("CEnvWindShared", "m_flVariationTime")]
	public ref float VariationTime => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flVariationTime");

	// m_flSwayTime
	[SchemaMember("CEnvWindShared", "m_flSwayTime")]
	public ref float SwayTime => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flSwayTime");

	// m_flSimTime
	[SchemaMember("CEnvWindShared", "m_flSimTime")]
	public ref float SimTime => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flSimTime");

	// m_flSwitchTime
	[SchemaMember("CEnvWindShared", "m_flSwitchTime")]
	public ref float SwitchTime => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flSwitchTime");

	// m_flAveWindSpeed
	[SchemaMember("CEnvWindShared", "m_flAveWindSpeed")]
	public ref float AveWindSpeed => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flAveWindSpeed");

	// m_bGusting
	[SchemaMember("CEnvWindShared", "m_bGusting")]
	public ref bool Gusting => ref Schema.GetRef<bool>(this.Handle, "CEnvWindShared", "m_bGusting");

	// m_flWindAngleVariation
	[SchemaMember("CEnvWindShared", "m_flWindAngleVariation")]
	public ref float WindAngleVariation => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flWindAngleVariation");

	// m_flWindSpeedVariation
	[SchemaMember("CEnvWindShared", "m_flWindSpeedVariation")]
	public ref float WindSpeedVariation => ref Schema.GetRef<float>(this.Handle, "CEnvWindShared", "m_flWindSpeedVariation");

	// m_iEntIndex
	[SchemaMember("CEnvWindShared", "m_iEntIndex")]
	public CEntityIndex EntIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CEnvWindShared", "m_iEntIndex");

}