namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanPerformance")]
    public class UAssetDefinition_MetaHumanPerformance : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}