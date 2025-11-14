namespace AssetTool
{
    [JsonAsset("LiveLinkSubjectProperties")]
    public class ULiveLinkSubjectProperties : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderLiveLinkSource")]
    public class UTakeRecorderLiveLinkSource : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}