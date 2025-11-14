namespace AssetTool
{
    [JsonAsset("HoldoutCompositeSettings")]
    public class UHoldoutCompositeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}