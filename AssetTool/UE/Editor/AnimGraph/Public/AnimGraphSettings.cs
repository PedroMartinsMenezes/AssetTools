namespace AssetTool
{
    [JsonAsset("AnimGraphSettings")]
    public class UAnimGraphSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}