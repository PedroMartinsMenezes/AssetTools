namespace AssetTool
{
    [JsonAsset("MediaTexture")]
    public class UMediaTexture : UTexture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}