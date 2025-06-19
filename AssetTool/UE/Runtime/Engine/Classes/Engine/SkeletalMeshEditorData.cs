namespace AssetTool
{
    [JsonAsset("SkeletalMeshEditorData")]
    public class USkeletalMeshEditorData : UObject
    {
        public List<FRawSkeletalMeshBulkData> RawSkeletalMeshBulkDatas;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref RawSkeletalMeshBulkDatas);
            return this;
        }
    }
}
