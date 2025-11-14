namespace AssetTool
{
    [JsonAsset("DataflowGroomContent")]
    public class UDataflowGroomContent : UDataflowSkeletalContent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}