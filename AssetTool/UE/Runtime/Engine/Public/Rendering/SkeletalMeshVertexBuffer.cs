namespace AssetTool
{
    public class FDummySkeletalMeshVertexBuffer : ITransferible
    {
        public FStripDataFlags StripFlags;
        public UInt32 NumTexCoords;
        public FBool bUseFullPrecisionUVs;
        public FBool bBackCompatExtraBoneInfluences;
        public FVector Dummy1;
        public FVector Dummy2;
        public Int32 ElementSize;
        public Int32 ArrayNum;
        public byte[] DummyBytes;
        public FSkeletalMeshVertexDataInterface VertexData;

        [Location("FArchive& operator<<(FArchive& Ar, FDummySkeletalMeshVertexBuffer& VertexBuffer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            transfer.Move(ref NumTexCoords);
            transfer.Move(ref bUseFullPrecisionUVs);
            if (transfer.Supports.VER_UE4_SUPPORT_GPUSKINNING_8_BONE_INFLUENCES && !transfer.Supports.UseSeparateSkinWeightBuffer)
            {
                transfer.Move(ref bBackCompatExtraBoneInfluences);
            }
            transfer.Move(ref Dummy1);
            transfer.Move(ref Dummy2);
            AllocateData();
            if (!StripFlags.IsDataStrippedForServer())
            {
                if (!transfer.Supports.UseSeparateSkinWeightBuffer)
                {
                    transfer.Move(ref ElementSize);
                    transfer.Move(ref ArrayNum);
                    transfer.Move(ref DummyBytes, ElementSize * ArrayNum);
                }
                else
                {
                    VertexData.Move(transfer);
                }
            }
            return this;
        }

        private void AllocateData()
        {
            if (!bUseFullPrecisionUVs)
            {
                ALLOCATE_VERTEX_DATA_TEMPLATE_16();
            }
            else
            {
                ALLOCATE_VERTEX_DATA_TEMPLATE_16();
            }
        }

        private void ALLOCATE_VERTEX_DATA_TEMPLATE_16()
        {
            switch (NumTexCoords)
            {
                //case 1: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs>(); break;
                //case 2: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs>(); break;
                //case 3: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs>(); break;
                //case 4: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs>(); break;
            }
        }
    }

    public interface FSkeletalMeshVertexDataInterface : ITransferible
    {
    }

    public class TSkeletalMeshVertexData<T> : ITransferible, FSkeletalMeshVertexDataInterface where T : ITransferible, new()
    {
        public TBulkList<T> Items;

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class TGPUSkinVertexBase : ITransferable
    {

    }

    public class TGPUSkinVertexFloat16Uvs : TGPUSkinVertexBase, ITransferable
    {

    }

    public class TGPUSkinVertexFloat32Uvs : TGPUSkinVertexBase, ITransferable
    {

    }
}
