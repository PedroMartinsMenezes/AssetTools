namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceAudioSpectrum")]
    public class UNiagaraDataInterfaceAudioSpectrum : UNiagaraDataInterfaceAudioSubmix
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}