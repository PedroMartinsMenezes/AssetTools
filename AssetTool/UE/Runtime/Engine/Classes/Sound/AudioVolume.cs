namespace AssetTool
{
    [JsonAsset("AudioVolume")]
    public class AAudioVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}