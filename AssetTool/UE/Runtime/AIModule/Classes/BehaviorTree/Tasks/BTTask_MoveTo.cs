namespace AssetTool
{
    [JsonAsset("BTTask_MoveTo")]
    public class UBTTask_MoveTo : UBTTask_BlackboardBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}