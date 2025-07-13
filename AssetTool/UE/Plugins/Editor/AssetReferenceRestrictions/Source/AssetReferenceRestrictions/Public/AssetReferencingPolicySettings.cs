namespace AssetTool
{
    [JsonAsset("AssetReferencingPolicySettings")]
    public class UAssetReferencingPolicySettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}