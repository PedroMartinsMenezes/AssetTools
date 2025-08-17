namespace AssetTool
{
    [JsonAsset("TextureGraphBase")]
    public class UTextureGraphBase : UMixInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureGraph")]
    public class UTextureGraph : UTextureGraphBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureGraphInstance")]
    public class UTextureGraphInstance : UTextureGraphBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}