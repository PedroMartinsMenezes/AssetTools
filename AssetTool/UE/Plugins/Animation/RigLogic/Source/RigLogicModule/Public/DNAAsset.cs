namespace AssetTool
{
    [JsonAsset("DNAAsset")]
    public class UDNAAsset : UAssetUserData
    {
        public WorkaroundPad WorkaroundPad;

        [Location("void UDNAAsset::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            ///static TSharedPtr<IDNAReader> ReadDNAFromStream(rl4::BoundedIOStream* Stream, EDNADataLayer Layer, uint16 MaxLOD)
            ///void BinaryStreamReaderImpl::read()
            ///archive >> dna; //21092 -> 103714

            ///static TSharedPtr<IDNAReader> ReadDNAFromStream(rl4::BoundedIOStream* Stream, EDNADataLayer Layer, uint16 MaxLOD)
            ///void BinaryStreamReaderImpl::read()
            ///archive >> dna; //103714 -> 4233768

            if ((WorkaroundPad = WorkaroundPad.CreateOrDefault(transfer, WorkaroundPad, transfer.GlobalObjects.CurrentObject.NextOffset)) is { })
            {
                WorkaroundPad.Move(transfer);
            }
            return this;
        }
    }
}