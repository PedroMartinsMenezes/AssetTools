namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMaterialRemapPinsByName")]
    public class UCustomizableObjectNodeMaterialRemapPinsByName : UCustomizableObjectNodeRemapPinsByName
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeMaterialPinDataParameter")]
    public class UCustomizableObjectNodeMaterialPinDataParameter : UCustomizableObjectNodePinData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeMaterial")]
    public class UCustomizableObjectNodeMaterial : UCustomizableObjectNodeMaterialBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeMaterialPinDataImage")]
    public class UCustomizableObjectNodeMaterialPinDataImage : UCustomizableObjectNodeMaterialPinDataParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeMaterialPinDataVector")]
    public class UCustomizableObjectNodeMaterialPinDataVector : UCustomizableObjectNodeMaterialPinDataParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeMaterialPinDataScalar")]
    public class UCustomizableObjectNodeMaterialPinDataScalar : UCustomizableObjectNodeMaterialPinDataParameter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}