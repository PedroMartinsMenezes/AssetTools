namespace AssetTool
{
    [JsonAsset("CommonLegacyMovementSettings")]
    public class UCommonLegacyMovementSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}