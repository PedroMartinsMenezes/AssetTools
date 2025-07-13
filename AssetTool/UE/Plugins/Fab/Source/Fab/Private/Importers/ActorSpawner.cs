namespace AssetTool
{
    [JsonAsset("FabPlaceholderSpawner")]
    public class UFabPlaceholderSpawner : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FabStaticMeshPlaceholderSpawner")]
    public class UFabStaticMeshPlaceholderSpawner : UFabPlaceholderSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FabSkeletalMeshPlaceholderSpawner")]
    public class UFabSkeletalMeshPlaceholderSpawner : UFabPlaceholderSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FabDecalPlaceholderSpawner")]
    public class UFabDecalPlaceholderSpawner : UFabPlaceholderSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}