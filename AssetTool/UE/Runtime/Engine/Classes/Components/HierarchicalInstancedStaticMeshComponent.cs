using System.ComponentModel;

namespace AssetTool
{
    [JsonAsset("HierarchicalInstancedStaticMeshComponent")]
    public class UHierarchicalInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public List<FClusterNode_DEPRECATED> ClusterTree_DEPRECATED;

        [Description("TSharedPtr<TArray<FClusterNode>, ESPMode::ThreadSafe>")]
        public TBulkList<FClusterNode> ClusterTreePtr;

        [Location("void UHierarchicalInstancedStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.HISMCClusterTreeMigration)
            {
                transfer.Move(ref ClusterTree_DEPRECATED);
            }
            else
            {
                transfer.Move(ref ClusterTreePtr);
            }

            return this;
        }
    }

    public class FClusterNode_DEPRECATED : ITransferible
    {
        public FVector3f BoundMin;
        public int32 FirstChild;
        public FVector3f BoundMax;
        public int32 LastChild;
        public int32 FirstInstance;
        public int32 LastInstance;

        [Location("friend FArchive& operator<<(FArchive& Ar, FClusterNode_DEPRECATED& NodeData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BoundMin);
            transfer.Move(ref FirstChild);
            transfer.Move(ref BoundMax);
            transfer.Move(ref LastChild);
            transfer.Move(ref FirstInstance);
            transfer.Move(ref LastInstance);
            return this;
        }
    }

    public class FClusterNode : ITransferible
    {
        public FVector3f BoundMin;
        public int32 FirstChild;
        public FVector3f BoundMax;
        public int32 LastChild;
        public int32 FirstInstance;
        public int32 LastInstance;
        public FVector3f MinInstanceScale;
        public FVector3f MaxInstanceScale;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BoundMin);
            transfer.Move(ref FirstChild);
            transfer.Move(ref BoundMax);
            transfer.Move(ref LastChild);
            transfer.Move(ref FirstInstance);
            transfer.Move(ref LastInstance);
            transfer.Move(ref MinInstanceScale);
            transfer.Move(ref MaxInstanceScale);
            return this;
        }
    }
}