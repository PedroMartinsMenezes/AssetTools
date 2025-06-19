namespace AssetTool
{
    [JsonAsset("BTDecorator")]
    public class UBTDecorator : UBTAuxiliaryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}