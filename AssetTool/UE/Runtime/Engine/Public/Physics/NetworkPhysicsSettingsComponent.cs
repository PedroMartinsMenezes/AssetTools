namespace AssetTool
{
    [JsonAsset("NetworkPhysicsSettingsComponent")]
    public class UNetworkPhysicsSettingsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}