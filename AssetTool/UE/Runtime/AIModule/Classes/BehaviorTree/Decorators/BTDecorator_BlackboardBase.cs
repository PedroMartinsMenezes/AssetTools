namespace AssetTool
{
    [JsonAsset("BTDecorator_BlackboardBase")]
    public class UBTDecorator_BlackboardBase : UBTDecorator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}