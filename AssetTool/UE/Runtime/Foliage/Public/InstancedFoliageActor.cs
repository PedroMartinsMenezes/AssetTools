namespace AssetTool
{
    [JsonAsset("InstancedFoliageActor")]
    public class AInstancedFoliageActor : AISMPartitionActor
    {
        public FFoliageInstanceBaseCache InstanceBaseCache;
        public Dictionary<TUInt32, FFoliageMeshInfo_Old> OldFoliageMeshes;
        public Dictionary<TUInt32, FFoliageMeshInfo_Deprecated> FoliageMeshes_Deprecated;
        public Dictionary<TUInt32, FFoliageMeshInfo_Deprecated2> FoliageMeshes_Deprecated2;
        public Dictionary<TUInt32, FFoliageInfo> FoliageInfos;

        [Location("void AInstancedFoliageActor::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && transfer.Supports.CrossLevelBase)
            {
                transfer.Move(ref InstanceBaseCache);
            }
            if (!transfer.Supports.VER_UE4_FOLIAGE_SETTINGS_TYPE)
            {
                transfer.Move(ref OldFoliageMeshes);
            }
            else
            {
                if (!transfer.Supports.CrossLevelBase)
                {
                    transfer.Move(ref FoliageMeshes_Deprecated);
                }
                else if (!transfer.Supports.FoliageActorSupport)
                {
                    transfer.Move(ref FoliageMeshes_Deprecated2);
                }
                else
                {
                    transfer.Move(ref FoliageInfos);
                }
            }
            return this;
        }
    }
}