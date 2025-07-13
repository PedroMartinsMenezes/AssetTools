namespace AssetTool
{
    [JsonAsset("UVEditorUVTransformPropertiesBase")]
    public class UUVEditorUVTransformPropertiesBase : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVTransformProperties")]
    public class UUVEditorUVTransformProperties : UUVEditorUVTransformPropertiesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVQuickTransformProperties")]
    public class UUVEditorUVQuickTransformProperties : UUVEditorUVTransformProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVAlignProperties")]
    public class UUVEditorUVAlignProperties : UUVEditorUVTransformPropertiesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVDistributeProperties")]
    public class UUVEditorUVDistributeProperties : UUVEditorUVTransformPropertiesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVTransformOperatorFactory")]
    public class UUVEditorUVTransformOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}