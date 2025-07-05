namespace AssetTool
{
    [JsonAsset("FusionPatch")]
    public class UFusionPatch : UObject
    {
        [Location("void UFusionPatch::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}