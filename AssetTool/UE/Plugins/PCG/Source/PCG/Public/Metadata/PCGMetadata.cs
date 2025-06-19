namespace AssetTool
{
    [JsonAsset("PCGMetadata")]
    public class UPCGMetadata : UObject
    {
        public List<AttributeEntry> Attributes;
        public int64[] ParentKeys;

        [Location("void UPCGMetadata::Serialize(FArchive& InArchive)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Attributes);
            transfer.Move(ref ParentKeys);
            return this;
        }

        public class AttributeEntry : ITransferible
        {
            public FName AttributeName;
            public int32 AttributeTypeId;
            public FPCGMetadataAttributeBase SerializedAttribute;

            public ITransferible Move2(Transfer transfer)
            {
                transfer.Move(ref AttributeName);
                transfer.Move(ref AttributeTypeId);
                SerializedAttribute ??= AllocateEmptyAttributeFromType(AttributeTypeId);
                SerializedAttribute.Move2(transfer);
                return this;
            }

            public static FPCGMetadataAttributeBase AllocateEmptyAttributeFromType(int32 TypeId)
            {
                switch ((EPCGMetadataTypes)TypeId)
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
                    case EPCGMetadataTypes.Boolean: return new FPCGMetadataAttribute<FBool>();
                    case EPCGMetadataTypes.Rotator: return new FPCGMetadataAttribute<FRotator>();
                    case EPCGMetadataTypes.Name: return new FPCGMetadataAttribute<FName>();
                    case EPCGMetadataTypes.SoftObjectPath: return new FPCGMetadataAttribute<FSoftObjectPath>();
                    case EPCGMetadataTypes.SoftClassPath: return new FPCGMetadataAttribute<FSoftClassPath>();
                }
                return default;
            }
        }
    }
}