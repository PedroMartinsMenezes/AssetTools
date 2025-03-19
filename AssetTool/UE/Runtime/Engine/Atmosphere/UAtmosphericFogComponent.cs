namespace AssetTool
{
    [JsonAsset("AtmosphericFogComponent")]
    public class UAtmosphericFogComponent : USkyAtmosphereComponent
    {
        public FByteBulkData TempTransmittanceData = new();
        public FByteBulkData TempIrradianceData = new();
        public FByteBulkData TempInscatterData = new();
        public Int32 CounterVal;

        [Location("void UAtmosphericFogComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!Supports.RemovedAtmosphericFog)
            {
                if (Supports.VER_UE4_ATMOSPHERIC_FOG_CACHE_DATA)
                {
                    TempTransmittanceData.Move(transfer);
                    TempIrradianceData.Move(transfer);
                }
                TempInscatterData.Move(transfer);
                transfer.Move(ref CounterVal);
            }
            return this;
        }
    }
}
