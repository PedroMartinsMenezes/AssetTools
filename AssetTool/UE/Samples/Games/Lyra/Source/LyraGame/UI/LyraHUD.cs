namespace AssetTool
{
    [JsonAsset("LyraHUD")]
    public class ALyraHUD : AHUD
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}