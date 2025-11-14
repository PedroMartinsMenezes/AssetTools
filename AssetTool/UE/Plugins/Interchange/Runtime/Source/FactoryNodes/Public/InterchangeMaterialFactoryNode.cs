namespace AssetTool
{
    [JsonAsset("InterchangeBaseMaterialFactoryNode")]
    public class UInterchangeBaseMaterialFactoryNode : UInterchangeFactoryBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialFactoryNode")]
    public class UInterchangeMaterialFactoryNode : UInterchangeBaseMaterialFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialExpressionFactoryNode")]
    public class UInterchangeMaterialExpressionFactoryNode : UInterchangeFactoryBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialInstanceFactoryNode")]
    public class UInterchangeMaterialInstanceFactoryNode : UInterchangeBaseMaterialFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialFunctionCallExpressionFactoryNode")]
    public class UInterchangeMaterialFunctionCallExpressionFactoryNode : UInterchangeMaterialExpressionFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialFunctionFactoryNode")]
    public class UInterchangeMaterialFunctionFactoryNode : UInterchangeBaseMaterialFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}