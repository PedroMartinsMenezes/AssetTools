namespace AssetTool
{
    [JsonAsset("BinkMediaTexture")]
    public class UBinkMediaTexture : UTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}