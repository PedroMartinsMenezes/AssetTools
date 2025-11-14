namespace AssetTool
{
    [JsonAsset("NiagaraScriptBase")]
    public class UNiagaraScriptBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}