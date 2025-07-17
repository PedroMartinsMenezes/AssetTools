namespace AssetTool
{
    [JsonAsset("LyraConfirmationScreen")]
    public class ULyraConfirmationScreen : UCommonGameDialog
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}