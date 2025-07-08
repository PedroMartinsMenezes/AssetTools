namespace AssetTool
{
    [JsonAsset("AjaTimecodeProvider")]
    public class UAjaTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}