namespace AssetTool
{
    public class FMaterialLayersFunctions
    {
        public FString KeyString_DEPRECATED;

        [Location("void FMaterialLayersFunctions::SerializeLegacy(FArchive& Ar)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref KeyString_DEPRECATED);
        }
    }
}
