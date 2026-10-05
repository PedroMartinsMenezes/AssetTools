namespace AssetTool
{
    [JsonAsset("PhysicsAsset")]
    public class UPhysicsAsset : UObject
    {
        public Dictionary<FRigidBodyIndexPair, TBool> CollisionDisableTable;

        [Location("void UPhysicsAsset::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref CollisionDisableTable);
            return this;
        }
    }
}