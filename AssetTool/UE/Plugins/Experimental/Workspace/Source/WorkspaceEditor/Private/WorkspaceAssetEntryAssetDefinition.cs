namespace AssetTool
{
    [JsonAsset("AssetDefinition_WorkspaceAssetEntry")]
    public class UAssetDefinition_WorkspaceAssetEntry : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}