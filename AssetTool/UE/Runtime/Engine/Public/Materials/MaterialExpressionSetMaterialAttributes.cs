namespace AssetTool
{
    [JsonAsset("MaterialExpressionSetMaterialAttributes")]
    public class UMaterialExpressionSetMaterialAttributes : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            if (ArrayMovers.Count == 0)
            {
                ArrayMovers.Add("Inputs", (transfer, value) => value.ToObject<FExpressionInput>(transfer).Move(transfer));
                ArrayMovers.Add("AttributeSetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
                ArrayMovers.Add("PreEditAttributeSetTypes", (transfer, value) => value.ToObject<FGuid>(transfer).Move(transfer));
            }

            return base.Move(transfer);
        }
    }
}