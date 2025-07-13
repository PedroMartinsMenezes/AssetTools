namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeSkeletalMeshRemapPinsBySection")]
    public class UCustomizableObjectNodeSkeletalMeshRemapPinsBySection : UCustomizableObjectNodeRemapPinsByNameDefaultPin
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeSkeletalMeshPinDataSection")]
    public class UCustomizableObjectNodeSkeletalMeshPinDataSection : UCustomizableObjectNodePinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeSkeletalMeshPinDataMesh")]
    public class UCustomizableObjectNodeSkeletalMeshPinDataMesh : UCustomizableObjectNodeSkeletalMeshPinDataSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeSkeletalMeshPinDataImage")]
    public class UCustomizableObjectNodeSkeletalMeshPinDataImage : UCustomizableObjectNodeSkeletalMeshPinDataSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeSkeletalMeshPinDataLayout")]
    public class UCustomizableObjectNodeSkeletalMeshPinDataLayout : UCustomizableObjectNodeSkeletalMeshPinDataSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeSkeletalMesh")]
    public class UCustomizableObjectNodeSkeletalMesh : UCustomizableObjectNodeMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}