namespace AssetTool
{
    [JsonAsset("GenlockedTimecodeProvider")]
    public class UGenlockedTimecodeProvider : UTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}