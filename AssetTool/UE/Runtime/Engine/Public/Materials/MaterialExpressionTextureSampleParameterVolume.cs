namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterVolume")]
    public class UMaterialExpressionTextureSampleParameterVolume : UMaterialExpressionTextureSampleParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}