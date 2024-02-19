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
public partial class CShatterGlassShardPhysics : CPhysicsProp, ICShatterGlassShardPhysics
{
    public CShatterGlassShardPhysics (IntPtr pointer) : base(pointer) {}

	// m_bDebris
	[SchemaMember("CShatterGlassShardPhysics", "m_bDebris")]
	public ref bool Debris => ref Schema.GetRef<bool>(this.Handle, "CShatterGlassShardPhysics", "m_bDebris");

	// m_hParentShard
	[SchemaMember("CShatterGlassShardPhysics", "m_hParentShard")]
	public ref UInt32 ParentShard => ref Schema.GetRef<UInt32>(this.Handle, "CShatterGlassShardPhysics", "m_hParentShard");

	// m_ShardDesc
	[SchemaMember("CShatterGlassShardPhysics", "m_ShardDesc")]
	public shard_model_desc_t ShardDesc => Schema.GetDeclaredClass<shard_model_desc_t>(this.Handle, "CShatterGlassShardPhysics", "m_ShardDesc");

}