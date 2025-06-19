namespace AssetTool
{
    [JsonAsset("NetworkPhysicsSettingsComponent")]
    public class UNetworkPhysicsSettingsComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}