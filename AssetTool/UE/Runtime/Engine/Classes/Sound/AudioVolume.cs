namespace AssetTool
{
    [JsonAsset("AudioVolume")]
    public class AAudioVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}