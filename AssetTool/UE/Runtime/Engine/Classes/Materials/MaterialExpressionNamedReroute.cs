namespace AssetTool
{
    [JsonAsset("MaterialExpressionNamedRerouteBase")]
    public class UMaterialExpressionNamedRerouteBase : UMaterialExpressionRerouteBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNamedRerouteDeclaration")]
    public class UMaterialExpressionNamedRerouteDeclaration : UMaterialExpressionNamedRerouteBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionNamedRerouteUsage")]
    public class UMaterialExpressionNamedRerouteUsage : UMaterialExpressionNamedRerouteBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}