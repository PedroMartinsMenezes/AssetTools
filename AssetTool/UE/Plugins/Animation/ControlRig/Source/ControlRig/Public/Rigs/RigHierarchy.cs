namespace AssetTool
{
    [JsonAsset("RigHierarchy")]
    public class URigHierarchy : UObject
    {
        public Int32 ElementCount;
        public List<FRigElementKey> Keys = [];
        public List<FRigBaseElement> Elements = [];
        public Dictionary<FRigElementKey, FRigElementKey> PreviousNameMap;
        public Dictionary<FRigElementKey, FRigElementKey> PreviousParentMap;

        [Location("void URigHierarchy::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            transfer.Move(ref ElementCount);
            Keys.Resize(transfer, ElementCount);
            Elements.Resize(transfer, ElementCount, true);
            for (int ElementIndex = 0; ElementIndex < ElementCount; ElementIndex++)
            {
                Keys[ElementIndex].Move(transfer);
                Elements[ElementIndex] ??= MakeElement(Keys[ElementIndex].Type);
                Elements[ElementIndex].Move(transfer, ESerializationPhase.StaticData);
            }
            for (int ElementIndex = 0; ElementIndex < ElementCount; ElementIndex++)
            {
                Elements[ElementIndex].Move(transfer, ESerializationPhase.InterElementData);
            }
            if (Supports.RigHierarchyStoringPreviousNames)
            {
                transfer.Move(ref PreviousNameMap);
                transfer.Move(ref PreviousParentMap);
            }
            return this;
        }

        private static FRigBaseElement MakeElement(ERigElementType InElementType)
        {
            FRigBaseElement Element = null;
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
                case ERigElementType.RigidBody:
                    Element = new FRigRigidBodyElement();
                    break;
                case ERigElementType.Reference:
                    Element = new FRigReferenceElement();
                    break;
            }
            return Element;
        }
    }
}