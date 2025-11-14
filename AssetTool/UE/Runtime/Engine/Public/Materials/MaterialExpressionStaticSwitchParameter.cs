namespace AssetTool
{
    [JsonAsset("MaterialExpressionStaticSwitchParameter")]
    public class UMaterialExpressionStaticSwitchParameter : UMaterialExpressionStaticBoolParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}