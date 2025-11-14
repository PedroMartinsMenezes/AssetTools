namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceAudioSpectrum")]
    public class UNiagaraDataInterfaceAudioSpectrum : UNiagaraDataInterfaceAudioSubmix
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}