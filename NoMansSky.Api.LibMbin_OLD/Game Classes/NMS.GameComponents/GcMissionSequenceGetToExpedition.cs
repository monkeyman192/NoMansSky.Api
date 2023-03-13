using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceGetToExpedition : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 GalaxyMapMessage
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single CompletionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceGetToExpedition(long address) : base(address)
	{

	}
}