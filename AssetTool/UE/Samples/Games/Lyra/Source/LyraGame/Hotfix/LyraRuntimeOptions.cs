namespace AssetTool
{
    [JsonAsset("LyraRuntimeOptions")]
    public class ULyraRuntimeOptions : URuntimeOptionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}