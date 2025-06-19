namespace AssetTool
{
    [JsonAsset("MoverNetworkPhysicsLiaisonComponent")]
    public class UMoverNetworkPhysicsLiaisonComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}