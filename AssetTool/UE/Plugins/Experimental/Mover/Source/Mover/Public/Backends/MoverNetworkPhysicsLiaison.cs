namespace AssetTool
{
    [JsonAsset("MoverNetworkPhysicsLiaisonComponent")]
    public class UMoverNetworkPhysicsLiaisonComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}