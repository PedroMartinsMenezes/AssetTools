namespace AssetTool
{
    [JsonAsset("RCExternalTexture")]
    public class URCExternalTexture : UTexture2DDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}