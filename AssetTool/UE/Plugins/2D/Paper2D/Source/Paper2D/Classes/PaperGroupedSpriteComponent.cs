namespace AssetTool
{
    [JsonAsset("PaperGroupedSpriteComponent")]
    public class UPaperGroupedSpriteComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}