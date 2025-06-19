namespace AssetTool
{
    [JsonAsset("AssetDefinition_StateTree")]
    public class UAssetDefinition_StateTree : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}