namespace AssetTool
{
    [JsonAsset("ChaosEventRelay")]
    public class UChaosEventRelay : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}