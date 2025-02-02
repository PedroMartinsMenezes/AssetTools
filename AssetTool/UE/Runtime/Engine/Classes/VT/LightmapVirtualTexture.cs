namespace AssetTool
{
    [JsonAsset("LightMapVirtualTexture2D")]
    public class ULightMapVirtualTexture2D : UTexture2D, ITransferible
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        ITransferible ITransferible.Move(Transfer transfer)
        {
            return (ITransferible)Move(transfer);
        }
    }
}