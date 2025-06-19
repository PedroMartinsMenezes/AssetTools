namespace AssetTool
{
    [JsonAsset("InterchangeMeshNode")]
    public class UInterchangeMeshNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}