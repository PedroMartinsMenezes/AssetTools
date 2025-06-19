namespace AssetTool
{
    [JsonAsset("InterchangeShaderPortsAPI")]
    public class UInterchangeShaderPortsAPI : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeShaderNode")]
    public class UInterchangeShaderNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeFunctionCallShaderNode")]
    public class UInterchangeFunctionCallShaderNode : UInterchangeShaderNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeShaderGraphNode")]
    public class UInterchangeShaderGraphNode : UInterchangeShaderNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}