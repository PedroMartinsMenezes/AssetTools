using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FFoliageMeshInfo_Old : ITransferible
    {
        public List<FFoliageInstanceCluster_Deprecated> InstanceClusters;
        public List<FFoliageInstance_Deprecated> Instances;
        public UInt32 Settings;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageMeshInfo_Old& MeshInfo)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InstanceClusters);
            transfer.Move(ref Instances);
            transfer.Move(ref Settings);
            return this;
        }
    }

    public class FFoliageInstanceCluster_Deprecated : ITransferible
    {
        public FBoxSphereBounds Bounds;
        public UInt32 ClusterComponent;
        public int32[] InstanceIndices;

        [Location("friend FArchive& operator<<(FArchive& Ar, FFoliageInstanceCluster_Deprecated& OldCluster)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Bounds);
            transfer.Move(ref ClusterComponent);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() || !transfer.Supports.VER_UE4_FOLIAGE_SETTINGS_TYPE)
            {
                transfer.Move(ref InstanceIndices);
            }
            return this;
        }
    }

    public class FFoliageInstancePlacementInfo
    {
        public FVector Location;
        public FRotator Rotation;
        public FRotator PreAlignRotation;
        public FVector3f DrawScale3D;
        public float ZOffset;
        public EFoliageInstanceFlags Flags;
    }

    public class FFoliageInstance_Deprecated : FFoliageInstancePlacementInfo, ITransferible
    {
        public UInt32 Base;
        public int32 OldClusterIndex;
        public FGuid ProceduralGuid;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageInstance_Deprecated& Instance)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Base);
            transfer.Move(ref Location);
            transfer.Move(ref Rotation);
            transfer.Move(ref DrawScale3D);
            if (!transfer.Supports.FoliageUsingHierarchicalISMC)
            {
                transfer.Move(ref OldClusterIndex);
                transfer.Move(ref PreAlignRotation);
                transfer.MoveEnum(ref Flags);
                Flags |= OldClusterIndex == -1 ? EFoliageInstanceFlags.FOLIAGE_InstanceDeleted : EFoliageInstanceFlags.Unknown;
            }
            else
            {
                transfer.Move(ref PreAlignRotation);
                transfer.MoveEnum(ref Flags);
            }
            transfer.Move(ref ZOffset);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.ProceduralGuid)
            {
                transfer.Move(ref ProceduralGuid);
            }
            return this;
        }
    }

    public class FFoliageMeshInfo_Deprecated : ITransferible
    {
        public UInt32 Component;
        public List<FFoliageInstanceCluster_Deprecated> OldInstanceClusters;
        public List<FFoliageInstance> Instances;
        public FGuid FoliageTypeUpdateGuid;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageMeshInfo_Deprecated& MeshInfo)")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.FoliageUsingHierarchicalISMC)
                transfer.Move(ref Component);
            else
                transfer.Move(ref OldInstanceClusters);

            if (!transfer.GlobalObjects.IsFilterEditorOnly() || !transfer.Supports.VER_UE4_FOLIAGE_SETTINGS_TYPE)
                transfer.Move(ref Instances);

            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.AddedFoliageTypeUpdateGuid)
                transfer.Move(ref FoliageTypeUpdateGuid);

            return this;
        }
    }

    public class FFoliageMeshInfo_Deprecated2 : ITransferible
    {
        public UInt32 Component;
        public List<FFoliageInstance> Instances;
        public FGuid FoliageTypeUpdateGuid;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageMeshInfo_Deprecated2& MeshInfo)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Component);
            transfer.Move(ref Instances);
            transfer.Move(ref FoliageTypeUpdateGuid);
            return this;
        }
    }

    public class FFoliageInstance : FFoliageInstancePlacementInfo, ITransferible
    {
        public FGuid ProceduralGuid;
        public Int32 BaseId;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageInstance& Instance)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Location);
            transfer.Move(ref Rotation);
            transfer.Move(ref DrawScale3D);
            transfer.Move(ref PreAlignRotation);
            transfer.Move(ref ProceduralGuid);
            transfer.MoveEnum(ref Flags);
            transfer.Move(ref ZOffset);
            transfer.Move(ref BaseId);
            return this;
        }
    }

    public class FFoliageInfo : ITransferible
    {
        public EFoliageImplType Type;
        public FFoliageImpl Implementation;
        public List<FFoliageInstance> Instances;
        public FGuid FoliageTypeUpdateGuid;

        [Location("FArchive& operator<<(FArchive& Ar, FFoliageInfo& Info)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Type);
            Implementation ??= CreateImplementation(Type);
            if (Implementation is { })
                Implementation.Move(transfer);
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
                transfer.Move(ref Instances);
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
                transfer.Move(ref FoliageTypeUpdateGuid);
            return this;
        }

        private static FFoliageImpl CreateImplementation(EFoliageImplType type)
        {
            if (type == EFoliageImplType.StaticMesh)
                return new FFoliageStaticMesh();
            else if (type == EFoliageImplType.Actor)
                return new FFoliageActor();
            else if (type == EFoliageImplType.ISMActor)
                return new FFoliageISMActor();
            else
                return default;
        }
    }

    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FFoliageStaticMesh), "FFoliageStaticMesh")]
    [JsonDerivedType(typeof(FFoliageActor), "FFoliageActor")]
    [JsonDerivedType(typeof(FFoliageISMActor), "FFoliageISMActor")]
    public abstract class FFoliageImpl : ITransferible
    {
        public virtual ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FFoliageStaticMesh : FFoliageImpl
    {
        public FObjectPtr Component;

        [Location("void FFoliageStaticMesh::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Component);
            return this;
        }
    }

    public class FFoliageActor : FFoliageImpl
    {
        public List<FWeakObjectPtr> ActorInstances_Deprecated;
        public List<FObjectPtr> ActorInstances;
        public UInt32 ActorClass;

        [Location("void FFoliageActor::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.FoliageActorSupportNoWeakPtr)
                transfer.Move(ref ActorInstances_Deprecated);
            else
                transfer.Move(ref ActorInstances);
            transfer.Move(ref ActorClass);
            return this;
        }
    }

    public class FFoliageISMActor : FFoliageImpl
    {
        public FGuid Guid;
        public FISMClientHandle ClientHandle;
        public Dictionary<TInt32, List<FTransform>> ISMDefinition;
        public FObjectPtr ActorClass;

        [Location("void FFoliageISMActor::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref ClientHandle);
            transfer.Move(ref ISMDefinition);
            transfer.Move(ref ActorClass);
            return this;
        }
    }

    [Flags]
    public enum EFoliageInstanceFlags : UInt32
    {
        Unknown = 0,
        FOLIAGE_AlignToNormal = 0x00000001,
        FOLIAGE_NoRandomYaw = 0x00000002,
        FOLIAGE_Readjusted = 0x00000004,
        FOLIAGE_InstanceDeleted = 0x00000008
    }

    public enum EFoliageImplType : uint8
    {
        Unknown = 0,
        StaticMesh = 1,
        Actor = 2,
        ISMActor = 3
    }
}