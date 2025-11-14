namespace AssetTool
{
    [JsonAsset("AssetReferencingPolicySettings")]
    public class UAssetReferencingPolicySettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}