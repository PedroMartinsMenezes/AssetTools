namespace AssetTool
{
    [JsonAsset("PCGBaseTextureData")]
    public class UPCGBaseTextureData : UPCGSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTextureData")]
    public class UPCGTextureData : UPCGBaseTextureData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}