namespace AssetTool
{
    [JsonAsset("AssetDefinitionRegistry")]
    public class UAssetDefinitionRegistry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}