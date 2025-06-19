namespace AssetTool
{
    [JsonAsset("BTAuxiliaryNode")]
    public class UBTAuxiliaryNode : UBTNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}