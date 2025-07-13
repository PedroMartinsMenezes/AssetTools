namespace AssetTool
{
    [JsonAsset("AssetDefinition_Workspace")]
    public class UAssetDefinition_Workspace : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}