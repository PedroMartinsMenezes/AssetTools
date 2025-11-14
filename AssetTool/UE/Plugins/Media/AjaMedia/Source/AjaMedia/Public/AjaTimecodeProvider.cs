namespace AssetTool
{
    [JsonAsset("AjaTimecodeProvider")]
    public class UAjaTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}