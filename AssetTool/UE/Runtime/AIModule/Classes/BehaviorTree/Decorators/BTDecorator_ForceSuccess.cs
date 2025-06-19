namespace AssetTool
{
    [JsonAsset("BTDecorator_ForceSuccess")]
    public class UBTDecorator_ForceSuccess : UBTDecorator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}