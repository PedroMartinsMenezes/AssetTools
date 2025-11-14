namespace AssetTool
{
    [JsonAsset("AssetDefinition_VectorFieldStatic")]
    public class UAssetDefinition_VectorFieldStatic : UAssetDefinition_VectorField
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}