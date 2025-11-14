namespace AssetTool
{
    [JsonAsset("AnimGraphSettings")]
    public class UAnimGraphSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}