namespace AssetTool
{
    public class FSkeletalMeshRenderData : ITransferable
    {
        public int32 MinMobileLODIdx;
        public List<FSkeletalMeshLODRenderData> LODRenderData;

        [Location("void FSkeletalMeshRenderData::Serialize(FArchive& Ar, USkinnedAsset* Owner)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref MinMobileLODIdx);
            }

            transfer.Move(ref LODRenderData);

            throw new NotImplementedException();

            //NaniteResourcesPtr->Serialize(Ar, Owner, false);

            //Ar << NumInlinedLODs << NumNonOptionalLODs;

            return this;
        }
    }

}
