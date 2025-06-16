namespace AssetTool
{
    [JsonAsset("PCGComponent")]
    public class UPCGComponent : UActorComponent
    {
        public Dictionary<FPCGSelectionKey, List<TTuple<FSoftObjectPtr, TBool>>> DynamicallyTrackedKeysToSettings;

        [Location("void UPCGComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DynamicTrackingKeysSerializedInComponent)
            {
                transfer.Move(ref DynamicallyTrackedKeysToSettings);
            }
            return this;
        }
    }
}