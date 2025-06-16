namespace AssetTool
{
    [JsonAsset("PCGGraphInterface")]
    public class UPCGGraphInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGraph")]
    public class UPCGGraph : UPCGGraphInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGraphInstance")]
    public class UPCGGraphInstance : UPCGGraphInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}