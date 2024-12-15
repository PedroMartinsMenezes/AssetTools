namespace AssetTool
{
    [JsonAsset("LandscapeHeightfieldCollisionComponent")]
    public class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent
    {
        public FWordBulkData CollisionHeightData;
        public FByteBulkData DominantLayerData;
        public FBool bCooked;
        public List<uint8> CookedCollisionData;
        public FByteBulkData PhysicalMaterialRenderData;

        [Location("void ULandscapeHeightfieldCollisionComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!Supports.VER_UE4_LANDSCAPE_COLLISION_DATA_COOKING)
            {
                transfer.Move(ref CollisionHeightData);
                transfer.Move(ref DominantLayerData);
            }
            else
            {
                transfer.Move(ref bCooked);
                if (bCooked)
                {
                    transfer.Move(ref CookedCollisionData);
                }
                else
                {
                    transfer.Move(ref CollisionHeightData);
                    transfer.Move(ref DominantLayerData);
                    if (Supports.LandscapePhysicalMaterialRenderData)
                    {
                        transfer.Move(ref PhysicalMaterialRenderData);
                    }
                }
            }
            return this;
        }
    }
}