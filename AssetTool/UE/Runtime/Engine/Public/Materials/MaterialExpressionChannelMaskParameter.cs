namespace AssetTool
{
    [JsonAsset("MaterialExpressionChannelMaskParameter")]
    public class UMaterialExpressionChannelMaskParameter : UMaterialExpressionVectorParameter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}