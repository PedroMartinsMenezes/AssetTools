namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceCamera")]
    public class UNiagaraDataInterfaceCamera : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}