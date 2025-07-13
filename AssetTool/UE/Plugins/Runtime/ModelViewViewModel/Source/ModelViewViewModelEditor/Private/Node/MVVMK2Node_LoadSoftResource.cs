namespace AssetTool
{
    [JsonAsset("MVVMK2Node_LoadSoftResource")]
    public class UMVVMK2Node_LoadSoftResource : UK2Node_LoadAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMK2Node_LoadSoftTexture")]
    public class UMVVMK2Node_LoadSoftTexture : UMVVMK2Node_LoadSoftResource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMK2Node_LoadSoftMaterial")]
    public class UMVVMK2Node_LoadSoftMaterial : UMVVMK2Node_LoadSoftResource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}