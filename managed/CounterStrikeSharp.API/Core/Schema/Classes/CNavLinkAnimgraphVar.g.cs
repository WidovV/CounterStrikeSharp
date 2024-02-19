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
public partial class CNavLinkAnimgraphVar : NativeObject, ICNavLinkAnimgraphVar
{
    public CNavLinkAnimgraphVar (IntPtr pointer) : base(pointer) {}

	// m_strAnimgraphVar
	[SchemaMember("CNavLinkAnimgraphVar", "m_strAnimgraphVar")]
	public string StrAnimgraphVar
	{
		get { return Schema.GetUtf8String(this.Handle, "CNavLinkAnimgraphVar", "m_strAnimgraphVar"); }
		set { Schema.SetString(this.Handle, "CNavLinkAnimgraphVar", "m_strAnimgraphVar", value); }
	}

	// m_unAlignmentDegrees
	[SchemaMember("CNavLinkAnimgraphVar", "m_unAlignmentDegrees")]
	public ref UInt32 AlignmentDegrees => ref Schema.GetRef<UInt32>(this.Handle, "CNavLinkAnimgraphVar", "m_unAlignmentDegrees");

}