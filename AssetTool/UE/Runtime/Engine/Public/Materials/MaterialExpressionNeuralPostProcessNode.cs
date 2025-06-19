namespace AssetTool
{
    [JsonAsset("MaterialExpressionNeuralNetworkInput")]
    public class UMaterialExpressionNeuralNetworkInput : UMaterialExpressionCustomOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNeuralNetworkOutput")]
    public class UMaterialExpressionNeuralNetworkOutput : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}