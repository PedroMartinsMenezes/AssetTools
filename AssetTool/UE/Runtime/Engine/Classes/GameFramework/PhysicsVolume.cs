namespace AssetTool
{
    [JsonAsset("PhysicsVolume")]
    public class APhysicsVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}