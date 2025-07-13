namespace AssetTool
{
    [JsonAsset("MassAgentSyncTrait")]
    public class UMassAgentSyncTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassAgentCapsuleCollisionSyncTrait")]
    public class UMassAgentCapsuleCollisionSyncTrait : UMassAgentSyncTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassAgentMovementSyncTrait")]
    public class UMassAgentMovementSyncTrait : UMassAgentSyncTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassAgentOrientationSyncTrait")]
    public class UMassAgentOrientationSyncTrait : UMassAgentSyncTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassAgentFeetLocationSyncTrait")]
    public class UMassAgentFeetLocationSyncTrait : UMassAgentSyncTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}