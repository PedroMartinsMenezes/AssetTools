namespace AssetTool
{
    [JsonAsset("SkeletalMeshEditorSettings")]
    public class USkeletalMeshEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}