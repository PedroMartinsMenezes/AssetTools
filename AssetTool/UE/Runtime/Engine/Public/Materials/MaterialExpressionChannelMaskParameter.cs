namespace AssetTool
{
    [JsonAsset("MaterialExpressionChannelMaskParameter")]
    public class UMaterialExpressionChannelMaskParameter : UMaterialExpressionVectorParameter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}