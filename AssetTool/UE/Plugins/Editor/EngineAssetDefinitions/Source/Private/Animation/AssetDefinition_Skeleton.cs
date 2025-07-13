namespace AssetTool
{
    [JsonAsset("AssetDefinition_Skeleton")]
    public class UAssetDefinition_Skeleton : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}