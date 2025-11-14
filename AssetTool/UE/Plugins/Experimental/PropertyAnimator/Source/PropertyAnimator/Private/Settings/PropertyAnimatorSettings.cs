namespace AssetTool
{
    [JsonAsset("PropertyAnimatorSettings")]
    public class UPropertyAnimatorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}