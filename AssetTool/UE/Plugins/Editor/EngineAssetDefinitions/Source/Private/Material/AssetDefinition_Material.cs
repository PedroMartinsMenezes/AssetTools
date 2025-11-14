namespace AssetTool
{
    [JsonAsset("AssetDefinition_Material")]
    public class UAssetDefinition_Material : UAssetDefinition_MaterialInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}