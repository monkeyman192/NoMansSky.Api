using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSpaceCombatEnabled : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionSpaceCombatEnabled(long address) : base(address)
	{

	}
}