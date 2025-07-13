namespace AssetTool
{
    [JsonAsset("BinkMediaTexture")]
    public class UBinkMediaTexture : UTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}