namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreSettings")]
    public class UPropertyAnimatorCoreSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}