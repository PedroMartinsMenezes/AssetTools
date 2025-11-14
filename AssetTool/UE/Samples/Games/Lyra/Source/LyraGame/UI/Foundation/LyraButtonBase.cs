namespace AssetTool
{
    [JsonAsset("LyraButtonBase")]
    public class ULyraButtonBase : UCommonButtonBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}