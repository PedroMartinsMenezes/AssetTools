namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceBase")]
    public class UNiagaraDataInterfaceBase : UNiagaraMergeable
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
