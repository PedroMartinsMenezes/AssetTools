namespace AssetTool
{
    [JsonAsset("Font")]
    public class UFont : UObject
    {
        public Dictionary<TUInt16, TUInt16> CharRemap;

        [Location("void UFont::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref CharRemap);
            return this;
        }
    }

    [TransferibleStruct("FontCharacter")]
    public class FFontCharacter : ITransferible
    {
        public Int32 StartU;
        public Int32 StartV;
        public Int32 USize;
        public Int32 VSize;
        public byte TextureIndex;
        public Int32 VerticalOffset;

        public ITransferible Move(Transfer transfer)
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
