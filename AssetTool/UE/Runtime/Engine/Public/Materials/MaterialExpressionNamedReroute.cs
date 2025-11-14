namespace AssetTool
{
    [JsonAsset("MaterialExpressionNamedRerouteBase")]
    public class UMaterialExpressionNamedRerouteBase : UMaterialExpressionRerouteBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNamedRerouteDeclaration")]
    public class UMaterialExpressionNamedRerouteDeclaration : UMaterialExpressionNamedRerouteBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNamedRerouteUsage")]
    public class UMaterialExpressionNamedRerouteUsage : UMaterialExpressionNamedRerouteBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}