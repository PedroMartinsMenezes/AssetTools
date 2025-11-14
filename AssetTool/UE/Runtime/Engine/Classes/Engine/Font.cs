namespace AssetTool
{
    [JsonAsset("Font")]
    public class UFont : UObject
    {
        public Dictionary<TUInt16, TUInt16> CharRemap;

        public UFont()
        {
            ArrayMovers.Add("Characters", (transfer, value) => value.ToObject<FFontCharacter>(transfer).Move(transfer));
        }

        [Location("void UFont::Serialize( FArchive& Ar )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref CharRemap);
            return this;
        }
    }

    [TransferableStruct("FontCharacter")]
    public class FFontCharacter : ITransferable
    {
        public Int32 StartU;
        public Int32 StartV;
        public Int32 USize;
        public Int32 VSize;
        public byte TextureIndex;
        public Int32 VerticalOffset;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StartU);
            transfer.Move(ref StartV);
            transfer.Move(ref USize);
            transfer.Move(ref VSize);
            transfer.Move(ref TextureIndex);
            transfer.Move(ref VerticalOffset);
            return this;
        }
    }
}
