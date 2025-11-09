namespace AssetTool
{
    [JsonAsset("MaterialExpressionDynamicParameter")]
    public class UMaterialExpressionDynamicParameter : UMaterialExpression
    {
        public UMaterialExpressionDynamicParameter()
        {
            ArrayMovers.Add("ParamNames", (transfer, value) => value.ToObject<FString>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}