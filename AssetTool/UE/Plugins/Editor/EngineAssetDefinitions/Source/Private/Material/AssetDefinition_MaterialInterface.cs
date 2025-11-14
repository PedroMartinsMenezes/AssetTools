namespace AssetTool
{
    [JsonAsset("AssetDefinition_MaterialInterface")]
    public class UAssetDefinition_MaterialInterface : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}