namespace AssetTool
{
    [JsonAsset("BTCompositeNode")]
    public class UBTCompositeNode : UBTNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}