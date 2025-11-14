namespace AssetTool
{
    [JsonAsset("LyraHealthComponent")]
    public class ULyraHealthComponent : UGameFrameworkComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}