namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreSettings")]
    public class UPropertyAnimatorCoreSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}