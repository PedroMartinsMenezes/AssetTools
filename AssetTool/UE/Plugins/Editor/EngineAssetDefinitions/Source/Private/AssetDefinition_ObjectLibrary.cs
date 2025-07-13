namespace AssetTool
{
    [JsonAsset("AssetDefinition_ObjectLibrary")]
    public class UAssetDefinition_ObjectLibrary : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}