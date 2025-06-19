namespace AssetTool
{
    [JsonAsset("PaperTileMapComponent")]
    public class UPaperTileMapComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}