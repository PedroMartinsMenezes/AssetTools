namespace AssetTool
{
    [JsonAsset("WaterBodyExclusionVolume")]
    public class AWaterBodyExclusionVolume : APhysicsVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}