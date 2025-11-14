namespace AssetTool
{
    [JsonAsset("LiveLinkCustomTimeStep")]
    public class ULiveLinkCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}