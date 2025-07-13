namespace AssetTool
{
    [JsonAsset("AssetDefinition_World")]
    public class UAssetDefinition_World : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}