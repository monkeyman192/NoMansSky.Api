using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 Stat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 StatGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean TakeAmountFromSeasonalData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceWaitForStatSeasonal(long address) : base(address)
	{

	}
}