namespace AssetTool
{
    public class FMaterialLayersFunctionsRuntimeData
    {
    }

    public class FMaterialLayersFunctions : FMaterialLayersFunctionsRuntimeData, ITransferable
    {
        public FString KeyString_DEPRECATED;

        [Location("void FMaterialLayersFunctions::SerializeLegacy(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref KeyString_DEPRECATED);
            return this;
        }
    }

    public class FMaterialLayersFunctionsID : ITransferable
    {
        public List<FGuid> LayerIDs;
        public List<FGuid> BlendIDs;
        public bool[] LayerStates;

        [Location("void FMaterialLayersFunctionsID::SerializeForDDC(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LayerIDs);
            transfer.Move(ref BlendIDs);
            transfer.Move(ref LayerStates);
            return this;
        }
    }
}
