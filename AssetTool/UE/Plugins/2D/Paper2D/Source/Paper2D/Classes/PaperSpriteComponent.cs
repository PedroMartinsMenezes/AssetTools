namespace AssetTool
{
    [JsonAsset("PaperSpriteComponent")]
    public class UPaperSpriteComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}