namespace AssetTool
{
    [JsonAsset("BTTask_MoveDirectlyToward")]
    public class UBTTask_MoveDirectlyToward : UBTTask_MoveTo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}