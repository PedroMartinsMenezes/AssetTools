namespace AssetTool
{
    [JsonAsset("TutorialStateSettings")]
    public class UTutorialStateSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}