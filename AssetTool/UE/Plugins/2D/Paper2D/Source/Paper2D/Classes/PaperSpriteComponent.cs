namespace AssetTool
{
    [JsonAsset("PaperSpriteComponent")]
    public class UPaperSpriteComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}