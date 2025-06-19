namespace AssetTool
{
    [JsonAsset("StanceSettings")]
    public class UStanceSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}