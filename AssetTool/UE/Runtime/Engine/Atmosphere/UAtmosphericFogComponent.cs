namespace AssetTool
{
    [JsonAsset("AtmosphericFogComponent")]
    public class UAtmosphericFogComponent : USkyAtmosphereComponent
    {
        public FByteBulkData TempTransmittanceData;
        public FByteBulkData TempIrradianceData;
        public FByteBulkData TempInscatterData;
        public Int32 CounterVal;

        public UAtmosphericFogComponent()
        {
            bIsAtmosphericFog = true;
        }

        [Location("void UAtmosphericFogComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.RemovedAtmosphericFog)
            {
                if (transfer.Supports.VER_UE4_ATMOSPHERIC_FOG_CACHE_DATA)
                {
                    transfer.Move(ref TempTransmittanceData);
                    transfer.Move(ref TempIrradianceData);
                }
                transfer.Move(ref TempInscatterData);
                transfer.Move(ref CounterVal);
            }
            return this;
        }
    }
}
