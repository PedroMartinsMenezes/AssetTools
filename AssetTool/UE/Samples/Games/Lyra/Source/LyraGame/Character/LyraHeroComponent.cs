namespace AssetTool
{
    [JsonAsset("LyraHeroComponent")]
    public class ULyraHeroComponent : UPawnComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}