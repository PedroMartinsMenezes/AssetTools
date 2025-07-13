namespace AssetTool
{
    [JsonAsset("UVEditorTransformToolDisplayProperties")]
    public class UUVEditorTransformToolDisplayProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBaseTransformToolBuilder")]
    public class UUVEditorBaseTransformToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTransformToolBuilder")]
    public class UUVEditorTransformToolBuilder : UUVEditorBaseTransformToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorAlignToolBuilder")]
    public class UUVEditorAlignToolBuilder : UUVEditorBaseTransformToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorDistributeToolBuilder")]
    public class UUVEditorDistributeToolBuilder : UUVEditorBaseTransformToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTransformTool")]
    public class UUVEditorTransformTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}