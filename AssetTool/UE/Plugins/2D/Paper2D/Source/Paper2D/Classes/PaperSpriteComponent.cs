namespace AssetTool
{
    [JsonAsset("PaperSpriteComponent")]
    public class UPaperSpriteComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}