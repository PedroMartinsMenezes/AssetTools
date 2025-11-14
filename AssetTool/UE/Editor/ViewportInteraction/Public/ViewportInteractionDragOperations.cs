namespace AssetTool
{
    [JsonAsset("TranslationDragOperation")]
    public class UTranslationDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneTranslationDragOperation")]
    public class UPlaneTranslationDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RotateOnAngleDragOperation")]
    public class URotateOnAngleDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScaleDragOperation")]
    public class UScaleDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UniformScaleDragOperation")]
    public class UUniformScaleDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}