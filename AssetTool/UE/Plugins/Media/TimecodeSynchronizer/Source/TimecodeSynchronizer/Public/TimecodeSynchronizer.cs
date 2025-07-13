namespace AssetTool
{
    [JsonAsset("TimecodeSynchronizer")]
    public class UTimecodeSynchronizer : UTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}