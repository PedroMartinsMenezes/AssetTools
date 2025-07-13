namespace AssetTool
{
    [JsonAsset("TextureCollection")]
    public class UTextureCollection : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}