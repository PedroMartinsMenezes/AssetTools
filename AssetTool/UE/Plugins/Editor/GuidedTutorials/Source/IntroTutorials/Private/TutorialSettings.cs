namespace AssetTool
{
    [JsonAsset("TutorialSettings")]
    public class UTutorialSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}