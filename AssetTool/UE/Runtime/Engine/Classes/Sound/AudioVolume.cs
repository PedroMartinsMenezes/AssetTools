namespace AssetTool
{
    [JsonAsset("AudioVolume")]
    public class AAudioVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}