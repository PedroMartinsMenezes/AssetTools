namespace AssetTool
{
    [JsonAsset("AvaViewportSettings")]
    public class UAvaViewportSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}