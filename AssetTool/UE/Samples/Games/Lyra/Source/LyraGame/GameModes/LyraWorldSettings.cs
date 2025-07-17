namespace AssetTool
{
    [JsonAsset("LyraWorldSettings")]
    public class ALyraWorldSettings : AWorldSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}