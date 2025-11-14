namespace AssetTool
{
    [JsonAsset("PCGComponent")]
    public class UPCGComponent : UActorComponent
    {
        public List<SettingsPair> DynamicallyTrackedKeysToSettings;

        [Location("void UPCGComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DynamicTrackingKeysSerializedInComponent)
            {
                transfer.Move(ref DynamicallyTrackedKeysToSettings);
            }
            return this;
        }

        public class SettingsPair : ITransferable
        {
            public FPCGSelectionKey Key;
            public List<SettingsValue> Value;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Key);
                transfer.Move(ref Value);
                return this;
            }
        }

        public class SettingsValue : ITransferable
        {
            public FSoftObjectPtr Ptr;
            public TBool Flag;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Ptr);
                transfer.Move(ref Flag);
                return this;
            }
        }
    }
}