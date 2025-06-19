namespace AssetTool
{
    [JsonAsset("MaterialExpressionStaticSwitchParameter")]
    public class UMaterialExpressionStaticSwitchParameter : UMaterialExpressionStaticBoolParameter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}