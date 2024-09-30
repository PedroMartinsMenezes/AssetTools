namespace AssetTool
{
    public class FMultiSizeIndexContainer
    {
        public FBool bOldNeedsCPUAccess;
        public byte DataTypeSize;
        public FRawStaticIndexBuffer16or32Interface IndexBuffer = new();

        [Location("void FMultiSizeIndexContainer::Serialize(FArchive& Ar, bool bNeedsCPUAccess)")]
        public void Move(Transfer transfer)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_KEEP_SKEL_MESH_INDEX_DATA))
            {
                transfer.Move(ref bOldNeedsCPUAccess);
            }
            transfer.Move(ref DataTypeSize);
            IndexBuffer.Move(transfer);
        }
    }
}
