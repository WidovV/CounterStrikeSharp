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
public partial class CSoundEventEntity : CBaseEntity, ICSoundEventEntity
{
    public CSoundEventEntity (IntPtr pointer) : base(pointer) {}

	// m_bStartOnSpawn
	[SchemaMember("CSoundEventEntity", "m_bStartOnSpawn")]
	public ref bool StartOnSpawn => ref Schema.GetRef<bool>(this.Handle, "CSoundEventEntity", "m_bStartOnSpawn");

	// m_bToLocalPlayer
	[SchemaMember("CSoundEventEntity", "m_bToLocalPlayer")]
	public ref bool ToLocalPlayer => ref Schema.GetRef<bool>(this.Handle, "CSoundEventEntity", "m_bToLocalPlayer");

	// m_bStopOnNew
	[SchemaMember("CSoundEventEntity", "m_bStopOnNew")]
	public ref bool StopOnNew => ref Schema.GetRef<bool>(this.Handle, "CSoundEventEntity", "m_bStopOnNew");

	// m_bSaveRestore
	[SchemaMember("CSoundEventEntity", "m_bSaveRestore")]
	public ref bool SaveRestore => ref Schema.GetRef<bool>(this.Handle, "CSoundEventEntity", "m_bSaveRestore");

	// m_bSavedIsPlaying
	[SchemaMember("CSoundEventEntity", "m_bSavedIsPlaying")]
	public ref bool SavedIsPlaying => ref Schema.GetRef<bool>(this.Handle, "CSoundEventEntity", "m_bSavedIsPlaying");

	// m_flSavedElapsedTime
	[SchemaMember("CSoundEventEntity", "m_flSavedElapsedTime")]
	public ref float SavedElapsedTime => ref Schema.GetRef<float>(this.Handle, "CSoundEventEntity", "m_flSavedElapsedTime");

	// m_iszSourceEntityName
	[SchemaMember("CSoundEventEntity", "m_iszSourceEntityName")]
	public string SourceEntityName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundEventEntity", "m_iszSourceEntityName"); }
		set { Schema.SetString(this.Handle, "CSoundEventEntity", "m_iszSourceEntityName", value); }
	}

	// m_iszAttachmentName
	[SchemaMember("CSoundEventEntity", "m_iszAttachmentName")]
	public string AttachmentName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundEventEntity", "m_iszAttachmentName"); }
		set { Schema.SetString(this.Handle, "CSoundEventEntity", "m_iszAttachmentName", value); }
	}

	// m_onSoundFinished
	[SchemaMember("CSoundEventEntity", "m_onSoundFinished")]
	public CEntityIOOutput OnSoundFinished => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CSoundEventEntity", "m_onSoundFinished");

	// m_iszSoundName
	[SchemaMember("CSoundEventEntity", "m_iszSoundName")]
	public string SoundName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundEventEntity", "m_iszSoundName"); }
		set { Schema.SetString(this.Handle, "CSoundEventEntity", "m_iszSoundName", value); }
	}

	// m_hSource
	[SchemaMember("CSoundEventEntity", "m_hSource")]
	public CHandle<CEntityInstance> Source => Schema.GetDeclaredClass<CHandle<CEntityInstance>>(this.Handle, "CSoundEventEntity", "m_hSource");

}