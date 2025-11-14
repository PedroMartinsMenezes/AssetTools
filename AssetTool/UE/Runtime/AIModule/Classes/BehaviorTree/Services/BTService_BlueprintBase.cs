namespace AssetTool
{
    [JsonAsset("BTService_BlueprintBase")]
    public class UBTService_BlueprintBase : UBTService
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}