namespace AssetTool
{
    [JsonAsset("PropertyAnimatorSettings")]
    public class UPropertyAnimatorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}