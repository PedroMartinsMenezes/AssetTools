namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceBase")]
    public class UNiagaraDataInterfaceBase : UNiagaraMergeable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
