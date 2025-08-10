namespace AssetTool
{
    [JsonAsset("DNAAsset")]
    public class UDNAAsset : UAssetUserData
    {
        public WorkaroundPad Pad = new();

        [Location("void UDNAAsset::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            //static TSharedPtr<IDNAReader> ReadDNAFromStream(rl4::BoundedIOStream* Stream, EDNADataLayer Layer, uint16 MaxLOD)
            //void BinaryStreamReaderImpl::read()
            //archive >> dna; //21092 -> 103714

            //static TSharedPtr<IDNAReader> ReadDNAFromStream(rl4::BoundedIOStream* Stream, EDNADataLayer Layer, uint16 MaxLOD)
            //void BinaryStreamReaderImpl::read()
            //archive >> dna; //103714 -> 4233768

            Pad.Move(transfer, transfer.GlobalObjects.CurrentObject.NextOffset - transfer.Position);

            return this;
        }
    }
}