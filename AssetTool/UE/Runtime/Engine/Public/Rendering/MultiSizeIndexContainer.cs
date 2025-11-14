namespace AssetTool
{
    public class FMultiSizeIndexContainer : ITransferable
    {
        public FBool bOldNeedsCPUAccess;
        public byte DataTypeSize;
        public TBulkList<TUInt16> IndexBuffer16;
        public TBulkList<TUInt32> IndexBuffer32;

        [Location("void FMultiSizeIndexContainer::Serialize(FArchive& Ar, bool bNeedsCPUAccess)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_KEEP_SKEL_MESH_INDEX_DATA)
            {
                transfer.Move(ref bOldNeedsCPUAccess);
            }
            transfer.Move(ref DataTypeSize);
            if (DataTypeSize == 0)
            {
                throw new NotImplementedException();
            }
            else if (DataTypeSize == 2)
            {
                transfer.Move(ref IndexBuffer16);
            }
            else
            {
                transfer.Move(ref IndexBuffer32);
            }
            return this;
        }
    }
}
