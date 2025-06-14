namespace AssetTool
{
    [JsonAsset("PhysicsMoverManager")]
    public class UPhysicsMoverManager : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}