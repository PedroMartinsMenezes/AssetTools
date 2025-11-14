namespace AssetTool
{
    [JsonAsset("WaterBodyExclusionVolume")]
    public class AWaterBodyExclusionVolume : APhysicsVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}