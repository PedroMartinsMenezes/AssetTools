namespace AssetTool
{
    [JsonAsset("LyraContextEffectsSettings")]
    public class ULyraContextEffectsSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraContextEffectsSet")]
    public class ULyraContextEffectsSet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraContextEffectsSubsystem")]
    public class ULyraContextEffectsSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}