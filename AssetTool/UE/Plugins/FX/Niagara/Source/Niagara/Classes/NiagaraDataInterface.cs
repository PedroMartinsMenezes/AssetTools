namespace AssetTool
{
    [JsonAsset("NiagaraDataInterface")]
    public class UNiagaraDataInterface : UNiagaraDataInterfaceBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}