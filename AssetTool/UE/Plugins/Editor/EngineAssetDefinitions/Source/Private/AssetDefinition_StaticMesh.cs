namespace AssetTool
{
    [JsonAsset("AssetDefinition_StaticMesh")]
    public class UAssetDefinition_StaticMesh : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}