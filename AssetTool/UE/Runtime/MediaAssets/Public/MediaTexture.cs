namespace AssetTool
{
    [JsonAsset("MediaTexture")]
    public class UMediaTexture : UTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}