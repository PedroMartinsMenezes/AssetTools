namespace AssetTool
{
    [JsonAsset("MaterialExpressionTextureSampleParameterVolume")]
    public class UMaterialExpressionTextureSampleParameterVolume : UMaterialExpressionTextureSampleParameter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}