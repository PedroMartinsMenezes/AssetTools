namespace AssetTool
{
    [JsonAsset("FusionPatchImportOptions")]
    public class UFusionPatchImportOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FusionPatchCreateOptions")]
    public class UFusionPatchCreateOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}