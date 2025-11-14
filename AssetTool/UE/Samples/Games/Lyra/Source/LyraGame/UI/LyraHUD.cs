namespace AssetTool
{
    [JsonAsset("LyraHUD")]
    public class ALyraHUD : AHUD
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}