namespace AssetTool
{
    [JsonAsset("MediaPlaylist")]
    public class UMediaPlaylist : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}