namespace AssetTool
{
    [JsonAsset("GameFeaturesProjectPolicies")]
    public class UGameFeaturesProjectPolicies : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DefaultGameFeaturesProjectPolicies")]
    public class UDefaultGameFeaturesProjectPolicies : UGameFeaturesProjectPolicies
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}