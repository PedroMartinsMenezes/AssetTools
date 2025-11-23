namespace AssetTool
{
    [JsonAsset("LandscapeHeightfieldCollisionComponent")]
    public class ULandscapeHeightfieldCollisionComponent : USceneComponent
    {
        public FWordBulkData CollisionHeightData;
        public FByteBulkData DominantLayerData;
        public FBool bCooked;
        public uint8[] CookedCollisionData;
        public FByteBulkData PhysicalMaterialRenderData;

        [Location("void ULandscapeHeightfieldCollisionComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.VER_UE4_LANDSCAPE_COLLISION_DATA_COOKING)
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
                    if (transfer.Supports.LandscapePhysicalMaterialRenderData)
                    {
                        transfer.Move(ref PhysicalMaterialRenderData);
                    }
                }
            }
            return this;
        }
    }
}