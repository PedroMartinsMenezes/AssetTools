namespace AssetTool
{
    [JsonAsset("HoldoutCompositeSettings")]
    public class UHoldoutCompositeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}