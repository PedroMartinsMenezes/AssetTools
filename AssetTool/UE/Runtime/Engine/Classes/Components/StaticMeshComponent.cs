namespace AssetTool
{
    [JsonAsset("StaticMeshComponent")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public List<FStaticMeshComponentLODInfo> LODData;
        public FBool bSerializeAsCookedData;
        public FObjectPtr MeshPaintTexture;

        [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref LODData);

            bool bMeshPaintTextureUsesEditorOnly = transfer.Supports.MeshPaintTextureUsesEditorOnly;
            if (bMeshPaintTextureUsesEditorOnly)
            {
                transfer.Move(ref bSerializeAsCookedData);
                if (bSerializeAsCookedData)
                {
                    transfer.Move(ref MeshPaintTexture);
                }
            }

            return this;
        }
    }

    public class FPaintedVertex : ITransferable
    {
        public FVector Position;
        public FVector4 Normal;
        public FColor Color;
        public FDeprecatedSerializedPackedNormal Temp;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            if (!transfer.Supports.IncreaseNormalPrecision)
            {
                transfer.Move(ref Temp);
            }
            else
            {
                transfer.Move(ref Normal);
            }
            transfer.Move(ref Color);
            return this;
        }
    }
}