namespace AssetTool
{
    [JsonAsset("FusionPatch")]
    public class UFusionPatch : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}