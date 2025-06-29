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

        [Location("void URigHierarchy::Load(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
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
                transfer.Move(ref PreviousNameMap);
                transfer.Move(ref PreviousParentMap);
            }
            if (transfer.Supports.RigHierarchyStoresElementMetadata)
            {
                transfer.Move(ref LoadedElementMetadata);
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

    public class FMetadataStorage : ITransferible
    {
        public int32 NumEntries;
        public Dictionary<TTuple<FName, FName>, FRigBaseMetadata> Metadata;

        [Location("void URigHierarchy::FMetadataStorage::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Metadata);
            return this;
        }
    }
}