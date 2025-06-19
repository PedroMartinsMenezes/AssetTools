namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterVolume")]
    public class UMaterialExpressionTextureSampleParameterVolume : UMaterialExpressionTextureSampleParameter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}