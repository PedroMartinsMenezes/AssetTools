namespace AssetTool
{
    [JsonAsset("BTService_BlackboardBase")]
    public class UBTService_BlackboardBase : UBTService
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}