namespace AssetTool
{
    [JsonAsset("LyraWorldSettings")]
    public class ALyraWorldSettings : AWorldSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}