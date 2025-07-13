namespace AssetTool
{
    [JsonAsset("AssetDefinition_Material")]
    public class UAssetDefinition_Material : UAssetDefinition_MaterialInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}