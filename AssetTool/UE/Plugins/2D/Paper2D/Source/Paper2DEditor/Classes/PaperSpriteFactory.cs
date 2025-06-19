namespace AssetTool
{
    [JsonAsset("PaperSpriteFactory")]
    public class UPaperSpriteFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}