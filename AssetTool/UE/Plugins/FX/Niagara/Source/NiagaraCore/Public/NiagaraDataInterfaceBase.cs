namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceBase")]
    public class UNiagaraDataInterfaceBase : UNiagaraMergeable
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
