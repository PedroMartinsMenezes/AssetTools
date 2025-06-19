namespace AssetTool
{
    [JsonAsset("PhysicsMoverManager")]
    public class UPhysicsMoverManager : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}