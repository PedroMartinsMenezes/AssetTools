namespace AssetTool
{
    [JsonAsset("RigHierarchy")]
    public class URigHierarchy : UObject
    {
        public Int32 ElementCount;
        public List<FRigElementKey> Keys;
        public List<FRigBaseElement> Elements;
        public Dictionary<FRigElementKey, FRigElementKey> PreviousNameMap;
        public Dictionary<FRigElementKey, FRigElementKey> PreviousParentMap;
        public Dictionary<FRigElementKey, FMetadataStorage> LoadedElementMetadata;
        public FRigHierarchySerializationSettings SerializationSettings;
        public List<FName> UniqueNames;
        public int32 UncompressedSize;
        public bool bStoreCompressedBytes;
        public byte[] CompressedBytes;
        public Dictionary<FRigHierarchyKey, FRigHierarchyKey> PreviousHierarchyNameMap;
        public Dictionary<FRigHierarchyKey, FRigHierarchyKey> PreviousHierarchyParentMap;
        public int32 NumComponents;
        public List<FString> ScriptStructNames;
        public List<TInt32> IndexOfScriptStructs;
        public List<TInt64> ArchivePositionAfterComponents;
        public List<FRigBaseComponent> Components;

        [Location("void URigHierarchy::Load(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            Transfer currentTransfer = transfer;

            if (transfer.Supports.RigHierarchyCompactTransformSerialization)
            {
                transfer.Move(ref SerializationSettings);
            }
            else if (transfer.Supports.RigHierarchyCompressElements)
            {
                SerializationSettings ??= new();
                transfer.Move(ref SerializationSettings.bUseCompressedArchive);
            }

            if (SerializationSettings?.bUseCompressedArchive == true)
            {
                transfer.Move(ref UniqueNames);
                transfer.Move(ref UncompressedSize);
                transfer.Move(ref bStoreCompressedBytes);
                transfer.Move(ref CompressedBytes);
                transfer = new TransferNull(currentTransfer);
            }

            transfer.Move(ref ElementCount);

            transfer.Resize(ref Keys, ElementCount);
            transfer.Resize(ref Elements, ElementCount, true);

            bool bAllocateStoragePerElement = !transfer.Supports.RigHierarchyIndirectElementStorage;

            for (int ElementIndex = 0; ElementIndex < ElementCount; ElementIndex++)
            {
                Keys[ElementIndex].Move(transfer);
                if (bAllocateStoragePerElement)
                {
                    Elements[ElementIndex] ??= MakeElement(Keys[ElementIndex].Type);
                    Elements[ElementIndex].Move(transfer, ESerializationPhase.StaticData);
                }
            }

            if (!bAllocateStoragePerElement)
            {
                for (int ElementIndex = 0; ElementIndex < ElementCount; ElementIndex++)
                {
                    Elements[ElementIndex] ??= MakeElement(Keys[ElementIndex].Type);
                    Elements[ElementIndex].Move(transfer, ESerializationPhase.StaticData);
                }
            }

            for (int ElementIndex = 0; ElementIndex < ElementCount; ElementIndex++)
            {
                Elements[ElementIndex].Move(transfer, ESerializationPhase.InterElementData);
            }

            if (transfer.Supports.RigHierarchyStoringPreviousNames)
            {
                if (transfer.Supports.RigHierarchyPreviousNameAndParentMapUsingHierarchyKey)
                {
                    transfer.Move(ref PreviousHierarchyNameMap);
                    transfer.Move(ref PreviousHierarchyParentMap);
                }
                else
                {
                    transfer.Move(ref PreviousNameMap);
                    transfer.Move(ref PreviousParentMap);
                }
            }
            if (transfer.Supports.RigHierarchyStoresElementMetadata)
            {
                transfer.Move(ref LoadedElementMetadata);
            }
            if (transfer.Supports.RigHierarchyStoresComponents)
            {
                transfer.Move(ref NumComponents);
                if (NumComponents > 0)
                {
                    transfer.Move(ref ScriptStructNames);

                    transfer.Resize(ref IndexOfScriptStructs, NumComponents);
                    transfer.Resize(ref ArchivePositionAfterComponents, NumComponents);
                    transfer.Resize(ref Components, NumComponents);

                    for (int i = 0; i < NumComponents; i++)
                    {
                        transfer.Move(ref IndexOfScriptStructs, i);
                        transfer.Move(ref ArchivePositionAfterComponents, i);
                        transfer.Move(ref Components, i);
                    }

                }
            }
            return this;
        }

        private static FRigBaseElement MakeElement(ERigElementType InElementType)
        {
            FRigBaseElement Element = default;
            switch (InElementType)
            {
                case ERigElementType.Bone:
                    Element = new FRigBoneElement();
                    break;
                case ERigElementType.Null:
                    Element = new FRigNullElement();
                    break;
                case ERigElementType.Control:
                    Element = new FRigControlElement();
                    break;
                case ERigElementType.Curve:
                    Element = new FRigCurveElement();
                    break;
                case ERigElementType.Physics:
                    Element = new FRigPhysicsElement();
                    break;
                case ERigElementType.Reference:
                    Element = new FRigReferenceElement();
                    break;
                case ERigElementType.Connector:
                    Element = new FRigConnectorElement();
                    break;
                case ERigElementType.Socket:
                    Element = new FRigSocketElement();
                    break;
            }
            return Element;
        }
    }

    public class FMetadataStorage : ITransferable
    {
        public int32 NumEntries;
        public Dictionary<TTuple<FName, FName>, FRigBaseMetadata> Metadata;

        [Location("void URigHierarchy::FMetadataStorage::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Metadata);
            return this;
        }
    }
}