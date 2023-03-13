using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificSubstance : NMSTemplate
{
	public GcDefaultMissionSubstanceEnum Default
	{
		get => GetValue<GcDefaultMissionSubstanceEnum>();
		set => TrySetValue<GcDefaultMissionSubstanceEnum>(value);
	}

	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DisableMultiplier
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RewardAsBlobs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseFuelMultiplier
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSpecificSubstance(long address) : base(address)
	{

	}
}