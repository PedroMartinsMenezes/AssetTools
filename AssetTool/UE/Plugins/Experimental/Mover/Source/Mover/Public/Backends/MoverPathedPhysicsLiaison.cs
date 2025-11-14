namespace AssetTool
{
    [JsonAsset("MoverPathedPhysicsLiaisonComponent")]
    public class UMoverPathedPhysicsLiaisonComponent : UMoverNetworkPhysicsLiaisonComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}