namespace AssetTool
{
    [JsonAsset("PaperFlipbookComponent")]
    public class UPaperFlipbookComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}