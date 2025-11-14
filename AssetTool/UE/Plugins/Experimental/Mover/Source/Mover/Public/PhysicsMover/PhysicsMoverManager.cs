namespace AssetTool
{
    [JsonAsset("PhysicsMoverManager")]
    public class UPhysicsMoverManager : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}