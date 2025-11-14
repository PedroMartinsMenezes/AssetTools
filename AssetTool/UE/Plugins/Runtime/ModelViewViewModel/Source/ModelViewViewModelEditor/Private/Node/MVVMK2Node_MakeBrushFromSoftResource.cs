namespace AssetTool
{
    [JsonAsset("MVVMK2Node_MakeBrushFromSoftResource")]
    public class UMVVMK2Node_MakeBrushFromSoftResource : UK2Node_LoadAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMK2Node_MakeBrushFromSoftTexture")]
    public class UMVVMK2Node_MakeBrushFromSoftTexture : UMVVMK2Node_MakeBrushFromSoftResource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMK2Node_MakeBrushFromSoftMaterial")]
    public class UMVVMK2Node_MakeBrushFromSoftMaterial : UMVVMK2Node_MakeBrushFromSoftResource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}