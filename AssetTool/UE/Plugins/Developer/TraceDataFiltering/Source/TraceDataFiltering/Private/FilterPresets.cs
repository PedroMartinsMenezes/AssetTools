namespace AssetTool
{
    [JsonAsset("LocalFilterPresetContainer")]
    public class ULocalFilterPresetContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SharedFilterPresetContainer")]
    public class USharedFilterPresetContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EngineFilterPresetContainer")]
    public class UEngineFilterPresetContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}