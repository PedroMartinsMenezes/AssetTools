namespace AssetTool
{
    [JsonAsset("AssetDefinition_WaterWaves")]
    public class UAssetDefinition_WaterWaves : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}