namespace AssetTool
{
    [JsonAsset("BTTask_WaitBlackboardTime")]
    public class UBTTask_WaitBlackboardTime : UBTTask_Wait
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}