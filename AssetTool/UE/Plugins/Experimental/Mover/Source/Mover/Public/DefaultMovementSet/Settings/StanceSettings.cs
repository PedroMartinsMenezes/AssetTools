namespace AssetTool
{
    [JsonAsset("StanceSettings")]
    public class UStanceSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}