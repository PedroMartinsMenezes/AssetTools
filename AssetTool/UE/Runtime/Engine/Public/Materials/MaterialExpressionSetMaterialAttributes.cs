namespace AssetTool
{
    [JsonAsset("MaterialExpressionSetMaterialAttributes")]
    public class UMaterialExpressionSetMaterialAttributes : UMaterialExpression
    {
        public UMaterialExpressionSetMaterialAttributes()
        {
            ArrayMovers.Add("Inputs", (transfer, value) => value.ToObject<FExpressionInput>(transfer).Move(transfer));
            ArrayMovers.Add("AttributeSetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            ArrayMovers.Add("PreEditAttributeSetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}