using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEmitterData : NMSTemplate
{
	public NMSString0x80 Particle
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkEmitterData(long address) : base(address)
	{

	}
}