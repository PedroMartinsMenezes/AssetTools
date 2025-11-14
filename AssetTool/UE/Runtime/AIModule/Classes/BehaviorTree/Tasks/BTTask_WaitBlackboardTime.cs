namespace AssetTool
{
    [JsonAsset("BTTask_WaitBlackboardTime")]
    public class UBTTask_WaitBlackboardTime : UBTTask_Wait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}