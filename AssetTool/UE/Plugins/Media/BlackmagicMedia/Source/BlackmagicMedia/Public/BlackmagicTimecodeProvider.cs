namespace AssetTool
{
    [JsonAsset("BlackmagicTimecodeProvider")]
    public class UBlackmagicTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}