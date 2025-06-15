namespace AssetTool
{
    [JsonAsset("BTTask_MoveDirectlyToward")]
    public class UBTTask_MoveDirectlyToward : UBTTask_MoveTo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}