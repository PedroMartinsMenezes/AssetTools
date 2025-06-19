namespace AssetTool
{
    [JsonAsset("BlackboardData")]
    public class UBlackboardData : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}