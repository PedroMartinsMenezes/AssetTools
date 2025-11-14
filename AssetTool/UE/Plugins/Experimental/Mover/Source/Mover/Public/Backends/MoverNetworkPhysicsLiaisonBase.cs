namespace AssetTool
{
    [JsonAsset("MoverNetworkPhysicsLiaisonComponentBase")]
    public class UMoverNetworkPhysicsLiaisonComponentBase : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}