namespace AssetTool
{
    [JsonAsset("NetworkPhysicsSettingsComponent")]
    public class UNetworkPhysicsSettingsComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}