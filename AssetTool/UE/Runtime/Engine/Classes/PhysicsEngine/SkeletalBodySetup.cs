namespace AssetTool
{
    [JsonAsset("PhysicsAsset")]
    public class UPhysicsAsset : UObject
    {
        public Dictionary<FRigidBodyIndexPair, FBool> CollisionDisableTable;

        [Location("void UPhysicsAsset::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref CollisionDisableTable);
            return this;
        }
    }

    [JsonAsset("SkeletalBodySetup")]
    public class USkeletalBodySetup : UBodySetup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}