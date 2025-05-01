namespace AssetTool
{
    [JsonAsset("MaterialExpressionNeuralNetworkInput")]
    public class UMaterialExpressionNeuralNetworkInput : UMaterialExpressionCustomOutput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNeuralNetworkOutput")]
    public class UMaterialExpressionNeuralNetworkOutput : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}