namespace AssetTool
{
    [JsonAsset("LyraHeroComponent")]
    public class ULyraHeroComponent : UPawnComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}