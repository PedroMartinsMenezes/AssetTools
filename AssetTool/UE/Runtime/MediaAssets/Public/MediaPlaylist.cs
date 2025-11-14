namespace AssetTool
{
    [JsonAsset("MediaPlaylist")]
    public class UMediaPlaylist : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}