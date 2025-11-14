namespace AssetTool
{
    [JsonAsset("BlackboardData")]
    public class UBlackboardData : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}