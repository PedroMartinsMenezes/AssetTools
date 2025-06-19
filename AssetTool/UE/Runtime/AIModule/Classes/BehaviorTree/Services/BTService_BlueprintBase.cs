namespace AssetTool
{
    [JsonAsset("BTService_BlueprintBase")]
    public class UBTService_BlueprintBase : UBTService
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}