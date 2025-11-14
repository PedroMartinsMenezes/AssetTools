namespace AssetTool
{
    [JsonAsset("LyraLocalPlayer")]
    public class ULyraLocalPlayer : UCommonLocalPlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}