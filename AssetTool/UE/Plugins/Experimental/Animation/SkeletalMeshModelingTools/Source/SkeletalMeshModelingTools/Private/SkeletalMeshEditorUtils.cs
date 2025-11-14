namespace AssetTool
{
    [JsonAsset("SkeletalMeshEditorContextObject")]
    public class USkeletalMeshEditorContextObject : USkeletalMeshEditorContextObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}