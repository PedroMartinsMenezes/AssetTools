namespace AssetTool
{
    public class FMaterialLayersFunctionsRuntimeData
    {
    }

    public class FMaterialLayersFunctions : FMaterialLayersFunctionsRuntimeData, ITransferible
    {
        public FString KeyString_DEPRECATED;

        [Location("void FMaterialLayersFunctions::SerializeLegacy(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref KeyString_DEPRECATED);
            return this;
        }
    }

    public class FMaterialLayersFunctionsID : ITransferible
    {
        public List<FGuid> LayerIDs;
        public List<FGuid> BlendIDs;
        public List<FBool> LayerStates;

        [Location("void FMaterialLayersFunctionsID::SerializeForDDC(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LayerIDs);
            transfer.Move(ref BlendIDs);
            transfer.Move(ref LayerStates);
            return this;
        }
    }
}
