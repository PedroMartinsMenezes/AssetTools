namespace AssetTool
{
    [JsonAsset("BTDecorator_BlueprintBase")]
    public class UBTDecorator_BlueprintBase : UBTDecorator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}