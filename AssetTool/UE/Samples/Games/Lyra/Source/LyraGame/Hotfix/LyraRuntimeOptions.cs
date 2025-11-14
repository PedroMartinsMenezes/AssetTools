namespace AssetTool
{
    [JsonAsset("LyraRuntimeOptions")]
    public class ULyraRuntimeOptions : URuntimeOptionsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}