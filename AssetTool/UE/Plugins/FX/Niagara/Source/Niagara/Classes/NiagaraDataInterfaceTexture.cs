namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceTexture")]
    public class UNiagaraDataInterfaceTexture : UObject
    {
        public uint8[] StreamData;

        [Location("void UNiagaraDataInterfaceTexture::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.TextureDataInterfaceUsesCustomSerialize)
            {
                transfer.Move(ref StreamData);
            }
            return this;
        }
    }
}