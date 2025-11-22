namespace AssetTool
{
    [JsonAsset("MaterialExpressionDynamicParameter")]
    public class UMaterialExpressionDynamicParameter : UObject
    {
        public UMaterialExpressionDynamicParameter()
        {
            ArrayMovers.Add("ParamNames", (transfer, value) => value.ToObject<FString>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}