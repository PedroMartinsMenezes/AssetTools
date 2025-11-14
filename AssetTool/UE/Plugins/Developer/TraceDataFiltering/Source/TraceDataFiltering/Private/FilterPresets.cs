namespace AssetTool
{
    [JsonAsset("LocalFilterPresetContainer")]
    public class ULocalFilterPresetContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SharedFilterPresetContainer")]
    public class USharedFilterPresetContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EngineFilterPresetContainer")]
    public class UEngineFilterPresetContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}