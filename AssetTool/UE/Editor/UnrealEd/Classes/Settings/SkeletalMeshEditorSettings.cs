namespace AssetTool
{
    [JsonAsset("SkeletalMeshEditorSettings")]
    public class USkeletalMeshEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}