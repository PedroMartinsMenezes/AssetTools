namespace AssetTool
{
    [JsonAsset("BlackmagicTimecodeProvider")]
    public class UBlackmagicTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}