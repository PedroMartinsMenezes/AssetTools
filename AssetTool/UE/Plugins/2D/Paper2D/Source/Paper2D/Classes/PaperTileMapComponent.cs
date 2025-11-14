namespace AssetTool
{
    [JsonAsset("PaperTileMapComponent")]
    public class UPaperTileMapComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}