namespace AssetTool
{
    [JsonAsset("StaticMeshComponent")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public List<FStaticMeshComponentLODInfo> LODData;
        public FBool bSerializeAsCookedData;
        public UTexture MeshPaintTexture;
        public UTexture MeshPaintTextureOverride;

        [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref LODData);

            bool bMeshPaintTextureUsesEditorOnly = transfer.Supports.MeshPaintTextureUsesEditorOnly;
            if (bMeshPaintTextureUsesEditorOnly)
            {
                transfer.Move(ref bSerializeAsCookedData);
                if (bSerializeAsCookedData)
                {
                    MeshPaintTexture ??= new();
                    MeshPaintTexture.Move(transfer);

                    MeshPaintTextureOverride ??= new();
                    MeshPaintTextureOverride.Move(transfer);
                }
            }

            return this;
        }
    }

    public class FPaintedVertex : ITransferible
    {
        public FVector Position;
        public FVector4 Normal;
        public FColor Color;
        public FDeprecatedSerializedPackedNormal Temp;

        public ITransferible Move2(Transfer transfer)
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