namespace AssetTool
{
    [JsonAsset("TutorialSettings")]
    public class UTutorialSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}