namespace AssetTool
{
    [JsonAsset("LandscapeEditLayerBase")]
    public class ULandscapeEditLayerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditLayerPersistent")]
    public class ULandscapeEditLayerPersistent : ULandscapeEditLayerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditLayer")]
    public class ULandscapeEditLayer : ULandscapeEditLayerPersistent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditLayerProcedural")]
    public class ULandscapeEditLayerProcedural : ULandscapeEditLayerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeEditLayerSplines")]
    public class ULandscapeEditLayerSplines : ULandscapeEditLayerPersistent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}