namespace AssetTool
{
    [JsonAsset("TimecodeSynchronizer")]
    public class UTimecodeSynchronizer : UTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}