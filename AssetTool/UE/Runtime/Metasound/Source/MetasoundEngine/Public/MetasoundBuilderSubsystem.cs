namespace AssetTool
{
    [JsonAsset("MetaSoundBuilderBase")]
    public class UMetaSoundBuilderBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundPatchBuilder")]
    public class UMetaSoundPatchBuilder : UMetaSoundBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundSourceBuilder")]
    public class UMetaSoundSourceBuilder : UMetaSoundBuilderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundBuilderSubsystem")]
    public class UMetaSoundBuilderSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}