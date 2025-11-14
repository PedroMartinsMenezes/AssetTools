namespace AssetTool
{
    [JsonAsset("PaperFlipbookComponent")]
    public class UPaperFlipbookComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}