namespace AssetTool
{
    [JsonAsset("InterchangeShaderPortsAPI")]
    public class UInterchangeShaderPortsAPI : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeShaderNode")]
    public class UInterchangeShaderNode : UInterchangeBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeFunctionCallShaderNode")]
    public class UInterchangeFunctionCallShaderNode : UInterchangeShaderNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeShaderGraphNode")]
    public class UInterchangeShaderGraphNode : UInterchangeShaderNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}