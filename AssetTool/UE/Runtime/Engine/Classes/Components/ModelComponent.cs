namespace AssetTool
{
    [JsonAsset("ModelComponent")]
    public class UModelComponent : UPrimitiveComponent
    {
        public FObjectPtr Model;
        public int32 DummyZoneIndex;
        public TIndirectArray<FModelElement> Elements;
        public int32 ComponentIndex;
        public uint16[] Nodes;

        [Location("void UModelComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref Model);

            if (!transfer.Supports.VER_UE4_REMOVE_ZONES_FROM_MODEL)
            {
                transfer.Move(ref DummyZoneIndex);
                transfer.Move(ref Elements);
            }
            else
            {
                transfer.Move(ref Elements);
            }

            transfer.Move(ref ComponentIndex);
            transfer.Move(ref Nodes);

            return this;
        }
    }
}