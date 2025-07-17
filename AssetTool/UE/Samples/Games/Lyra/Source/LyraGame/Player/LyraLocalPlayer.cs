namespace AssetTool
{
    [JsonAsset("LyraLocalPlayer")]
    public class ULyraLocalPlayer : UCommonLocalPlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}