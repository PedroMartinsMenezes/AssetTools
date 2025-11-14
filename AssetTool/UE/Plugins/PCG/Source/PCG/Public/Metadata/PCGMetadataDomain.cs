using System.Diagnostics;

namespace AssetTool
{
    public class FPCGMetadataDomain : ITransferable
    {
        public List<MetadataEntry> MetadataEntries;
        public int64[] ParentKeys;

        [Location("void FPCGMetadataDomain::Serialize(FArchive& InArchive)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MetadataEntries);
            transfer.Move(ref ParentKeys);
            return this;
        }

        [Location("inline FPCGMetadataAttributeBase* AllocateEmptyAttributeFromType(int16 TypeId)")]
        public static FPCGMetadataAttributeBase AllocateEmptyAttributeFromType(EPCGMetadataTypes TypeId)
        {
            switch (TypeId)
            {
                case EPCGMetadataTypes.Float: return new FPCGMetadataAttribute<TFloat>();
                case EPCGMetadataTypes.Double: return new FPCGMetadataAttribute<TDouble>();
                case EPCGMetadataTypes.Integer32: return new FPCGMetadataAttribute<TInt32>();
                case EPCGMetadataTypes.Integer64: return new FPCGMetadataAttribute<TInt64>();
                case EPCGMetadataTypes.Vector2: return new FPCGMetadataAttribute<FVector2D>();
                case EPCGMetadataTypes.Vector: return new FPCGMetadataAttribute<FVector>();
                case EPCGMetadataTypes.Vector4: return new FPCGMetadataAttribute<FVector4>();
                case EPCGMetadataTypes.Quaternion: return new FPCGMetadataAttribute<FQuat>();
                case EPCGMetadataTypes.Transform: return new FPCGMetadataAttribute<FTransform>();
                case EPCGMetadataTypes.String: return new FPCGMetadataAttribute<FString>();
                case EPCGMetadataTypes.Boolean: return new FPCGMetadataAttributeBool();
                case EPCGMetadataTypes.Rotator: return new FPCGMetadataAttribute<FRotator>();
                case EPCGMetadataTypes.Name: return new FPCGMetadataAttribute<FName>();
                case EPCGMetadataTypes.SoftObjectPath: return new FPCGMetadataAttribute<FSoftObjectPath>();
                case EPCGMetadataTypes.SoftClassPath: return new FPCGMetadataAttribute<FSoftClassPath>();
            }
            return default;
        }

        [DebuggerDisplay("{AttributeName} {AttributeTypeId} {SerializedAttribute.Name}")]
        public class MetadataEntry : ITransferable
        {
            public FName AttributeName;
            public EPCGMetadataTypes AttributeTypeId;
            public FPCGMetadataAttributeBase SerializedAttribute;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref AttributeName);
                transfer.MoveEnum(ref AttributeTypeId);
                SerializedAttribute ??= AllocateEmptyAttributeFromType(AttributeTypeId);
                SerializedAttribute.Move(transfer);
                return this;
            }
        }
    }
}
