namespace AssetTool
{
    [JsonAsset("AssetDefinition_Workspace")]
    public class UAssetDefinition_Workspace : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}