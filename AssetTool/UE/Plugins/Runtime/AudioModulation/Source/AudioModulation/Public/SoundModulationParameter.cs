namespace AssetTool
{
    [JsonAsset("SoundModulationParameter")]
    public class USoundModulationParameter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterScaled")]
    public class USoundModulationParameterScaled : USoundModulationParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterFrequencyBase")]
    public class USoundModulationParameterFrequencyBase : USoundModulationParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterFrequency")]
    public class USoundModulationParameterFrequency : USoundModulationParameterFrequencyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterFilterFrequency")]
    public class USoundModulationParameterFilterFrequency : USoundModulationParameterFrequencyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterLPFFrequency")]
    public class USoundModulationParameterLPFFrequency : USoundModulationParameterFilterFrequency
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterHPFFrequency")]
    public class USoundModulationParameterHPFFrequency : USoundModulationParameterFilterFrequency
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterBipolar")]
    public class USoundModulationParameterBipolar : USoundModulationParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterVolume")]
    public class USoundModulationParameterVolume : USoundModulationParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationParameterAdditive")]
    public class USoundModulationParameterAdditive : USoundModulationParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}