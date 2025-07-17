namespace AssetTool
{
    [JsonAsset("LyraHealthComponent")]
    public class ULyraHealthComponent : UGameFrameworkComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}