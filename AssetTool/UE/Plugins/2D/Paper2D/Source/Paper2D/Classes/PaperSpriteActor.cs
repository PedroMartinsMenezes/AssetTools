namespace AssetTool
{
    [JsonAsset("PaperSpriteActor")]
    public class APaperSpriteActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}