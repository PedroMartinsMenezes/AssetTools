namespace AssetTool
{
    [JsonAsset("LiveLinkCustomTimeStep")]
    public class ULiveLinkCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}