namespace AssetTool
{
    [JsonAsset("BlackboardData")]
    public class UBlackboardData : UDataAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}