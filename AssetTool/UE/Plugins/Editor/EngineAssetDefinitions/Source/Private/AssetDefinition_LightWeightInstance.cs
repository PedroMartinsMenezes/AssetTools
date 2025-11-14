namespace AssetTool
{
    [JsonAsset("AssetDefinition_LightWeightInstance")]
    public class UAssetDefinition_LightWeightInstance : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}