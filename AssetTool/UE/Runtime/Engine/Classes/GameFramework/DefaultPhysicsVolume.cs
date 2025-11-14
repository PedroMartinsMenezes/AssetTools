namespace AssetTool
{
    [JsonAsset("DefaultPhysicsVolume")]
    public class ADefaultPhysicsVolume : APhysicsVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}