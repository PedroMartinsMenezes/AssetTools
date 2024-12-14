namespace AssetTool
{
    [JsonAsset("MaterialExpressionStaticSwitchParameter")]
    public class UMaterialExpressionStaticSwitchParameter : UMaterialExpressionStaticBoolParameter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}