namespace AssetTool
{
    [JsonAsset("AssetDefinition_VectorFieldAnimated")]
    public class UAssetDefinition_VectorFieldAnimated : UAssetDefinition_VectorField
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}