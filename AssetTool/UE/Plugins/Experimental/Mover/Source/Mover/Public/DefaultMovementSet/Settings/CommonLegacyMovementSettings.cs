namespace AssetTool
{
    [JsonAsset("CommonLegacyMovementSettings")]
    public class UCommonLegacyMovementSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}