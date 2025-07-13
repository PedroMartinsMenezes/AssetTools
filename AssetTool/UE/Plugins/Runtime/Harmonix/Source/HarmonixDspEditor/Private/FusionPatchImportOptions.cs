namespace AssetTool
{
    [JsonAsset("FusionPatchImportOptions")]
    public class UFusionPatchImportOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FusionPatchCreateOptions")]
    public class UFusionPatchCreateOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}