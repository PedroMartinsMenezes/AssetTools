namespace AssetTool
{
    [JsonAsset("MediaTexture")]
    public class UMediaTexture : UTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}