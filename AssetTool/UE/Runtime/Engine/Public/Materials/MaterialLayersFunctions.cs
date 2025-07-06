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
}
