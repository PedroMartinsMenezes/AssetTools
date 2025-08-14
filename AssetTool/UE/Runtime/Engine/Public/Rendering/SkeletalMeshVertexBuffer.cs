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
                ALLOCATE_VERTEX_DATA_TEMPLATE_16();
            else
                ALLOCATE_VERTEX_DATA_TEMPLATE_32();
        }

        private void ALLOCATE_VERTEX_DATA_TEMPLATE_16()
        {
            switch (NumTexCoords)
            {
                case 1: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs<Const1>>(); break;
                case 2: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs<Const2>>(); break;
                case 3: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs<Const3>>(); break;
                case 4: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat16Uvs<Const4>>(); break;
            }
        }

        private void ALLOCATE_VERTEX_DATA_TEMPLATE_32()
        {
            switch (NumTexCoords)
            {
                case 1: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat32Uvs<Const1>>(); break;
                case 2: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat32Uvs<Const2>>(); break;
                case 3: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat32Uvs<Const3>>(); break;
                case 4: VertexData = new TSkeletalMeshVertexData<TGPUSkinVertexFloat32Uvs<Const4>>(); break;
            }
        }
    }

    public interface FSkeletalMeshVertexDataInterface : ITransferible
    {
    }

    public class TSkeletalMeshVertexData<T> : FSkeletalMeshVertexDataInterface where T : ITransferible, new()
    {
        public TBulkList<T> Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }

    public class TGPUSkinVertexBase : ITransferible
    {
        public FPackedNormal TangentX;
        public FPackedNormal TangentZ;

        [Location("void TGPUSkinVertexBase::Serialize(FArchive& Ar)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TangentX);
            transfer.Move(ref TangentZ);
            return this;
        }
    }

    public class TGPUSkinVertexFloat16Uvs<T> : TGPUSkinVertexBase, ITransferible where T : ConstInt, new()
    {
        public FVector3f Position;
        public FVector2DHalf[] UVs = new FVector2DHalf[new T().Value];

        [Location("friend FArchive& operator<<(FArchive& Ar, TGPUSkinVertexFloat16Uvs& V)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Position);
            transfer.Move(ref UVs, UVs.Length);
            return this;
        }
    }

    public class TGPUSkinVertexFloat32Uvs<T> : TGPUSkinVertexBase, ITransferible where T : ConstInt, new()
    {
        public FVector3f Position;
        public FVector2f[] UVs = new FVector2f[new T().Value];

        [Location("friend FArchive& operator<<(FArchive& Ar, TGPUSkinVertexFloat32Uvs& V)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Position);
            transfer.Move(ref UVs, UVs.Length);
            return this;
        }
    }
}
