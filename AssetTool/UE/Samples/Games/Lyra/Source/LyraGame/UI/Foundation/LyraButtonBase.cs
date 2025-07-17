namespace AssetTool
{
    [JsonAsset("LyraButtonBase")]
    public class ULyraButtonBase : UCommonButtonBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}