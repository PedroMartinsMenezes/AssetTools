namespace AssetTool
{
    [JsonAsset("MoverNetworkPhysicsLiaisonComponentBase")]
    public class UMoverNetworkPhysicsLiaisonComponentBase : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}