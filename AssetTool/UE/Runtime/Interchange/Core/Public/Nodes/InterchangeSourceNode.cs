namespace AssetTool
{
    [JsonAsset("InterchangeSourceNode")]
    public class UInterchangeSourceNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}