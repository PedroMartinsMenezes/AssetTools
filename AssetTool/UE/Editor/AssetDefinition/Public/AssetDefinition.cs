namespace AssetTool
{
    [JsonAsset("AssetDefinition")]
    public class UAssetDefinition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}