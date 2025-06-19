namespace AssetTool
{
    [JsonAsset("LandscapeLODStreamingProxy_DEPRECATED")]
    public class ULandscapeLODStreamingProxy_DEPRECATED : UStreamableRenderAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeComponent")]
    public class ULandscapeComponent : UPrimitiveComponent
    {
        public FMeshMapBuildData LegacyMapBuildData;
        public FLandscapeComponentGrassData GrassData;
        public FBool bCooked;

        [Location("void ULandscapeComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.MapBuildDataSeparatePackage)
            {
                LegacyMapBuildData ??= new();
                LegacyMapBuildData.MoveValue(transfer);
            }
            if (transfer.Supports.VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA)
            {
                transfer.Move(ref GrassData);
            }
            if (transfer.Supports.VER_UE4_LANDSCAPE_PLATFORMDATA_COOKING)
            {
                transfer.Move(ref bCooked);
            }
            return this;
        }
    }

    public class FLandscapeComponentGrassData : ITransferible
    {
        public List<FGuid> MaterialStateIds_DEPRECATED;
        public FGuid MaterialStateId;
        public FQuat RotationForWPO_DEPRECATED;
        public List<UInt16> DeprecatedHeightData;
        public Dictionary<TInt32, List<TUInt16>> HeightMipData;
        public TBulkList<TUInt16> CollisionHeightData;
        public TBulkList<TUInt16> SimpleCollisionHeightData;
        public Dictionary<ULandscapeGrassType, List<TUInt8>> DeprecatedWeightData;
        public UInt32 NumElements;
        public Dictionary<TUInt32, TInt32> WeightOffsets;
        public byte[] HeightWeightData;
        public uint32 GenerationHash;

        [Location("FArchive& operator<<(FArchive& Ar, FLandscapeComponentGrassData& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
            {
                if (!transfer.Supports.LandscapeSupportPerComponentGrassTypes)
                {
                    if (transfer.Supports.GrassMaterialInstanceFix)
                    {
                        transfer.Move(ref MaterialStateIds_DEPRECATED);
                    }
                    else if (transfer.Supports.VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA_MATERIAL_GUID)
                    {
                        transfer.Move(ref MaterialStateId);
                    }
                    if (transfer.Supports.GrassMaterialWPO)
                    {
                        transfer.Move(ref RotationForWPO_DEPRECATED);
                    }
                }
                else
                {
                    transfer.Move(ref GenerationHash);
                }
            }
            if (!transfer.Supports.LandscapeGrassSingleArray)
            {
                transfer.Move(ref DeprecatedHeightData);
            }
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
            {
                if (transfer.Supports.CollisionMaterialWPO)
                {
                    if (transfer.Supports.LightmassMaterialWPO)
                    {
                        transfer.Move(ref HeightMipData);
                    }
                    else
                    {
                        transfer.Move(ref CollisionHeightData);
                        transfer.Move(ref SimpleCollisionHeightData);
                    }
                }
            }
            if (!transfer.Supports.LandscapeGrassSingleArray)
            {
                transfer.Move(ref DeprecatedWeightData);
            }
            else
            {
                transfer.Move(ref NumElements);
                transfer.Move(ref WeightOffsets);
                transfer.Move(ref HeightWeightData);
            }
            return this;
        }
    }
}