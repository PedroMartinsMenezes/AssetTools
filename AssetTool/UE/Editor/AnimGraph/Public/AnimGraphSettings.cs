namespace AssetTool
{
    [JsonAsset("AnimGraphSettings")]
    public class UAnimGraphSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}