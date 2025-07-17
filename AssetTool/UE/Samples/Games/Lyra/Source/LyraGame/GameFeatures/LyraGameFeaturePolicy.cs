namespace AssetTool
{
    [JsonAsset("LyraGameFeaturePolicy")]
    public class ULyraGameFeaturePolicy : UDefaultGameFeaturesProjectPolicies
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraGameFeature_HotfixManager")]
    public class ULyraGameFeature_HotfixManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraGameFeature_AddGameplayCuePaths")]
    public class ULyraGameFeature_AddGameplayCuePaths : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}