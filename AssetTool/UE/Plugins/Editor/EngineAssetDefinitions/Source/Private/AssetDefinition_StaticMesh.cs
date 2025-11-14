namespace AssetTool
{
    [JsonAsset("AssetDefinition_StaticMesh")]
    public class UAssetDefinition_StaticMesh : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}