namespace AssetTool
{
    [JsonAsset("TutorialStateSettings")]
    public class UTutorialStateSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}