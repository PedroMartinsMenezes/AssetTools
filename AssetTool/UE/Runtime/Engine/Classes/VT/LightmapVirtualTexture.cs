namespace AssetTool
{
    [JsonAsset("LightMapVirtualTexture2D")]
    public class ULightMapVirtualTexture2D : UTexture2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}