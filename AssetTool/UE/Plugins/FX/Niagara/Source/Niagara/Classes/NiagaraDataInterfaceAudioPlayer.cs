namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceAudioPlayerSettings")]
    public class UNiagaraDataInterfaceAudioPlayerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceAudioPlayer")]
    public class UNiagaraDataInterfaceAudioPlayer : UNiagaraDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}